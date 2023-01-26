using E_Apartments.UI_Forms;
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

namespace E_Apartments
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        public void btnLogin_Click(object sender, EventArgs e)
        {

            using (DBContextDataContext db = new DBContextDataContext())
            {
                var userChack = db.SYSTEM_USERS_DETAILs.Where(x => x.SYSTEM_USER_NAME == txtUserName.Text && x.PASS == Genaral.hashPassword(txtPass.Text)).FirstOrDefault(); // hash encoding to hash1 genaral class file method
                if (txtUserName.Text != "" && txtPass.Text != "")
                {
                    if (userChack != null)
                    {
                        Genaral.Login_Emp_ID = userChack.ID;
                        Genaral.User_Name = userChack.FULL_NAME;
                        Genaral.System_User_Name = userChack.SYSTEM_USER_NAME;


                        if (userChack.ROLE_ID == 1) //  Admin Login
                        {
                            frmMain frm = new frmMain();
                            this.Hide();
                            frm.ShowDialog();
                        }
                        else if (userChack.ROLE_ID == 2) // Manager Login
                        {
                            frmManager frm = new frmManager();
                            this.Hide();
                            frm.ShowDialog();
                        }
                        else if (userChack.ROLE_ID == 3) // Clack Login
                        {
                            frmClark frm = new frmClark();
                            this.Hide();
                            frm.ShowDialog();
                        }
                        else if (userChack.ROLE_ID == 4) // Customer
                        {
                            int Customer_ID = userChack.ID;
                            var CheckCustomerStates = db.APARTMENT_LEASEs.Where(x =>x.CUSTOMER_ID == Customer_ID && x.STATES == Convert.ToInt32(1)).FirstOrDefault();
                            if (CheckCustomerStates != null)
                            {
                                frmUserUI frm = new frmUserUI();
                                this.Hide();
                                frm.ShowDialog();
                            }
                            else
                            {
                                MessageBox.Show("NOthing to have access");
                            }
                         
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
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
