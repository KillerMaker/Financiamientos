using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Financiamientos.Models.QueryBuilding;

namespace Financiamientos.Forms
{
    public partial class HomeDashboard : Form
    {
        private readonly Home home;
        private int PayedLoans;
        private int ActiveLoans;
        private int canceledLoans;
        private int overdureLoans;

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
                installsmetsDueToToday =await IQueryExecutor.TableReturnerExecutor("SELECT * FROM VISTA_CUOTAS_VENCEN_HOY");
                last10Paymets= await IQueryExecutor.TableReturnerExecutor("SELECT * FROM ULTIMOS_10_PAGOS");
                arrears = await IQueryExecutor.TableReturnerExecutor("SELECT * FROM VISTA_CUOTAS_ATRASADAS");
                DataTable loanInfo= await IQueryExecutor.TableReturnerExecutor("SELECT * FROM VISTA_PRESTAMO_INFO");

                PayedLoans = int.Parse(loanInfo.Rows[0].ItemArray[0].ToString());
                ActiveLoans = int.Parse(loanInfo.Rows[0].ItemArray[1].ToString());
                canceledLoans = int.Parse(loanInfo.Rows[0].ItemArray[2].ToString());
                overdureLoans = int.Parse(loanInfo.Rows[0].ItemArray[3].ToString());

                lblPayedLoans.Text = PayedLoans.ToString();
                lblActiveLoans.Text = ActiveLoans.ToString();
                lblCanceledLoans.Text = canceledLoans.ToString();
                lblOverdureLoans.Text = overdureLoans.ToString();

                dtgvInstallsmetDueToday.DataSource = installsmetsDueToToday;
                dtgvLast10Paymets.DataSource = last10Paymets;
                dtgvArrears.DataSource = arrears;

            }
            catch(Exception error)
            {
                throw new Exception(error.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
