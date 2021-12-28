using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using Financiamientos.Utility;
using System.Collections.Specialized;
using Financiamientos.Models.Entities;

namespace Financiamientos.Models.QueryBuilding
{
    interface IQueryExecutor
    {
        /// <summary>
        /// Funcion que ejecuta una consulta en SQL Server
        /// </summary>
        /// <param name="querys">Lista de comandos a ejecutar</param>
        /// <param name="parameters">Lista de parametros a tomar en cuenta, deben estar todos los parametros
        /// usados por los comandos pasados como parametro</param>
        /// <returns>La cantidad de filas afectadas por la secuencia de consultas a la base de datos</returns>
        public async static Task<int> ExecuteQuery(string[] querys,SqlParameter[]parameters=null)
        {
            //Se obtiene el string de conexion mediante el archivo de configuracion xml
            string connectionString = ConfigurationManager.ConnectionStrings["ADM"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                await connection.OpenAsync();
                //Se crea una transaccion en la base de datos para asegurar la integridad de los datos
                using SqlTransaction transaction = (SqlTransaction)await connection.BeginTransactionAsync();
               
                //Se crea una lista de SQLCommands que se ejecutaran uno tras otro 
                List<SqlCommand> commands= new List<SqlCommand>();
                try
                {
                    //Variable que devolvera el numero de filas afectadas por la lista de comandos
                    int rowsAffected = 0;

                    //Se itera por cada comando de la lista de comandos
                    for(int i=0; i < querys.Length; i++)
                    {
                        /*Se instancia a cada elemento y se le asigna su correspondiente query,
                         Conexion y transaccion*/
                        commands.Add(new SqlCommand(querys[i], connection, transaction));

                        if (parameters.Length > 0)
                            commands[i].Parameters.AddRange(parameters);

                        //Se Ejecuta el comando de manera asincrona y se le suma la cantidad de filas afectadas a rowsAffected
                        rowsAffected += await commands[i].ExecuteNonQueryAsync();
                    }
                    //Ejecuta los cambios hechos por todos los comandos en la base de datos
                    await transaction.CommitAsync();
                    //Devuelve la cantidad de filas afectadas por todos los comandos 
                    return rowsAffected;

                }
                catch (Exception e)
                {
                    //En caso de error se le hace un RollBack a la transaccion y se revierten los cambios hechos
                    await transaction.RollbackAsync();
                    throw new Exception(e.Message);
                }
                
            }
        }

        /// <summary>
        /// Funcion que ejecuta una consulta en SQL Server
        /// </summary>
        /// <param name="query">Comando SELECT a ejecutar</param>
        /// <param name="parameters">Listado de parametros del comando pasado como parametro</param>
        /// <returns>Una tabla con los valores devueltos por la consulta</returns>
        public async static Task<DataTable> ExecuteQuery(string query,SqlParameter[] parameters=null)
        {
            //Se obtiene el string de conexion mediante el archivo de configuracion xml
            string connectionString = ConfigurationManager.ConnectionStrings["ADM"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                DataTable table = new DataTable();
                List<string> values = new List<string>();
                await connection.OpenAsync();
                //Se crea una transaccion en la base de datos para asegurar la integridad de los datos
                using SqlTransaction transaction = (SqlTransaction)await connection.BeginTransactionAsync();

                try
                {
                    using (SqlCommand command = new SqlCommand(query, connection, transaction))
                    {
                    
                        if (parameters!=null)
                            command.Parameters.AddRange(parameters);

                        //Crea un DataReader con los resultados traidos del command
                        using (SqlDataReader reader = await command.ExecuteReaderAsync())
                        {
                            bool headerIsSet = false;
                            while (await reader.ReadAsync())
                            {
                                //Crea un Header para el DataTable
                                if (!headerIsSet)
                                {
                                    for (int i = 0; i < reader.FieldCount; i++)
                                        table.Columns.Add(reader.GetName(i).Replace("_", " ").Capitalize());

                                    /*headerIsSet se pone a true una vez puesto el header de la tabla
                                    Para no tener que hacerlo cada vez que se itere en el Reader*/
                                    headerIsSet = true;
                                }

                                //Itera por cada columna de la fila dada e inserta cada valor en el DataTable
                                for (int i = 0; i < reader.FieldCount; i++)
                                    values.Add(reader[i].ToString().Capitalize());

                                table.Rows.Add(values.ToArray());
                                values.Clear();
                            }
                        }
                    }
                    //Ejecuta los cambios en la base de datos
                    await transaction.CommitAsync();

                    //Devuelve El DataTable con valores 
                    return table;
                }
                catch (Exception e)
                {
                    //En caso de error se le hace un RollBack a la transaccion y se revierten los cambios hechos
                    await transaction.RollbackAsync();
                    throw new Exception(e.Message);
                }
                
            }
        }
        /// <summary>
        /// Funcion que ejecuta una consulta en SQL Server
        /// </summary>
        /// <param name="Headers">Litado de los campos que seran seleccionados por la consulta</param>
        /// <param name="SelectedTable">Tabla principal de la consulta</param>
        /// <param name="Filters">Listado de filtros WHERE de la consulta</param>
        /// <param name="Joins">Listado de Joins de la consulta</param>
        /// <returns>Una tabla con los valores devueltos por la consulta</returns>
        public async static Task<DataTable> ExecuteQuery(IEnumerable<ColumnNames> Headers, Tables SelectedTable, IEnumerable<CFilter> Filters = null, IEnumerable<CJoin> Joins = null)
           => await new CSelctQuery(Headers, SelectedTable, Filters, Joins).Launch();


        /// <summary>
        /// Funcion que ejecuta la consulta de seleccion de datos predeterminada para un Tipo
        /// </summary>
        /// <param name="filter">Filtro de busqueda para la consulta</param>
        /// <typeparam name="T">Tipo de cual se hara la consulta</typeparam>
        /// <returns>Una tabla con los valores devueltos por la consulta</returns>
        public async static Task<DataTable> ExecuteQuery<T>(string filter=null) where T: CEntity
        {
            string whereFilter = (filter == null) ? null : $"WHERE {filter}";

            if (typeof(T) == typeof(CCustomer))
                return await ExecuteQuery($"SELECT * FROM VISTA_CLIENTE {whereFilter}");
            else if (typeof(T) == typeof(CLoan))
                return await ExecuteQuery($"SELECT * FROM VISTA_PRESTAMO {whereFilter}");
            else if (typeof(T) == typeof(CPayment))
                return await ExecuteQuery($"SELECT * FROM PAGO {whereFilter}");
            else if (typeof(T) == typeof(CUser))
                return await ExecuteQuery($"SELECT * FROM CUOTA {whereFilter}");
            else
                throw new Exception($"El tipo {typeof(T)} no es un tipo soportado por la funcion");
        }
            

    }
}
