using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Financiamientos.Models.Reports
{
    class ReportMetaData
    {
        public readonly string creatorName;
        public readonly DateTime dateOfCreation;
        public readonly string dataOrigin;
        public readonly string description;

        public ReportMetaData(string creatorName, DateTime dateOfCreation, string dataOrigin, string description)
        {
            this.creatorName = creatorName;
            this.dateOfCreation = dateOfCreation;
            this.dataOrigin = dataOrigin;
            this.description = description;
        }
    }
}
