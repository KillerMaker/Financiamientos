using Financiamientos.Models.Reports;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Financiamientos.Models.Interfaces
{
    interface IReportable<out TDataSource,in TReport> where TReport: Report
    {
        public IEnumerable<TDataSource> GetDataSources();
        public Task Export(TReport report);
    }
}
