﻿
namespace Financiamientos.Forms
{
    partial class Loan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Loan));
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnReload = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCreateNew = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbFilters = new System.Windows.Forms.ComboBox();
            this.txtValue = new System.Windows.Forms.MaskedTextBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.button4 = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbColumnName = new System.Windows.Forms.ComboBox();
            this.btnDetail = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.dtgvLoans = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvLoans)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnReload);
            this.panel3.Controls.Add(this.button5);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.btnCreateNew);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.btnDetail);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.dtgvLoans);
            this.panel3.Location = new System.Drawing.Point(75, 96);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1263, 730);
            this.panel3.TabIndex = 19;
            // 
            // btnReload
            // 
            this.btnReload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(243)))), ((int)(((byte)(43)))));
            this.btnReload.FlatAppearance.BorderSize = 0;
            this.btnReload.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnReload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReload.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnReload.Image = ((System.Drawing.Image)(resources.GetObject("btnReload.Image")));
            this.btnReload.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReload.Location = new System.Drawing.Point(1201, 112);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(34, 35);
            this.btnReload.TabIndex = 32;
            this.btnReload.UseVisualStyleBackColor = false;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(243)))), ((int)(((byte)(43)))));
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(490, 670);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(194, 36);
            this.button5.TabIndex = 27;
            this.button5.Text = "Exportar";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(14, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 25);
            this.label3.TabIndex = 26;
            this.label3.Text = "Barra de Busqueda";
            // 
            // btnCreateNew
            // 
            this.btnCreateNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(243)))), ((int)(((byte)(43)))));
            this.btnCreateNew.FlatAppearance.BorderSize = 0;
            this.btnCreateNew.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnCreateNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateNew.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCreateNew.Image = ((System.Drawing.Image)(resources.GetObject("btnCreateNew.Image")));
            this.btnCreateNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreateNew.Location = new System.Drawing.Point(257, 670);
            this.btnCreateNew.Name = "btnCreateNew";
            this.btnCreateNew.Size = new System.Drawing.Size(194, 36);
            this.btnCreateNew.TabIndex = 25;
            this.btnCreateNew.Text = "Crear Nuevo";
            this.btnCreateNew.UseVisualStyleBackColor = false;
            this.btnCreateNew.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cmbFilters);
            this.panel1.Controls.Add(this.txtValue);
            this.panel1.Controls.Add(this.dtpFecha);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cmbColumnName);
            this.panel1.Location = new System.Drawing.Point(14, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1222, 53);
            this.panel1.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(330, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 20);
            this.label2.TabIndex = 31;
            this.label2.Text = "Filtro";
            // 
            // cmbFilters
            // 
            this.cmbFilters.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilters.FormattingEnabled = true;
            this.cmbFilters.Items.AddRange(new object[] {
            "Igual",
            "Diferente",
            "Mayor que",
            "Menor que",
            "Mayor o Igual a",
            "Menor o Igual",
            "Como"});
            this.cmbFilters.Location = new System.Drawing.Point(393, 16);
            this.cmbFilters.Name = "cmbFilters";
            this.cmbFilters.Size = new System.Drawing.Size(111, 23);
            this.cmbFilters.TabIndex = 30;
            this.cmbFilters.SelectedIndexChanged += new System.EventHandler(this.cmbFilters_SelectedIndexChanged);
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(510, 16);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(314, 23);
            this.txtValue.TabIndex = 29;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(510, 16);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(288, 23);
            this.dtpFecha.TabIndex = 28;
            this.dtpFecha.Visible = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(243)))), ((int)(((byte)(43)))));
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(1042, 10);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(167, 35);
            this.button4.TabIndex = 27;
            this.button4.Text = "Busqueda Avanzada";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(243)))), ((int)(((byte)(43)))));
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(848, 10);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(178, 35);
            this.btnSearch.TabIndex = 25;
            this.btnSearch.Text = "Buscar";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(15, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 24;
            this.label1.Text = "Campo";
            // 
            // cmbColumnName
            // 
            this.cmbColumnName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbColumnName.FormattingEnabled = true;
            this.cmbColumnName.Items.AddRange(new object[] {
            "Financiamiento",
            "Codigo Cliente",
            "Cliente",
            "Codigo Vendedor",
            "Vendedor",
            "Fecha de Creacion"});
            this.cmbColumnName.Location = new System.Drawing.Point(101, 16);
            this.cmbColumnName.Name = "cmbColumnName";
            this.cmbColumnName.Size = new System.Drawing.Size(211, 23);
            this.cmbColumnName.TabIndex = 23;
            this.cmbColumnName.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnDetail
            // 
            this.btnDetail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(243)))), ((int)(((byte)(43)))));
            this.btnDetail.FlatAppearance.BorderSize = 0;
            this.btnDetail.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnDetail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDetail.Image = ((System.Drawing.Image)(resources.GetObject("btnDetail.Image")));
            this.btnDetail.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDetail.Location = new System.Drawing.Point(14, 670);
            this.btnDetail.Name = "btnDetail";
            this.btnDetail.Size = new System.Drawing.Size(194, 36);
            this.btnDetail.TabIndex = 22;
            this.btnDetail.Text = "Ver Detalle";
            this.btnDetail.UseVisualStyleBackColor = false;
            this.btnDetail.Click += new System.EventHandler(this.btnDetail_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label10.Location = new System.Drawing.Point(14, 125);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(179, 25);
            this.label10.TabIndex = 18;
            this.label10.Text = "Vista de Prestamos";
            // 
            // dtgvLoans
            // 
            this.dtgvLoans.AllowUserToAddRows = false;
            this.dtgvLoans.AllowUserToDeleteRows = false;
            this.dtgvLoans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvLoans.Location = new System.Drawing.Point(14, 153);
            this.dtgvLoans.Name = "dtgvLoans";
            this.dtgvLoans.RowTemplate.Height = 25;
            this.dtgvLoans.Size = new System.Drawing.Size(1222, 487);
            this.dtgvLoans.TabIndex = 17;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(243)))), ((int)(((byte)(43)))));
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Location = new System.Drawing.Point(75, 79);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1263, 11);
            this.panel4.TabIndex = 18;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(75, 44);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(133, 32);
            this.label14.TabIndex = 17;
            this.label14.Text = "Prestamos";
            // 
            // Loan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1384, 895);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label14);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Loan";
            this.Text = "Loan";
            this.Load += new System.EventHandler(this.Loan_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvLoans)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCreateNew;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbColumnName;
        private System.Windows.Forms.Button btnDetail;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dtgvLoans;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.MaskedTextBox txtValue;
        private System.Windows.Forms.ComboBox cmbFilters;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnReload;
    }
}