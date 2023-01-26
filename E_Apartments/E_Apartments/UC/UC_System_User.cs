using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E_Apartments.BLL;
using E_Apartments.DAL;
using E_Apartments.DAL.DTO;
using System.Windows.Forms;

namespace E_Apartments.UC
{
    public partial class UC_System_User : UserControl
    {
        public UC_System_User()
        {
            InitializeComponent();
        }

        System_User_BLL bll = new System_User_BLL();
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtfullname.Text.Trim() == "")
            {
                MessageBox.Show("Full Name is empty");
            }
            else if (txtsurename.Text.Trim() == "")
            {
                MessageBox.Show("Sure Name is empty");
            }
            else if (txtnic.Text.Trim() == "")
            {
                MessageBox.Show("NIC is empty");
            }
            else if (txttelephone.Text.Trim() == "")
            {
                MessageBox.Show("Phone Number is empty");
            }
            else if (txtaddress.Text.Trim() == "")
            {
                MessageBox.Show("Address is empty");
            }
            else if (txtename.Text.Trim() == "")
            {
                MessageBox.Show("Emargancy call name is empty");
            }
            else if (txtephne.Text.Trim() == "")
            {
                MessageBox.Show("Emargancy call Phone umber is empty");
            }
            else if (txtusername.Text.Trim() == "")
            {
                MessageBox.Show("System user Name is empty");
            }
            else if (txtpassword.Text.Trim() == "")
            {
                MessageBox.Show("Password is empty");
            }
            else if (txtre_password.Text.Trim() == "")
            {
                MessageBox.Show("Password is empty");
            }
            else
            {

                try
                {
                    using (DBContextDataContext db = new DBContextDataContext())
                    {
                        var userChack = db.SYSTEM_USERS_DETAILs.Where(x => x.SYSTEM_USER_NAME == txtusername.Text).First();

                        if (userChack.SYSTEM_USER_NAME == txtusername.Text)
                        {
                            MessageBox.Show("already user name have !");
                        }
                        else
                        {

                            //Add User detail to table//
                            SYSTEM_USERS_DETAIL userDto = new SYSTEM_USERS_DETAIL();
                            userDto.FULL_NAME = txtfullname.Text;
                            userDto.SURNAME = txtsurename.Text;
                            userDto.NIC = txtnic.Text;
                            userDto.PHONENUMBER = Convert.ToInt32(txtphone.Text);
                            userDto.TELEPHONE = Convert.ToInt32(txttelephone.Text);
                            userDto.ADDRESS = txtaddress.Text;
                            userDto.DOB = dpdob.Value;
                            userDto.ENAME = txtename.Text;
                            userDto.EPHONENUMBER = Convert.ToInt32(txtephne.Text);
                            userDto.ROLE_ID = Convert.ToInt32(cmbrole.SelectedValue);

                            userDto.SYSTEM_USER_NAME = txtusername.Text;
                            userDto.PASS = Genaral.hashPassword(txtpassword.Text);
                            userDto.CREATE_EMP_ID = Genaral.Login_Emp_ID;
                            userDto.CREATE_DTIME = Convert.ToDateTime(DateTime.Now);
                            System_User_BLL.Add_User(userDto); // return text box data from bll class
                            MessageBox.Show("User wass added");

                        }
                    }


                }
                catch (Exception ex)
                {

                    MessageBox.Show("Error" + ex);
                }


            }
        }
        List<ROLL> Roll_List = new List<ROLL>();
        List<APARTMENT_NAME> Apartment_List = new List<APARTMENT_NAME>();
        System_User_DTO systeme_user_DTO = new System_User_DTO();
        Customer_DTO customer_details = new Customer_DTO();
        private void UC_System_User_Load(object sender, EventArgs e)
        {
            Roll_List = System_User_BLL.Get_Roll();
            cmbrole.DataSource = Roll_List;
            cmbrole.DisplayMember = "ROLL1";
            cmbrole.ValueMember = "ID";
            cmbrole.SelectedValue = -1;



            int RollAdmin = 1;
            int RollManager = 2;
            int RollClack = 3;
            customer_details = Customer_BLL.Get_CUstomer_Details(RollManager, RollClack, RollAdmin);

            dataGridView1.DataSource = customer_details.Customers;
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].HeaderText = "FULL NAME";
            dataGridView1.Columns[2].HeaderText = "SURE NAME";
            dataGridView1.Columns[3].HeaderText = "NIC";
            dataGridView1.Columns[4].HeaderText = "PHONE NUM";

            dataGridView1.Columns[5].HeaderText = "TELE NUMBER";
            dataGridView1.Columns[6].HeaderText = "ADDRESS";
            dataGridView1.Columns[7].HeaderText = "BOB";
            dataGridView1.Columns[8].HeaderText = "EMARGANCY CALL NAME";
            dataGridView1.Columns[9].HeaderText = "E PHONE NUM";
            dataGridView1.Columns[10].HeaderText = "CREATE BY";
            dataGridView1.Columns[11].HeaderText = "CREATE DATE";

            dataGridView1.Columns[12].HeaderText = "USER NAME";
            dataGridView1.Columns[13].HeaderText = "ROLL";

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void txtphone_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Genaral.isNumber(e);
        }

        private void txttelephone_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Genaral.isNumber(e);
        }

        private void txtephne_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Genaral.isNumber(e);
        }

        private void cmbworkingapartment_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void cmbworkingapartment_KeyPress(object sender, KeyPressEventArgs e)
        {


        }

        private void cmbworkingapartment_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void cmbworkingapartment_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            try
            {
                using (DBContextDataContext db = new DBContextDataContext())
                {
                    var userChack = db.SYSTEM_USERS_DETAILs.Where(x => x.SYSTEM_USER_NAME == txtusername.Text).First();

                    if (userChack.SYSTEM_USER_NAME == txtusername.Text)
                    {
                        MessageBox.Show("already user name have !");
                    }
                    else
                    {
                        if (txtpassword.Text == txtre_password.Text)
                        {
                            //Add User detail to table//
                            SYSTEM_USERS_DETAIL userDto = new SYSTEM_USERS_DETAIL();
                            userDto.ID = Genaral.ID;
                            userDto.FULL_NAME = txtfullname.Text;
                            userDto.SURNAME = txtsurename.Text;
                            userDto.NIC = txtnic.Text;
                            userDto.PHONENUMBER = Convert.ToInt32(txtphone.Text);
                            userDto.TELEPHONE = Convert.ToInt32(txttelephone.Text);
                            userDto.ADDRESS = txtaddress.Text;
                            userDto.DOB = dpdob.Value;
                            userDto.ENAME = txtename.Text;
                            userDto.EPHONENUMBER = Convert.ToInt32(txtephne.Text);
                            userDto.ROLE_ID = Convert.ToInt32(cmbrole.SelectedValue);

                            userDto.SYSTEM_USER_NAME = txtusername.Text;
                            userDto.PASS = Genaral.hashPassword(txtpassword.Text);
                            System_User_BLL.UpdateUser(userDto); // return text box data from bll class
                            MessageBox.Show("User was Update !");
                        }
                        else
                        {
                            MessageBox.Show("Password dosn not match!");
                        }

                    }


                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error" + ex);
            }
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                Genaral.ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());

                txtfullname.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtsurename.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtnic.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtphone.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                txttelephone.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtaddress.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                dpdob.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
                txtename.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
                txtephne.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
                txtusername.Text = dataGridView1.Rows[e.RowIndex].Cells[12].Value.ToString();
                cmbrole.Text = dataGridView1.Rows[e.RowIndex].Cells[13].Value.ToString();




            }
        }

        private void btnremove_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure to delete", "Warning", MessageBoxButtons.YesNo);
            if (DialogResult.Yes == result)
            {
                System_User_BLL.DeleteUser(Convert.ToInt32(Genaral.ID));
                MessageBox.Show("Delete !");

            }
        }
    }
}
