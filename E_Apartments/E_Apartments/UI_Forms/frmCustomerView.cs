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
using E_Apartments.UI_Forms;
using System.Windows.Forms;
using E_Apartments.UC;

namespace E_Apartments.UI_Forms
{
    public partial class frmCustomerView : Form
    {
        public static frmCustomerView frmCustomerViewInsatance;
        
    
        public frmCustomerView()
        {
            InitializeComponent();
            

            
        }
        Customer_DTO customer_details = new Customer_DTO();
        private void frmCustomerView_Load(object sender, EventArgs e)
        {
            int RollCustomer = 4;
            customer_details = Customer_BLL.Get_CUstomer_Details(RollCustomer);
            dataGridView1.DataSource = customer_details.Customers;
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].HeaderText = "FULL NAME";
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[3].HeaderText = "NIC";
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].Visible = false;
            dataGridView1.Columns[8].Visible = false;
            dataGridView1.Columns[9].Visible = false;
            dataGridView1.Columns[10].Visible = false;
            dataGridView1.Columns[11].Visible = false;
            dataGridView1.Columns[12].Visible = false;
            dataGridView1.Columns[13].Visible = false;
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
          
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                Genaral.Customer_ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                txtid.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                frmLease.leaseInstance.lblcustomerID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                Genaral.Customer_Name = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                frmLease.leaseInstance.lblCustomerName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                Genaral.Customer_Nic = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                frmLease.leaseInstance.lblCustomerNIC.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
        }

        private void txtid_TextChanged(object sender, EventArgs e)
        {
            
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }
    }
}
