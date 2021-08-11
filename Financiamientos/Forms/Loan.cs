using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Financiamientos.Models.QueryBuilding;
using System.Windows.Forms;

namespace Financiamientos.Forms
{
    public partial class Loan : Form
    {
        private readonly Home home;
        public Loan(Home home)
        {
            this.home = home;
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            home.OpenForm(new CreateLoan(home));
        }

        private async void Loan_Load(object sender, EventArgs e)
        {
            dtgvLoans.DataSource = await IQueryExecutor.TableReturnerExecutor("SELECT * FROM VISTA_PRESTAMO");
        }

    }
}
