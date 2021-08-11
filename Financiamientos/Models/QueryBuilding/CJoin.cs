using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Financiamientos.Utility;

namespace Financiamientos.Models.QueryBuilding
{
    sealed public class CJoin
    {
        public readonly JoinType join;
        public readonly Tables table1;
        public readonly ColumnNames column1;
        public readonly Conditions condition;
        public readonly Tables table2;
        public readonly ColumnNames column2;

        public CJoin(JoinType join, Tables table, ColumnNames column1, Conditions condition, Tables table2, ColumnNames column2)
        {
            this.join = join;
            this.table1 = table;
            this.column1 = column1;
            this.condition = condition;
            this.table2 = table2;
            this.column2 = column2;
        }

    }
}
