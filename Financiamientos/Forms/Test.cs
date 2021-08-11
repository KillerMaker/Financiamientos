using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Financiamientos.Forms;
using Financiamientos.Models.Entities;
using Financiamientos.Models.QueryBuilding;
using Financiamientos.Utility;

namespace Financiamientos
{
    public partial class Test : Form
    {
        public Test()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            
            Stopwatch mytimer= new Stopwatch();
            mytimer.Start();
            dataGridView1.DataSource = await CEntity.SimpleSelect("cuota");
            long ts = mytimer.ElapsedMilliseconds;
            label1.Text = ts.ToString();

            //DateTime date = new DateTime(1989, 2, 21);
            //CCustomer customer = new CCustomer("Juan", "09876543217", date, "8097891234", "C# 4");

            //await customer.Insert();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            Stopwatch mytimer = new Stopwatch();
            mytimer.Start();

            List<CJoin> joins = new List<CJoin>() 
            {
                new CJoin(JoinType.Inner, Tables.Loan, ColumnNames.CustomerCode, Conditions.Equals, Tables.Customer, ColumnNames.CustomerCode),
                new CJoin(JoinType.Inner, Tables.Payment, ColumnNames.LoanCode, Conditions.Equals, Tables.Loan, ColumnNames.LoanCode)
            };
            List<CFilter> filters = new List<CFilter>()
            {
                new CFilter(Tables.Customer,ColumnNames.Name,Conditions.Different,"Manuel Gomez",Operators.And),
                new CFilter(Tables.Loan,ColumnNames.InstallsmentNumber,Conditions.Greater,"11")
            };
            List<ColumnNames> headers = new List<ColumnNames>() 
            { 
                ColumnNames.CustomerCode,
                ColumnNames.PaymentCode,
                ColumnNames.LoanCode 
            };

           dataGridView1.DataSource=await new CSelctQuery(headers, Tables.Customer, filters, joins).Launch();

           
            mytimer.Stop();

            long ts = mytimer.ElapsedMilliseconds;
            label1.Text = ts.ToString();
        }

        private void Test_Load(object sender, EventArgs e)
        {
            Home h = new Home(new CUser("Marcos Kelvin","12345678901","MKelvin","1234","ADMINISTRADOR","Activo","U-001"));
            Hide();
            h.Show();
        }
    }
}
