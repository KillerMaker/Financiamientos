using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Financiamientos.Utility;

namespace Financiamientos.Models.QueryBuilding
{
    sealed public class CFilter
    {
        public readonly Tables table;
        public readonly Operators? operators;
        public readonly ColumnNames column;
        public readonly Conditions condition;
        public readonly string value;

        public CFilter(Tables table,ColumnNames column, Conditions condition, string value, Operators? operators = null)
        {
            this.table = table;
            this.operators = operators;
            this.column = column;
            this.condition = condition;
            this.value = value;
        }
    }
}
