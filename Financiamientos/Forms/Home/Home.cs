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

namespace Financiamientos.Forms
{
    public partial class Home : Form
    {
        public readonly CUser user;
        public Home(CUser user)
        {
            this.user = user;
            
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)=>Application.Exit();

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            btnExitFullScreen.Visible = false;
            btnFullScreen.Visible = true;
        }

        private void btnFullScreen_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            btnExitFullScreen.Visible = true;
            btnFullScreen.Visible = false;
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSettings_Click(object sender, EventArgs e)
        {

        }

        private void btnCloseSesion_Click(object sender, EventArgs e)
        {

        }

        private void ContentPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Home_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            OpenForm(new HomeDashboard(this));
        }
        public void OpenForm (Form frm)
        {
            if (ContentPanel.Controls.Count > 0)
                ContentPanel.Controls.Clear();

            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;

            ContentPanel.Controls.Add(frm);
            ContentPanel.Tag = frm;

            frm.Show();
        }

        private void btnLoan_Click(object sender, EventArgs e)
        {
            OpenForm(new Loan(this));
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenForm(new HomeDashboard(this));
        }
    }
}
