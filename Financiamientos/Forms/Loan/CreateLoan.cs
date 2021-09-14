using Financiamientos.Models.Entities;
using Financiamientos.Models.QueryBuilding;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Financiamientos.Forms
{
    public partial class CreateLoan : Form
    {
        private readonly Home home;
        private string columnName;
        public CreateLoan(Home home)
        {
            this.home = home;
            InitializeComponent();
        }

        private async void CreateLoan_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = await IQueryExecutor.ExecuteQuery("SELECT * FROM VISTA_CLIENTE");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked.Equals(true))
                txtCustomer.Enabled = true;
            else
                txtCustomer.Enabled = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(cmbColumnName.SelectedIndex)
            {
                case 0:
                    columnName = "CODIGO";
                    break;
                case 1:
                    columnName = "NOMBRE";
                    break;
                case 2:
                    columnName = "CEDULA";
                    break;
            }

        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtValue.Text == null)
                    MessageBox.Show("El Criterio no puede estar vacio al momento de buscar", "Error en la busqueda");

                dataGridView1.DataSource= await IQueryExecutor.ExecuteQuery<CCustomer>($"{columnName} = '{txtValue.Text}'");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error en la busqueda");
            }

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
             txtCustomer.Text =(dataGridView1.SelectedRows.Count>0)? dataGridView1.SelectedRows[0].Cells[0].Value.ToString():"";
        }

        private async void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                CLoan loan = new CLoan
                (
                    txtCustomer.Text,
                    home.user.code,
                    DateTime.Now,
                    decimal.Parse(mtxtCapital.Text),
                    int.Parse(nudInstallsmetNumber.Value.ToString()),
                    "Activo",
                    decimal.Parse(nudInterestRate.Value.ToString())
                );

                await loan.Insert();

                MessageBox.Show("Financiamiento Insertado Correctamente","Hecho");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
