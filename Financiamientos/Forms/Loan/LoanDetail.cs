
using Financiamientos.Models.Entities;
using Financiamientos.Forms.Payment;
using Financiamientos.Models.QueryBuilding;
using Financiamientos.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Financiamientos.Models.Interfaces;
using Financiamientos.Models.Reports;
using System.Configuration;

namespace Financiamientos.Forms
{
    public partial class LoanDetail : Form,IReportable<DataTable,ExcelReport>
    {
        public readonly Home home;
        public readonly CLoan loan;

        private DataTable loanInfo;
        public LoanDetail(Home home,CLoan loan)
        {
            this.home = home;
            this.loan = loan;
            InitializeComponent();
        }


        private async void LoanDetail_Load(object sender, EventArgs e) =>await ReloadFrom();

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Payment.Payment payment = new Payment.Payment(
                 this,
                 loan.code,
                 dtgvInstallsments.DataSource.ConvertToDataTable().GetTotalColumnSum("Estado", "Activa", 4),
                 dtgvInstallsments.DataSource.ConvertToDataTable().GetTotalColumnSum("Estado", "Activa", 5),
                 dtgvInstallsments.DataSource.ConvertToDataTable().GetTotalColumnSum("Estado", "Activa", 6)
             );

                payment.Show();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message,"Ha ocurrido un error al cargar los datos");
            }
            
        }
        
        public async Task ReloadFrom()
        {
            try
            {
                #region loan stuff
                loanInfo = await IQueryExecutor.ExecuteQuery(
                    $"SELECT CLIENTE,VENDEDOR,[FECHA DE CREACION],[MONTO FINANCIADO],ESTADO FROM VISTA_PRESTAMO WHERE FINANCIAMIENTO ='{loan.code}'");

                lblCustomer.Text = loanInfo.Rows[0].ItemArray[0].ToString();
                lblUser.Text = loanInfo.Rows[0].ItemArray[1].ToString();
                lblDate.Text = loanInfo.Rows[0].ItemArray[2].ToString();
                lblAmmount.Text = Convert.ToDouble(loanInfo.Rows[0].ItemArray[3]).ToString("c");
                lblState.Text = loanInfo.Rows[0].ItemArray[4].ToString();
                #endregion

                #region payment stuff
                dtgvPayments.DataSource = await IQueryExecutor.ExecuteQuery(
                    $"SELECT * FROM PAGO WHERE CODIGO_PRESTAMO ='{loan.code}'");

                if (dtgvPayments.Rows.Count > 0)
                {
                    lblPayedCapital.Text = dtgvPayments.DataSource.ConvertToDataTable().GetTotalColumnSum(7).ToString("C");
                    lblPayedInterest.Text = dtgvPayments.DataSource.ConvertToDataTable().GetTotalColumnSum(6).ToString("C");
                    lblPayedArrears.Text = dtgvPayments.DataSource.ConvertToDataTable().GetTotalColumnSum(5).ToString("C");
                }
                else
                {
                    lblPayedCapital.Text = "0.00 RD$";
                    lblPayedInterest.Text = "0.00 RD$";
                    lblPayedArrears.Text = "0.00 RD$";
                }
                #endregion

                #region installsment stuff

                dtgvInstallsments.DataSource = await IQueryExecutor.ExecuteQuery(
                    $"SELECT * FROM CUOTA WHERE CODIGO_PRESTAMO ='{loan.code}'");

                lbltotalAmmountRemaning.Text =
                    dtgvInstallsments.DataSource.ConvertToDataTable().GetTotalMultipleColumnSum("Estado","Activa",4,5,6).ToString("C");

                lblArrears.Text = dtgvInstallsments.DataSource.ConvertToDataTable().GetTotalColumnSum(3).ToString();
                #endregion

                #region disposing 
                loanInfo.Dispose();
                #endregion
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ha ocurrido un problema al momento de visualizar los datos");
            }
        }

        private async void btnExport_Click(object sender, EventArgs e)
        {
            try
            {
                ReportMetaData metaData = new ReportMetaData(home.user.name, DateTime.Now, "Detalle de Prestamo", "Descripcion");

                using (ExcelReport report = new ExcelReport(metaData, ConfigurationManager.AppSettings["loan-reports-path"]))
                {
                    await Export(report);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ha ocurrido un problema al momento exportar");
            }
           
        }

        public IEnumerable<DataTable> GetDataSources()
        {
            yield return (DataTable)dtgvInstallsments.DataSource;
            yield return (DataTable)dtgvPayments.DataSource;
        }

        public async Task Export(ExcelReport report)
        {
            await report.CreateAndSaveFile();
            await report.AddWorkSheet(GetDataSources());
        }
    }
}
