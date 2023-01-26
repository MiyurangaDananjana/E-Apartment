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
    public partial class frmClark : Form
    {
        public frmClark()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmLogin frm = new frmLogin();
            this.Hide();
            frm.ShowDialog();

        }

        private void frmClark_Load(object sender, EventArgs e)
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
            UC_CustomerDetail uc = new UC_CustomerDetail();
            addUserControl(uc);
        }

        private void btnapartment_Click(object sender, EventArgs e)
        {
            UC_ApartmentDetails uc = new UC_ApartmentDetails();
            addUserControl(uc);
        }

        private void btnWatingList_Click(object sender, EventArgs e)
        {
            UC_WatingList uc = new UC_WatingList();
            addUserControl(uc);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RentalPay frm = new RentalPay();
            frm.ShowDialog();
        }
    }
}
