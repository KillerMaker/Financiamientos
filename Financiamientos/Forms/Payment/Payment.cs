using Financiamientos.Models.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Financiamientos.Forms.Payment
{
    public partial class Payment : Form
    {
        private readonly LoanDetail loanDetail;
        public readonly string loanCode;
        public readonly float capital;
        public readonly float interest;
        public readonly float arrears;

        public Payment(LoanDetail loanDetail,string loanCode,float capital,float interest,float arrears)
        {
            this.loanDetail = loanDetail;
            this.loanCode = loanCode;
            this.capital = capital;
            this.interest = interest;
            this.arrears = arrears;
            
            InitializeComponent();
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private async void btnPay_Click(object sender, EventArgs e)
        {
            try
            {
                await new CPayment(Convert.ToDecimal(mtxtAmmount.Text), DateTime.Now, loanCode, cmbPaymentMethod.Text).Insert();
                await loanDetail.ReloadFrom();
                Close();
                MessageBox.Show($"Se han pagado {mtxtAmmount.Text} al prestamo de codigo {loanCode}", "Pago realizado correctamente");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Ha ocurrido un error");
            }
        }

        private void Payment_Load(object sender, EventArgs e)
        {
            lblPayedCapital.Text = capital.ToString("c");
            lblPayedInterest.Text = interest.ToString("c");
            lblPayedArrears.Text = arrears.ToString("c");
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
