using Financiamientos.Utility;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Financiamientos.Models.QueryBuilding;
using System.Data.SqlClient;

namespace Financiamientos.Models.Entities
{
    public abstract class CEntity
    {
        public readonly string code;
        protected List<SqlParameter> parameters;

        public CEntity(string code) => this.code = code;

        public abstract Task<int> Insert();
        public async static Task<DataTable> CustomSelect(IEnumerable<ColumnNames> Headers, Tables SelectedTable, IEnumerable<CFilter> Filters = null,IEnumerable<CJoin>Joins=null)
            => await new CSelctQuery(Headers, SelectedTable, Filters, Joins).Launch();
        public async static Task<DataTable> SimpleSelect(string selectedTable,string filter = null, string value = null)
        {
            if(value!=null)
            {
                SqlParameter parameter = new SqlParameter("@P", value);
                string query = $"SELECT * FROM {selectedTable} WHERE {filter} @P";

                return await IQueryExecutor.TableReturnerExecutor(query, new SqlParameter[] { parameter });
            }
            else if(filter==null & value==null)
            {
                string query = $"SELECT * FROM {selectedTable}";
                return await IQueryExecutor.TableReturnerExecutor(query);
            }
            else
            {
                throw new Exception("El filtro y el valor deben estar o ambos nulos o ambos con valor");
            }
            
            
        }
    }
}
