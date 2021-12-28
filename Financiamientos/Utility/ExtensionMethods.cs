using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Financiamientos.Utility
{
    public static class ExtensionsMethods
    {
        /// <summary>
        /// Transforma la cadena de entrada para que sea seguro utilizarla en una consulta a la base de datos
        /// </summary>
        /// <param name="cadena">Cadena desde la que se ejcuta la funcion</param>
        /// <returns>La cadena limpia de posible codigo infiltrado</returns>
        public static string SQLInyectionClearString(this string s)
        {
            string c = s.ToUpper()
                .Replace("--", "")
                .Replace("'", "")
                .Replace("<", "")
                .Replace(">", "")
                .Replace("=", "")
                .Replace("!", "")
                .Replace("*", "")
                .Replace("SELECT ", "")
                .Replace("UPDATE ", "")
                .Replace("DELETE ", "")
                .Replace("DROP", "")
                .Replace("CREATE", "")
                .Replace("EXEC", "")
                .Replace("ALTER", "")
                .Replace(";", "").Capitalize();
            return c;
        }

        /// <summary>
        /// Transforma la cadena de entrada para que contenga masusculas luego de cada espacio
        /// </summary>
        /// <param name="chars">Cadena desde la que se ejecuta la funcion</param>
        /// <returns>La cadena con mauysculas tras cada espacio</returns>
        public static string Capitalize(this string s)
        {
            string c = "";
            for (int i = 0; i < s.Length; i++)
            {
                if (i == 0 || s[i - 1] == ' ')
                    c += s[i].ToString().ToUpper();
                else
                    c += s[i].ToString().ToLower();
            }
            return c;
        }
        /// <summary>
        /// Funcion que permite saber si un string contiene uno o mas valores entre rango de valores
        /// </summary>
        /// <typeparam name="T">El tipo de valores a buscar en el string</typeparam>
        /// <param name="s">El string en el que se va a buscar</param>
        /// <param name="list">La lista de valores a buscar</param>
        /// <returns>True si al menos un valor que coincide con el rango dado, 
        /// False si no contiene ninguno</returns>
        public static bool Contains<T>(this string s, List<T> list)
        {
            foreach (char c in s)
            {
                foreach (T value in list)
                {
                    if (c == Convert.ToChar(value))
                        return true;
                }
            }
            return false;
        }
        /// <summary>
        /// Funcion que permite saber si el string dado es valido como nombre
        /// </summary>
        /// <param name="s">El string a revisar</param>
        /// <returns>True de ser valido, False de no serlo</returns>
        public static bool isValidName(this string s)
        {
            if (s.Contains(new List<char>() { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' }))
                return false;

            else if (s.Contains(new List<char>() { '!', '@', '#', '$', '%', '^', '&', '*', '(', ')' }))
                return false;

            else if (s.Contains(new List<char>() { '~', '-', '=', '+', '_', '/', '[', ']', '{', '}', ',', '.', '?' }))
                return false;

            return true;
        }
        /// <summary>
        /// Funcion que permite saber si la fecha dada es valida
        /// </summary>
        /// <param name="date">Fecha a revisar</param>
        /// <returns>True de ser valida, False de no serlo</returns>
        public static bool isValidDate(this DateTime date)=>(date > DateTime.Now) ? false : true;

        /// <summary>
        /// Funcion que permite saber si de la fecha dada a la fecha actual han transcurrido
        /// mas de 18 años
        /// </summary>
        /// <param name="date">Fecha a revisar</param>
        /// <returns>True de ser cierto, False de no serlo</returns>
        public static bool isGreaterThan18(this DateTime date)
        {
            if (!isValidDate(date))
                return false;
            else
            {
                TimeSpan ageInDays = DateTime.Now - date;

                if (ageInDays.TotalDays < 6570)
                    return false;
                else
                    return true;
            }
        }
        /// <summary>
        /// Funcion que permite saber si el string dado es valido como numero de telefono
        /// </summary>
        /// <param name="s">String a revisar</param>
        /// <returns>True de ser valido, False de no serlo</returns>
        public static bool isValidPhone(this string s) => (s.Length.Equals(10)) ? true : false;

        /// <summary>
        /// Funcion que retorna la suma de todos los elementos de n numero de columnas
        /// </summary>
        /// <param name="table">Tabla de donde vienen los datos</param>
        /// <param name="columnToFilter">Nombre de la columna donde se hara el filtro where</param>
        /// <param name="valueToFilter">Valor de la columna donde se hara el filtro where</param>
        /// <param name="columns">Indice de las columnas a sumar</param>
        /// <returns></returns>
        public static float GetTotalMultipleColumnSum(this DataTable table, string columnToFilter, string valueToFilter, params int[] columns)
        {
            float total = 0;
            foreach (int i in columns)
            {
                var values = from rows in table.AsEnumerable()
                            where (rows.Field<string>(columnToFilter) == valueToFilter)&& 
                                  rows.Field<string>(columnToFilter) is not null
                            select new { total = float.Parse(rows.Field<string>(i))}.total;

                total += values.Sum();
            }

            return total;
        }
        /// <summary>
        /// Funcion que retorna la suma de todos los valores en una columna
        /// </summary>
        /// <param name="table">Tabla de donde se scaran los datos</param>
        /// <param name="column">Indice de las columna a sumar</param>
        /// <returns></returns>
        public static float GetTotalColumnSum(this DataTable table, int column)
        {
            
            var values = from rows in table.AsEnumerable()
                          where rows.Field<string>(column) is not null
                          select new { total = float.Parse(rows.Field<string>(column))}.total;
            
            return values.Sum();
        }
        /// <summary>
        /// Funcion que retorna la suma de todos los valores en una columna
        /// </summary>
        /// <param name="table">Tabla de donde se scaran los datos</param>
        /// <param name="columnToFilter">Nombre de la columna donde se hara el filtro where</param>
        /// <param name="valueToFilter">Valor de la columna donde se hara el filtro where</param>
        /// <param name="columnToSum">Indice de las columna a sumar</param>
        /// <returns></returns>
        public static float GetTotalColumnSum(this DataTable table, string columnToFilter, string valueToFilter, int columnToSum)
        {
            var values = from rows in table.AsEnumerable()
                          where rows.Field<string>(columnToFilter) == valueToFilter &&
                                rows.Field<string>(columnToFilter) is not null
                          select new { total = float.Parse(rows.Field<string>(columnToSum))}.total;
            
            return values.Sum();
            
        }

        /// <summary>
        /// Convierte un objeto a DataTable
        /// </summary>
        /// <param name="o">El objeto a convertir</param>
        /// <returns>El DataTable</returns>
        public static DataTable ConvertToDataTable(this object o)
        {
            try
            {
                return (DataTable)o;
            }
            catch(Exception e)
            {
                throw new InvalidCastException(e.Message);
            }
        }
    }

}
