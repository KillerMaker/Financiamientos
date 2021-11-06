using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Financiamientos.Models.Interfaces;
using Financiamientos.Models.QueryBuilding;
using Financiamientos.Models.Reports;

namespace Financiamientos.Forms
{
    public partial class HomeDashboard : Form,IReportable<DataTable,ExcelReport>
    {
        private readonly Home home;

        private DataTable installsmetsDueToToday;
        private DataTable last10Paymets;
        private DataTable arrears;

        public HomeDashboard(Home home)
        {
            this.home = home;
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void dtgvLast10Paymets_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private async void HomeDashboard_Load(object sender, EventArgs e)
        {
            try
            {
                installsmetsDueToToday =await IQueryExecutor.ExecuteQuery("SELECT * FROM VISTA_CUOTAS_VENCEN_HOY");
                last10Paymets= await IQueryExecutor.ExecuteQuery("SELECT * FROM ULTIMOS_10_PAGOS");
                arrears = await IQueryExecutor.ExecuteQuery("SELECT * FROM VISTA_CUOTAS_ATRASADAS");
                DataTable loanInfo= await IQueryExecutor.ExecuteQuery("SELECT * FROM VISTA_PRESTAMO_INFO");

                lblPayedLoans.Text = loanInfo.Rows[0].ItemArray[0].ToString();
                lblActiveLoans.Text = loanInfo.Rows[0].ItemArray[1].ToString();
                lblCanceledLoans.Text = loanInfo.Rows[0].ItemArray[2].ToString();
                lblOverdureLoans.Text = loanInfo.Rows[0].ItemArray[3].ToString();

                dtgvInstallsmetDueToday.DataSource = installsmetsDueToToday;
                dtgvLast10Paymets.DataSource = last10Paymets;
                dtgvArrears.DataSource = arrears;

            }
            catch(Exception error)
            {
                throw new Exception(error.Message);
            }
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            try
            {
                using (ExcelReport report = new ExcelReport(new ReportMetaData(home.user.name, DateTime.Now, "Dashboard", "Descripcion"),
                    ConfigurationManager.AppSettings["loan-reports-path"].ToString()))
                {
                    await Export(report);

                    MessageBox.Show($@"El reporte se ha creado satisfactoriamente por el usuario {report.metaData.creatorName} {Environment.NewLine} en la ruta \n:{report.path}");
                }
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message, "Ha ocurrido un error al crear el reporte");
            }
        }

        private void btnPayedLoans_Click(object sender, EventArgs e)
        {
            home.OpenForm(new Loan(home,"SELECT * FROM VISTA_PRESTAMO WHERE ESTADO ='PAGADO'"));
            Dispose();
        }

        private void btnActiveLoans_Click(object sender, EventArgs e)
        {
            home.OpenForm(new Loan(home, "SELECT * FROM VISTA_PRESTAMO WHERE ESTADO ='ACTIVO'"));
            Dispose();
        }

        private void btnCanceledLoans_Click(object sender, EventArgs e)
        {
            home.OpenForm(new Loan(home, "SELECT * FROM VISTA_PRESTAMO WHERE ESTADO ='CANCELADO'"));
            Dispose();
        }

        private void btnOverdureLoan_Click(object sender, EventArgs e)
        {
            home.OpenForm(new Loan(home, "SELECT * FROM VISTA_PRESTAMO WHERE ESTADO ='ATRASADO'"));
            Dispose();
        }


        public IEnumerable<DataTable> GetDataSources()
        {
            yield return (DataTable)dtgvArrears.DataSource;
            yield return (DataTable)dtgvInstallsmetDueToday.DataSource;
            yield return (DataTable)dtgvLast10Paymets.DataSource;
        }

        public async Task Export(ExcelReport report)
        {
            await report.CreateAndSaveFile();
            await report.AddWorkSheet(GetDataSources());
        }
    }
}
