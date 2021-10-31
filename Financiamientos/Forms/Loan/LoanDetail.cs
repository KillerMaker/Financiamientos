
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

namespace Financiamientos.Forms
{
    public partial class LoanDetail : Form
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

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lblPayedLoans_Click(object sender, EventArgs e)
        {

        }

        private async void LoanDetail_Load(object sender, EventArgs e) =>await ReloadFrom();

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
           Payment.Payment payment= new Payment.Payment(
                this,
                loan.code,
                CLoan.GetCapitalDebt((DataTable)dtgvInstallsments.DataSource),
                CLoan.GetInterestDebt((DataTable)dtgvInstallsments.DataSource),
                CLoan.GetArrearsDebt((DataTable)dtgvInstallsments.DataSource));

            payment.Show();
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
                    lblPayedCapital.Text = CLoan.GetpaidCapital((DataTable)dtgvPayments.DataSource).ToString("c");
                    lblPayedInterest.Text = CLoan.GetpaidInterest((DataTable)dtgvPayments.DataSource).ToString("c");
                    lblPayedArrears.Text = CLoan.GetpaidArrears((DataTable)dtgvPayments.DataSource).ToString("c");
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

                lbltotalAmmountRemaning.Text = CLoan.getTotalDebt((DataTable)dtgvInstallsments.DataSource).ToString("c");
                lblArrears.Text = CLoan.getTotalAmmountOfArrears((DataTable)dtgvInstallsments.DataSource).ToString();
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
    }
}
