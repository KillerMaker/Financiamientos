﻿using System;
using System.Drawing;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Financiamientos.Models.QueryBuilding;
using System.Windows.Forms;
using Financiamientos.Models.Entities;

namespace Financiamientos.Forms
{
    public partial class Loan : Form
    {
        private string columnName;
        private Size ValueSize;
        private readonly Home home;
        public Loan(Home home)
        {
            this.home = home;
            InitializeComponent();
            ValueSize = txtValue.Size;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            home.OpenForm(new CreateLoan(home));
        }

        private async void Loan_Load(object sender, EventArgs e)
        {
            dtgvLoans.DataSource = await CEntity.SimpleSelect("VISTA_PRESTAMO");
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            try 
            {
                if (dtpFecha.Visible.Equals(true))
                    dtgvLoans.DataSource = await CEntity.SimpleSelect("VISTA_PRESTAMO", columnName + "=", dtpFecha.Value.ToString());
                else
                    dtgvLoans.DataSource = await CEntity.SimpleSelect("VISTA_PRESTAMO", columnName + "=", txtValue.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Algo ha salido Mal");
            }
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(cmbColumnName.SelectedIndex)
            {
                case 0:
                    columnName = "[FINANCIAMIENTO]";
                    txtValue.Visible = true;
                    dtpFecha.Visible = false;
                    txtValue.Text = "";
                    txtValue.Mask = "L-00000";
                    txtValue.Size=new Size(ValueSize.Width / 4, ValueSize.Height);
                    txtValue.TextAlign = HorizontalAlignment.Right;
                    txtValue.Focus();
                    return;
                case 1:
                    columnName = "[CODIGO CLIENTE]";
                    txtValue.Visible = true;
                    dtpFecha.Visible = false;
                    txtValue.Text = "";
                    txtValue.Mask = "C-00000";
                    txtValue.Size = new Size(ValueSize.Width / 4, ValueSize.Height);
                    txtValue.TextAlign = HorizontalAlignment.Right;
                    txtValue.Focus();
                    return;
                case 2:
                    columnName = "[CLIENTE]";
                    txtValue.Visible = true;
                    dtpFecha.Visible = false;
                    txtValue.Text = "";
                    txtValue.Mask = null;
                    txtValue.Size = ValueSize;
                    txtValue.TextAlign = HorizontalAlignment.Left;
                    txtValue.Focus();
                    return;
                case 3:
                    columnName = "[CODIGO VENDEDOR]";
                    txtValue.Visible = true;
                    dtpFecha.Visible = false;
                    txtValue.Text = "";
                    txtValue.Mask = "U-000";
                    txtValue.Size = new Size(ValueSize.Width / 4, ValueSize.Height);
                    txtValue.TextAlign = HorizontalAlignment.Right;
                    txtValue.Focus();
                    return;
                case 4:
                    columnName = "[VENDEDOR]";
                    txtValue.Visible = true;
                    dtpFecha.Visible = false;
                    txtValue.Text = "";
                    txtValue.Mask = null;
                    txtValue.Size = ValueSize;
                    txtValue.TextAlign = HorizontalAlignment.Left;
                    txtValue.Focus();
                    return;
                case 5:
                    columnName = "CONVERT(DATE,[FECHA DE CREACION])";
                    txtValue.Visible = false;
                    dtpFecha.Visible = true;
                    txtValue.Text = "";
                    txtValue.Mask = null;
                    txtValue.Size = ValueSize;
                    txtValue.TextAlign = HorizontalAlignment.Left;
                    dtpFecha.Focus();
                    return;
            }
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            if (dtgvLoans.SelectedRows.Count.Equals(1))
            {
                try
                {
                    DataGridViewRow row = dtgvLoans.SelectedRows[0];

                    CLoan loan = new CLoan
                        (
                            row.Cells[6].Value.ToString(),//Codigo Cliente
                            row.Cells[8].Value.ToString(),//Codigo Usuario
                            Convert.ToDateTime(row.Cells[2].Value),//Fecha
                            Convert.ToDecimal(row.Cells[1].Value),//Monto Capital
                            Convert.ToInt32(row.Cells[3].Value),//Numero de Cuotas
                            row.Cells[5].Value.ToString(),//Estado
                            Convert.ToDecimal(row.Cells[4].Value),//Tasa de Interes
                            row.Cells[0].Value.ToString()//Codigo de financiamiento
                        );

                    home.OpenForm(new LoanDetail(loan));
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error al seleccionar financiamiento");
                }
                
            }
            else if (dtgvLoans.SelectedRows.Count > 1)
                MessageBox.Show("Seleccione solo un financiamiento por favor", 
                    "Error al momento de seleccionar financiamiento");
            else
                MessageBox.Show("Debe seleccionar un financiamiento por favor", 
                    "Error al momento de seleccionar financiamiento");

        }
    }
}
