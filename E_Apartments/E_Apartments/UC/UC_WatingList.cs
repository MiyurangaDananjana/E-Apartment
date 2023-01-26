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

namespace E_Apartments.UC
{
    public partial class UC_WatingList : UserControl
    {
        public UC_WatingList()
        {
            InitializeComponent();

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (txtcustomername.Text.Trim() == "")
            {
                MessageBox.Show("Customer Name is empty");
            }
            else if (txtnicnumber.Text.Trim() == "")
            {
                MessageBox.Show("NIC is epty");
            }
            else if (txtPhonenumber.Text.Trim() == "")
            {
                MessageBox.Show("Customer Phone number is epty");
            }
            else if (Genaral.Apartment_ID == 0)
            {
                MessageBox.Show("Pleas select apartment");
            }
            else
            {

                CUSTOMER_WATING_LIST cwl = new CUSTOMER_WATING_LIST();
                cwl.CUSTOMER_NAME = txtcustomername.Text;
                cwl.NIC = txtnicnumber.Text;
                cwl.PHONE_NUMBER = Convert.ToInt32(txtPhonenumber.Text);
                cwl.DATE_TIME = DateTime.Now;
                cwl.APARTMENT_ID = Convert.ToInt32(Genaral.Apartment_ID);
                cwl.ADD_BY = Convert.ToInt32(Genaral.Login_Emp_ID);
                Customer_BLL.AddNewWatingList(cwl);
                MessageBox.Show("Add Success!");
            }

        }
        Customer_DTO customer_dto = new Customer_DTO();
        private void UC_WatingList_Load(object sender, EventArgs e)
        {
            customer_dto = Customer_BLL.Get_Customer_Wating_List();
            dataGridView1.DataSource = customer_dto.CustomerWatingList;
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].HeaderText = "CUSTOMER NAME";
            dataGridView1.Columns[2].HeaderText = "NIC";
            dataGridView1.Columns[3].HeaderText = "PHONE NUMBER";
            dataGridView1.Columns[4].HeaderText = "DATE TIME";
            dataGridView1.Columns[5].HeaderText = "APARTMENT ID";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmApartmentView frm = new frmApartmentView();
            frm.ShowDialog();
        }

        private void txtapartmentname_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void Load_textbox()
        {
            if (Genaral.Apartment_ID == 0)
            {
                MessageBox.Show("Please Select Apartment");
            }
            else
            {
                txtapartmentname.Text = Genaral.Apartment_ID.ToString();
            }
        }

        private void txtapartmentname_Click(object sender, EventArgs e)
        {
            Load_textbox();
        }
    }
}
