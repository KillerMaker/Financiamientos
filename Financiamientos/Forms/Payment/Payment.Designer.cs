
namespace Financiamientos.Forms.Payment
{
    partial class Payment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Payment));
            this.lblPayedArrears = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.lblPayedInterest = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lblPayedCapital = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cmbPaymentMethod = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancelPayment = new System.Windows.Forms.Button();
            this.btnPay = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.mtxtAmmount = new System.Windows.Forms.MaskedTextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPayedArrears
            // 
            this.lblPayedArrears.AutoSize = true;
            this.lblPayedArrears.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPayedArrears.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblPayedArrears.Location = new System.Drawing.Point(546, 55);
            this.lblPayedArrears.Name = "lblPayedArrears";
            this.lblPayedArrears.Size = new System.Drawing.Size(56, 25);
            this.lblPayedArrears.TabIndex = 42;
            this.lblPayedArrears.Text = "0.00$";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label19.ForeColor = System.Drawing.Color.Black;
            this.label19.Location = new System.Drawing.Point(546, 11);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(150, 30);
            this.label19.TabIndex = 41;
            this.label19.Text = "Mora a Pagar:";
            // 
            // lblPayedInterest
            // 
            this.lblPayedInterest.AutoSize = true;
            this.lblPayedInterest.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPayedInterest.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblPayedInterest.Location = new System.Drawing.Point(266, 55);
            this.lblPayedInterest.Name = "lblPayedInterest";
            this.lblPayedInterest.Size = new System.Drawing.Size(56, 25);
            this.lblPayedInterest.TabIndex = 40;
            this.lblPayedInterest.Text = "0.00$";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(266, 11);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(165, 30);
            this.label17.TabIndex = 39;
            this.label17.Text = "Interes a Pagar:";
            // 
            // lblPayedCapital
            // 
            this.lblPayedCapital.AutoSize = true;
            this.lblPayedCapital.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPayedCapital.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblPayedCapital.Location = new System.Drawing.Point(14, 55);
            this.lblPayedCapital.Name = "lblPayedCapital";
            this.lblPayedCapital.Size = new System.Drawing.Size(56, 25);
            this.lblPayedCapital.TabIndex = 38;
            this.lblPayedCapital.Text = "0.00$";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(14, 11);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(166, 30);
            this.label13.TabIndex = 37;
            this.label13.Text = "Capital a Pagar:";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(243)))), ((int)(((byte)(43)))));
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Location = new System.Drawing.Point(12, 55);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(774, 10);
            this.panel5.TabIndex = 44;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(12, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(188, 32);
            this.label4.TabIndex = 43;
            this.label4.Text = "Pago a Realizar";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.lblPayedCapital);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.lblPayedArrears);
            this.panel1.Controls.Add(this.lblPayedInterest);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Location = new System.Drawing.Point(12, 72);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(774, 100);
            this.panel1.TabIndex = 45;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.cmbPaymentMethod);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.btnCancelPayment);
            this.panel4.Controls.Add(this.btnPay);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.mtxtAmmount);
            this.panel4.Location = new System.Drawing.Point(12, 265);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(774, 245);
            this.panel4.TabIndex = 51;
            // 
            // cmbPaymentMethod
            // 
            this.cmbPaymentMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPaymentMethod.FormattingEnabled = true;
            this.cmbPaymentMethod.Items.AddRange(new object[] {
            "Efectivo",
            "Tarjeta de Debito",
            "Tarjeta de Credito",
            "Cheque"});
            this.cmbPaymentMethod.Location = new System.Drawing.Point(232, 90);
            this.cmbPaymentMethod.Name = "cmbPaymentMethod";
            this.cmbPaymentMethod.Size = new System.Drawing.Size(163, 23);
            this.cmbPaymentMethod.TabIndex = 47;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(14, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 30);
            this.label1.TabIndex = 46;
            this.label1.Text = "Metodo de Pago:";
            // 
            // btnCancelPayment
            // 
            this.btnCancelPayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(243)))), ((int)(((byte)(43)))));
            this.btnCancelPayment.FlatAppearance.BorderSize = 0;
            this.btnCancelPayment.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnCancelPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelPayment.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCancelPayment.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelPayment.Image")));
            this.btnCancelPayment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelPayment.Location = new System.Drawing.Point(394, 175);
            this.btnCancelPayment.Name = "btnCancelPayment";
            this.btnCancelPayment.Size = new System.Drawing.Size(163, 35);
            this.btnCancelPayment.TabIndex = 45;
            this.btnCancelPayment.Text = "Cancelar";
            this.btnCancelPayment.UseVisualStyleBackColor = false;
            // 
            // btnPay
            // 
            this.btnPay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(243)))), ((int)(((byte)(43)))));
            this.btnPay.FlatAppearance.BorderSize = 0;
            this.btnPay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPay.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPay.Image = ((System.Drawing.Image)(resources.GetObject("btnPay.Image")));
            this.btnPay.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPay.Location = new System.Drawing.Point(199, 175);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(163, 35);
            this.btnPay.TabIndex = 44;
            this.btnPay.Text = "Pagar";
            this.btnPay.UseVisualStyleBackColor = false;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(14, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(166, 30);
            this.label9.TabIndex = 43;
            this.label9.Text = "Capital a Pagar:";
            // 
            // mtxtAmmount
            // 
            this.mtxtAmmount.Location = new System.Drawing.Point(232, 28);
            this.mtxtAmmount.Name = "mtxtAmmount";
            this.mtxtAmmount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mtxtAmmount.Size = new System.Drawing.Size(163, 23);
            this.mtxtAmmount.TabIndex = 0;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label16.Location = new System.Drawing.Point(12, 214);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(188, 32);
            this.label16.TabIndex = 49;
            this.label16.Text = "Pago a Realizar";
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(243)))), ((int)(((byte)(43)))));
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Location = new System.Drawing.Point(12, 249);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(774, 10);
            this.panel6.TabIndex = 48;
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 535);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.label4);
            this.Name = "Payment";
            this.Text = "Payment";
            this.Load += new System.EventHandler(this.Payment_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPayedArrears;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label lblPayedInterest;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lblPayedCapital;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox mtxtAmmount;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnCancelPayment;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.ComboBox cmbPaymentMethod;
        private System.Windows.Forms.Label label1;
    }
}