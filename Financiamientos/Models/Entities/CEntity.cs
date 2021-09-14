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
        protected IEnumerable<SqlParameter> parameters;

        public CEntity(string code) => this.code = code;
        public abstract Task<int> Insert();
        protected abstract IEnumerable<SqlParameter> setParameters();
     
    }
}
