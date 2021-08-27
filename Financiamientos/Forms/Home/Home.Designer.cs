
namespace Financiamientos.Forms
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.TittlePanel = new System.Windows.Forms.Panel();
            this.btnExitFullScreen = new System.Windows.Forms.PictureBox();
            this.btnFullScreen = new System.Windows.Forms.PictureBox();
            this.btnMinimize = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnCloseSesion = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnUser = new System.Windows.Forms.Button();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.btnLoan = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ContentPanel = new System.Windows.Forms.Panel();
            this.TittlePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExitFullScreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFullScreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.MenuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TittlePanel
            // 
            this.TittlePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(243)))), ((int)(((byte)(43)))));
            this.TittlePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TittlePanel.Controls.Add(this.btnExitFullScreen);
            this.TittlePanel.Controls.Add(this.btnFullScreen);
            this.TittlePanel.Controls.Add(this.btnMinimize);
            this.TittlePanel.Controls.Add(this.btnClose);
            this.TittlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TittlePanel.Location = new System.Drawing.Point(0, 0);
            this.TittlePanel.Name = "TittlePanel";
            this.TittlePanel.Size = new System.Drawing.Size(1366, 35);
            this.TittlePanel.TabIndex = 0;
            // 
            // btnExitFullScreen
            // 
            this.btnExitFullScreen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExitFullScreen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExitFullScreen.Image = ((System.Drawing.Image)(resources.GetObject("btnExitFullScreen.Image")));
            this.btnExitFullScreen.Location = new System.Drawing.Point(1296, 4);
            this.btnExitFullScreen.Name = "btnExitFullScreen";
            this.btnExitFullScreen.Size = new System.Drawing.Size(25, 25);
            this.btnExitFullScreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnExitFullScreen.TabIndex = 4;
            this.btnExitFullScreen.TabStop = false;
            this.btnExitFullScreen.Visible = false;
            this.btnExitFullScreen.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // btnFullScreen
            // 
            this.btnFullScreen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFullScreen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFullScreen.Image = ((System.Drawing.Image)(resources.GetObject("btnFullScreen.Image")));
            this.btnFullScreen.Location = new System.Drawing.Point(1296, 4);
            this.btnFullScreen.Name = "btnFullScreen";
            this.btnFullScreen.Size = new System.Drawing.Size(25, 25);
            this.btnFullScreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnFullScreen.TabIndex = 3;
            this.btnFullScreen.TabStop = false;
            this.btnFullScreen.Click += new System.EventHandler(this.btnFullScreen_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.Location = new System.Drawing.Point(1265, 4);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(25, 25);
            this.btnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimize.TabIndex = 2;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(1327, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(25, 25);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 0;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // MenuPanel
            // 
            this.MenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(243)))), ((int)(((byte)(43)))));
            this.MenuPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MenuPanel.Controls.Add(this.panel7);
            this.MenuPanel.Controls.Add(this.panel5);
            this.MenuPanel.Controls.Add(this.panel4);
            this.MenuPanel.Controls.Add(this.btnSettings);
            this.MenuPanel.Controls.Add(this.btnCloseSesion);
            this.MenuPanel.Controls.Add(this.panel3);
            this.MenuPanel.Controls.Add(this.panel2);
            this.MenuPanel.Controls.Add(this.panel1);
            this.MenuPanel.Controls.Add(this.btnUser);
            this.MenuPanel.Controls.Add(this.btnCustomer);
            this.MenuPanel.Controls.Add(this.btnLoan);
            this.MenuPanel.Controls.Add(this.pictureBox1);
            this.MenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuPanel.Location = new System.Drawing.Point(0, 35);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(200, 733);
            this.MenuPanel.TabIndex = 1;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Location = new System.Drawing.Point(0, 319);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(201, 10);
            this.panel7.TabIndex = 9;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Location = new System.Drawing.Point(3, 337);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(10, 36);
            this.panel5.TabIndex = 8;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(3, 379);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 36);
            this.panel4.TabIndex = 5;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(243)))), ((int)(((byte)(43)))));
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSettings.Image = ((System.Drawing.Image)(resources.GetObject("btnSettings.Image")));
            this.btnSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.Location = new System.Drawing.Point(12, 337);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(188, 36);
            this.btnSettings.TabIndex = 7;
            this.btnSettings.Text = "Ajustes";
            this.btnSettings.UseVisualStyleBackColor = false;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnCloseSesion
            // 
            this.btnCloseSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(243)))), ((int)(((byte)(43)))));
            this.btnCloseSesion.FlatAppearance.BorderSize = 0;
            this.btnCloseSesion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnCloseSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseSesion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCloseSesion.Image = ((System.Drawing.Image)(resources.GetObject("btnCloseSesion.Image")));
            this.btnCloseSesion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCloseSesion.Location = new System.Drawing.Point(12, 379);
            this.btnCloseSesion.Name = "btnCloseSesion";
            this.btnCloseSesion.Size = new System.Drawing.Size(188, 36);
            this.btnCloseSesion.TabIndex = 6;
            this.btnCloseSesion.Text = "Cerrar Sesion";
            this.btnCloseSesion.UseVisualStyleBackColor = false;
            this.btnCloseSesion.Click += new System.EventHandler(this.btnCloseSesion_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(3, 277);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 36);
            this.panel3.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(3, 235);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 36);
            this.panel2.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(3, 193);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 36);
            this.panel1.TabIndex = 4;
            // 
            // btnUser
            // 
            this.btnUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(243)))), ((int)(((byte)(43)))));
            this.btnUser.FlatAppearance.BorderSize = 0;
            this.btnUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUser.Image = ((System.Drawing.Image)(resources.GetObject("btnUser.Image")));
            this.btnUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUser.Location = new System.Drawing.Point(12, 277);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(188, 36);
            this.btnUser.TabIndex = 3;
            this.btnUser.Text = "Usuarios";
            this.btnUser.UseVisualStyleBackColor = false;
            // 
            // btnCustomer
            // 
            this.btnCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(243)))), ((int)(((byte)(43)))));
            this.btnCustomer.FlatAppearance.BorderSize = 0;
            this.btnCustomer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCustomer.Image = ((System.Drawing.Image)(resources.GetObject("btnCustomer.Image")));
            this.btnCustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCustomer.Location = new System.Drawing.Point(12, 235);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(188, 36);
            this.btnCustomer.TabIndex = 2;
            this.btnCustomer.Text = "Clientes";
            this.btnCustomer.UseVisualStyleBackColor = false;
            // 
            // btnLoan
            // 
            this.btnLoan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(243)))), ((int)(((byte)(43)))));
            this.btnLoan.FlatAppearance.BorderSize = 0;
            this.btnLoan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnLoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLoan.Image = ((System.Drawing.Image)(resources.GetObject("btnLoan.Image")));
            this.btnLoan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoan.Location = new System.Drawing.Point(12, 193);
            this.btnLoan.Name = "btnLoan";
            this.btnLoan.Size = new System.Drawing.Size(188, 36);
            this.btnLoan.TabIndex = 1;
            this.btnLoan.Text = "Financiamientos";
            this.btnLoan.UseVisualStyleBackColor = false;
            this.btnLoan.Click += new System.EventHandler(this.btnLoan_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Financiamientos.Properties.Resources.A_E_Network_logo_svg;
            this.pictureBox1.Location = new System.Drawing.Point(3, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(191, 95);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // ContentPanel
            // 
            this.ContentPanel.BackColor = System.Drawing.SystemColors.Control;
            this.ContentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContentPanel.Location = new System.Drawing.Point(200, 35);
            this.ContentPanel.Name = "ContentPanel";
            this.ContentPanel.Size = new System.Drawing.Size(1166, 733);
            this.ContentPanel.TabIndex = 2;
            this.ContentPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.ContentPanel_Paint);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.ContentPanel);
            this.Controls.Add(this.MenuPanel);
            this.Controls.Add(this.TittlePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.TittlePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnExitFullScreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFullScreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.MenuPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TittlePanel;
        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.PictureBox btnMinimize;
        private System.Windows.Forms.PictureBox btnExitFullScreen;
        private System.Windows.Forms.PictureBox btnFullScreen;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnLoan;
        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.Button btnCustomer;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnCloseSesion;
        public System.Windows.Forms.Panel ContentPanel;
    }
}