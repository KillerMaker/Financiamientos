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
     
    }
}
