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
using E_Apartments.UI_Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using E_Apartments.Report;

namespace E_Apartments.UC
{
    public partial class UC_New_User : UserControl
    {
        Customer_BLL bll = new Customer_BLL();
        public UC_New_User()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        
        private void btnadd_Click(object sender, EventArgs e)
        {
            int RollUserType = 4;
            if (txtfullname.Text.Trim() == "")
            {
                MessageBox.Show("Full Name is empty");
            }
            else if (txtserneme.Text.Trim() == "")
            {
                MessageBox.Show("Sure Name is empty");
            }
            else if (txtnic.Text.Trim() == "")
            {
                MessageBox.Show("NIC is empty");
            }
            else if (txtphonenrmber.Text.Trim() == "")
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
            else if (txtephone.Text.Trim() == "")
            {
                MessageBox.Show("Emargancy call Phone umber is empty");
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
                            userDto.SURNAME = txtserneme.Text;
                            userDto.NIC = txtnic.Text;
                            userDto.PHONENUMBER = Convert.ToInt32(txtphonenrmber.Text);
                            userDto.TELEPHONE = Convert.ToInt32(txttelephone.Text);
                            userDto.ADDRESS = txtaddress.Text;
                            userDto.DOB = dpdob.Value;
                            userDto.ENAME = txtename.Text;
                            userDto.EPHONENUMBER = Convert.ToInt32(txtephone.Text);
                            userDto.ROLE_ID = RollUserType;
                            userDto.SYSTEM_USER_NAME = txtusername.Text;
                            userDto.PASS = Genaral.hashPassword(txtpassword.Text);
                            userDto.CREATE_EMP_ID = Genaral.Login_Emp_ID;
                            userDto.CREATE_DTIME = Convert.ToDateTime(DateTime.Now);
                            System_User_BLL.Add_User(userDto); // return text box data from bll class
                            MessageBox.Show("User wass added");
                            Clear();
                            Load_Data();
                        }
                    }

                }
                catch (Exception ex)
                {

                    MessageBox.Show("Error" + ex);
                }

            }
        }

        private void Clear()
        {
            txtfullname.Clear();
            txtename.Clear();
            txtnic.Clear();
            txtphonenrmber.Clear();
            txttelephone.Clear();
            txtaddress.Clear();
            txtename.Clear();
            txtephone.Clear();


        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        List<RELATIONSHIP> List_Relationship = new List<RELATIONSHIP>();
        Customer_DTO customer_details = new Customer_DTO();

        private void UC_New_User_Load(object sender, EventArgs e)
        {
            List_Relationship = Customer_BLL.Get_User_Relationship_list();
            cmbrelation.DataSource = List_Relationship;
            cmbrelation.DisplayMember = "FamilyMember";
            cmbrelation.ValueMember = "RID";
            cmbrelation.SelectedValue = -1;
            Load_Data();




        }

        private void Load_Data()
        {
            int RollCustomer = 4;
            customer_details = Customer_BLL.Get_CUstomer_Details(RollCustomer);

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
            dataGridView1.Columns[13].Visible = false;
        }
        private void txtphonenrmber_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Genaral.isNumber(e);
        }

        private void txttelephone_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Genaral.isNumber(e);
        }

        private void txtephone_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Genaral.isNumber(e);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtrname.Text.Trim() == "")
                {
                    MessageBox.Show("Name is empty");
                }
                else
                {
                    CUSTOMER_RELATION customerRelation = new CUSTOMER_RELATION();
                    customerRelation.RID = Convert.ToInt32(cmbrelation.SelectedValue);
                    customerRelation.NAME = txtrname.Text;
                    customerRelation.DOB = dprdob.Value;
                    customerRelation.CUSTOMER_ID = Convert.ToInt32(txtcustomerid.Text);
                    Customer_BLL.AddCustemrRelations(customerRelation);
                    MessageBox.Show("Add success full !");

                }
                
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error" + ex);
            }
           
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            for(int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                Genaral.ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                txtcustomerid.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtfullname.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtserneme.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtnic.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtphonenrmber.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                txttelephone.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtaddress.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                dpdob.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
                txtename.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
                txtephone.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
                txtusername.Text = dataGridView1.Rows[e.RowIndex].Cells[12].Value.ToString();

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Genaral.Relation_ID = Convert.ToInt32(txtcustomerid.Text);
            frmRelation frm = new frmRelation();
            frm.ShowDialog();
        }

        private void btnmodify_Click(object sender, EventArgs e)
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
                        userDto.SURNAME = txtserneme.Text;
                        userDto.NIC = txtnic.Text;
                        userDto.PHONENUMBER = Convert.ToInt32(txtphonenrmber.Text);
                        userDto.TELEPHONE = Convert.ToInt32(txttelephone.Text);
                        userDto.ADDRESS = txtaddress.Text;
                        userDto.DOB = dpdob.Value;
                        userDto.ENAME = txtename.Text;
                        userDto.EPHONENUMBER = Convert.ToInt32(txtephone.Text);
                        userDto.SYSTEM_USER_NAME = txtusername.Text;
                        userDto.PASS = Genaral.hashPassword(txtpassword.Text);
                        System_User_BLL.UpdateUser(userDto); // return text box data from bll class
                        MessageBox.Show("User was Update !");
                        Load_Data();
                        Clear();
                    }
                    else
                    {
                        MessageBox.Show("Password dosn not match!");
                    }
                }
            }

           

            Clear();
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

        private void button1_Click(object sender, EventArgs e)
        {
            frmReport frm = new frmReport();
            UserDetails_CrystalReport rpt = new UserDetails_CrystalReport();
            TextObject fullname_text = (TextObject)rpt.ReportDefinition.Sections["Section2"].ReportObjects["name"];
            fullname_text.Text = txtfullname.Text;

            TextObject nic_text = (TextObject)rpt.ReportDefinition.Sections["Section2"].ReportObjects["txtNic"];
            nic_text.Text = txtnic.Text;

            TextObject phoneNumber_text = (TextObject)rpt.ReportDefinition.Sections["Section2"].ReportObjects["txtPhoneNumber"];
            phoneNumber_text.Text = txtphonenrmber.Text;

            TextObject telephoneNumber = (TextObject)rpt.ReportDefinition.Sections["Section2"].ReportObjects["txtTelephoneNumber"];
            telephoneNumber.Text = txttelephone.Text;

            TextObject addrss_text = (TextObject)rpt.ReportDefinition.Sections["Section2"].ReportObjects["txtAddress"];
            addrss_text.Text = txtaddress.Text;

            TextObject dob_text = (TextObject)rpt.ReportDefinition.Sections["Section2"].ReportObjects["txtDOB"];
            dob_text.Text = dpdob.Text;

            frm.crystalReportViewer1.ReportSource = rpt;
            frm.Show();
        }
    }
}
