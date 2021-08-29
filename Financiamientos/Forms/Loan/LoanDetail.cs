using Financiamientos.Models.Entities;
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
        private DataTable paymentInfo;
        private DataTable installsmentInfo;
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

        private async void LoanDetail_Load(object sender, EventArgs e)
        {
            try
            {
                #region loan stuff
                loanInfo = await IQueryExecutor.TableReturnerExecutor(
                    $"SELECT CLIENTE,VENDEDOR,[FECHA DE CREACION],[MONTO FINANCIADO],ESTADO FROM VISTA_PRESTAMO WHERE FINANCIAMIENTO ='{loan.code}'");

                lblCustomer.Text = loanInfo.Rows[0].ItemArray[0].ToString();
                lblUser.Text = loanInfo.Rows[0].ItemArray[1].ToString();
                lblDate.Text = loanInfo.Rows[0].ItemArray[2].ToString();
                lblAmmount.Text = Convert.ToDouble(loanInfo.Rows[0].ItemArray[3]).ToString("c");
                lblState.Text = loanInfo.Rows[0].ItemArray[4].ToString();
                #endregion

                #region payment stuff
                paymentInfo = await IQueryExecutor.TableReturnerExecutor(
                    $"SELECT * FROM PAGO_INFO WHERE FINANCIAMIENTO = '{loan.code}'");

                dtgvPayments.DataSource = await IQueryExecutor.TableReturnerExecutor(
                    $"SELECT * FROM PAGO WHERE CODIGO_PRESTAMO ='{loan.code}'");

                if(paymentInfo.Rows.Count>0)
                {
                    lblPayedCapital.Text = Convert.ToDouble(paymentInfo.Rows[0].ItemArray[1]).ToString("c");
                    lblPayedInterest.Text = Convert.ToDouble(paymentInfo.Rows[0].ItemArray[2]).ToString("c");
                    lblPayedArrears.Text = Convert.ToDouble(paymentInfo.Rows[0].ItemArray[3]).ToString("c");
                }
                else
                {
                    lblPayedCapital.Text = "0.00 RD$";
                    lblPayedInterest.Text = "0.00 RD$";
                    lblPayedArrears.Text = "0.00 RD$";
                }
                #endregion

                #region installsment stuff
                installsmentInfo = await IQueryExecutor.TableReturnerExecutor(
                    $"SELECT * FROM CUOTA_INFO WHERE FINANCIAMIENTO = '{loan.code}'");

                dtgvInstallsments.DataSource = await IQueryExecutor.TableReturnerExecutor(
                    $"SELECT * FROM CUOTA WHERE CODIGO_PRESTAMO ='{loan.code}'");

                 lbltotalAmmountRemaning.Text = Convert.ToDouble(installsmentInfo.Rows[0].ItemArray[1]).ToString("c");
                lblArrears.Text = installsmentInfo.Rows[0].ItemArray[2].ToString();
                #endregion

                #region disposing 
                loanInfo.Dispose();
                paymentInfo.Dispose();
                installsmentInfo.Dispose();
                #endregion
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Ha ocurrido un problema al momento de visualizar los datos");
            }


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
