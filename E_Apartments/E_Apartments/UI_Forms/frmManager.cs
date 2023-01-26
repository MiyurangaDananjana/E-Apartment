using E_Apartments.UC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Apartments.UI_Forms
{
    public partial class frmManager : Form
    {
        public frmManager()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            this.Hide();
            login.ShowDialog();
        }

        private void frmManager_Load(object sender, EventArgs e)
        {
            label1.Text = Genaral.User_Name.ToString();
        }
        public void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            UC_Pnal.Controls.Clear();
            UC_Pnal.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void btnNewUser_Click(object sender, EventArgs e)
        {
            UC_Lease_Approval uc = new UC_Lease_Approval();
            addUserControl(uc);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmAproveReject frm = new frmAproveReject();
            Genaral.ID = 2;
            frm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmAproveReject frm = new frmAproveReject();
            Genaral.ID = 1;
            frm.ShowDialog();
        }
    }
}
