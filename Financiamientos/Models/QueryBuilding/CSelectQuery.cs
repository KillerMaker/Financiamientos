using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Financiamientos.Utility;

namespace Financiamientos.Models.QueryBuilding
{
     public class CSelctQuery
    {
        IEnumerable<ColumnNames> Headers;
        Tables SelectedTable;
        IEnumerable<CFilter> Filters;
        IEnumerable<CJoin> joins;
        private List<SqlParameter> Parameters;

        /// <summary>
        /// Instancia un objeto CSelectQuery
        /// </summary>
        /// <param name="Headers">Listado de los campos que seran seleccionados</param>
        /// <param name="SelectedTable">Tabla obligatoria de donde se seleccionaran los datos</param>
        /// <param name="Filters">Filtros de busqueda (Opcional)</param>
        /// <param name="joins">Uniones con otras tablas mediante criterios (Opcional)</param>
        public CSelctQuery(IEnumerable<ColumnNames> Headers, Tables SelectedTable, IEnumerable<CFilter> Filters = null, IEnumerable<CJoin> joins = null)
        {
            this.Headers = Headers;
            this.SelectedTable = SelectedTable;
            this.Filters = Filters;
            this.joins = joins;

            Parameters = new List<SqlParameter>();
        }
        
        /// <summary>
        /// Construye la cabecera (Campos que seran seleccionados) de la consulta
        /// </summary>
        /// <returns>Un listado de strings con La cabecera de la consulta</returns>
        private IEnumerable<string>buildHeaders()
        {
            string columnName = "";
            string alias = "";
            bool isFirst = true;

            foreach (ColumnNames header in Headers)
            {
                List<Tables> tables = new List<Tables>() { SelectedTable};
                foreach (CJoin j in joins)
                    tables.Add(j.table1);

                foreach(var table in tables)
                {
                    //Establece el nombre de las columnas con su respectivo alias
                    QueryObjectsSetter.setColumns(table, header, ref columnName, ref alias);

                    //En caso de ser la primera columna en el header no le agregara una ',' al principio de esa
                    yield return (header == ColumnNames.All) ? "*" : (isFirst) ?
                        $"{columnName} AS {alias}" :
                        $",{columnName} AS {alias} \n";

                    break;
                }

                isFirst = false;
            }
        }

        /// <summary>
        /// Construye la secuencia de joins de la consulta
        /// </summary>
        /// <returns>Un listado de strings con los joins de la consulta</returns>
        private IEnumerable<string> buildJoins()
        {
            string column1 = "";
            string column2 = "";
            string Join = "";
            string table = "";
            string alias = "";
            string condition = "";

            foreach (CJoin join in joins)
            {
                table = QueryObjectsSetter.setTables(join.table1); //Asigna el valor de la tabla
                Join = QueryObjectsSetter.setJoin(join.join); //Asigna el tipo de join
                condition = QueryObjectsSetter.setConditions(join.condition); //Asigna la condicion

                //Establece el valor de la primera columna del Join y sus respectivas propiedades
                QueryObjectsSetter.setColumns(join.table1, join.column1, ref column1, ref alias);

                //Establece el valor de la segunda columna del Join y sus respectivas propiedades
                QueryObjectsSetter.setColumns(join.table2, join.column2, ref column2, ref alias);

                //En caso de que el iterador join no contenga nada devolvera una cadena vacia
                yield return (join != null) ? $"{Join} {table} ON {column1} {condition} {column2} \n" : "";
            }
        }

        /// <summary>
        /// Construye la secuencia de filtros WHERE de la consulta
        /// </summary>
        /// <returns>Un listado de strings con los filtros WHERE de la consulta</returns>
        private IEnumerable<string>buildFilters()
        {
            int lenght = 0;
            int i = 0;
            byte scale = 0;
            string column = "";
            string alias = "";
            string operators = "";
            string condition = "";
            SqlDbType type=SqlDbType.Int;


            foreach (CFilter filter in Filters)
            {
                i++;
                QueryObjectsSetter.setColumns(filter.table, filter.column,ref column,ref alias);
                QueryObjectsSetter.setParametersProperties(filter.column, ref type, ref lenght, ref scale);

                SqlParameter param = new SqlParameter($"@P{i}", type, lenght);
                param.Value = filter.value;

                condition = QueryObjectsSetter.setConditions(filter.condition);
                if(filter.operators.HasValue)
                    operators = QueryObjectsSetter.setOperators(filter.operators.Value);

                param.Precision = (byte)lenght;
                param.Scale = (scale > 0) ? scale : (byte)0;
                Parameters.Add(param);

                 yield return (filter.operators.HasValue)?
                    $"{column} {condition} @P{i} {operators} \n":
                    $"{column} {condition} @P{i} \n";

            }
        }

        /// <summary>
        /// Ejecuta la consulta
        /// </summary>
        /// <returns>Un Tabla con los resultados de la consulta</returns>
        public async Task<DataTable> Launch()
        {
            string query = "SELECT \n";
            string Table = QueryObjectsSetter.setTables(SelectedTable);

            foreach (string header in buildHeaders())
                query += header;

            query += $"FROM {Table} ";
        
            foreach (string join in buildJoins())
                query += join;

            query += "WHERE ";

           foreach (string filter in buildFilters())
                query += filter;

            if (Filters == null)
                query = query.Replace(" WHERE ", "");
            if (joins == null)
                query = query.Replace(" ON ", "");

            return await IQueryExecutor.ExecuteQuery(query.Replace("\n",""), Parameters.ToArray());
        }
    }
}

