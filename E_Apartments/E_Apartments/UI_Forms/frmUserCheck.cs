using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using E_Apartments.BLL;
using E_Apartments.DAL;
using E_Apartments.DAL.DTO;

namespace E_Apartments.UI_Forms
{
    public partial class frmUserCheck : Form
    {
        public frmUserCheck()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            using (DBContextDataContext db = new DBContextDataContext())
            {
                var userChack = db.SYSTEM_USERS_DETAILs.Where(x => x.SYSTEM_USER_NAME == txtUserName.Text && x.PASS == Genaral.hashPassword(txtPass.Text)).FirstOrDefault(); // hash encoding to hash1 genaral class file method
                if (txtUserName.Text != "" && txtPass.Text != "")
                {
                    if (userChack != null)
                    {
                        if (Genaral.LockCheck == 2) // Manager Login
                        {
                            frmNewAppartment frm = new frmNewAppartment();
                            this.Hide();
                            frm.ShowDialog();
                        }
                        else if (Genaral.LockCheck == 1) // Admin Login
                        {
                            frmNewClass frm = new frmNewClass();
                            this.Hide();
                            frm.ShowDialog();
                        }
                  
                        else
                        {
                            MessageBox.Show("Error");
                        }
                    }
                    else
                    {
                        MessageBox.Show("user not found");
                    }
                }
                else
                {
                    MessageBox.Show("User Name Or Password is Epty");
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
