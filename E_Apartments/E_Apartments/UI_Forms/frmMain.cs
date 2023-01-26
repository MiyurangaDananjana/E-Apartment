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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
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
            UC_New_User uc = new UC_New_User();
            addUserControl(uc);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmLogin frm = new frmLogin();
            this.Hide();
            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UC_System_User uc = new UC_System_User();
            addUserControl(uc);
        }

        private void btnapartment_Click(object sender, EventArgs e)
        {
            Appartment_UC uc = new Appartment_UC();
            addUserControl(uc);
        }

        private void btnlease_Click(object sender, EventArgs e)
        {
            frmLease frm = new frmLease();
            frm.ShowDialog();
        }

        private void btnDashbord_Click(object sender, EventArgs e)
        {
            UC_Admin_Dashbord uc = new UC_Admin_Dashbord();
            addUserControl(uc);
        }
    }
}
