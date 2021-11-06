using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Financiamientos.Models.Reports
{
    public abstract class Report:IDisposable
    {
        public string path { get; protected set; }
        public ReportMetaData metaData { get; protected set; }

        protected NameValueCollection settings;

        public Report (ReportMetaData metaData,string path)
        {
            this.path = path;
            this.metaData = metaData;
            settings = ConfigurationManager.AppSettings;
        }

        public virtual void Dispose()
        {
            settings = default;
            path = default;
            metaData = default;
        }
    }
}
