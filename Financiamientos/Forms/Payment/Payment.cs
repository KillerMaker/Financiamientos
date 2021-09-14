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
        public readonly string loanCode;
        public readonly float totalDebtRemaning;
        public Payment(string loanCode,float totalDebtRemaning)
        {
            this.loanCode = loanCode;
            this.totalDebtRemaning = totalDebtRemaning;
            InitializeComponent();
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Payment_Load(object sender, EventArgs e)
        {
            
        }
    }
}
