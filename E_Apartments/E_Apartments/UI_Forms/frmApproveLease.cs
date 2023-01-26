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
    public partial class frmApproveLease : Form
    {
        public frmApproveLease()
        {
            InitializeComponent();
        }
        Lease_DTO dto = new Lease_DTO();
        private void frmApproveLease_Load(object sender, EventArgs e)
        {
            int states = 1;
            dto = Lease_BLL.Get_Apartment_Lease_Request(states);
            dataGridView1.DataSource = dto.Apartment_Lease;
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].HeaderText = "Customer_ID";
            dataGridView1.Columns[2].HeaderText = "Customer_Name";
            dataGridView1.Columns[3].HeaderText = "Customer_NIC";
            dataGridView1.Columns[4].HeaderText = "Apartment_ID";
            dataGridView1.Columns[5].HeaderText = "Apartment_Location";
            dataGridView1.Columns[6].HeaderText = "Apartment_Name";
            dataGridView1.Columns[7].HeaderText = "Parking_Space_ID";
            dataGridView1.Columns[8].HeaderText = "Extra_Parking_Space_ID";
            dataGridView1.Columns[9].HeaderText = "Extra_Parking_Space_Rental";
            dataGridView1.Columns[10].HeaderText = "Monthly_Rental";
            dataGridView1.Columns[11].HeaderText = "Deposite_Amount";
            dataGridView1.Columns[12].HeaderText = "Start_Date";
            dataGridView1.Columns[13].HeaderText = "End_Date";
            dataGridView1.Columns[14].HeaderText = "Payment_Method";
            dataGridView1.Columns[15].HeaderText = "Create_Date";
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            RentalPay.InstanceRentalPay.Lese_ID.Text =   dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            RentalPay.InstanceRentalPay.Customer_Name.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            RentalPay.InstanceRentalPay.Monthly_Rental.Text = dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString();
            Genaral.Applicable_Rent_Property = Convert.ToDecimal(dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString());
        }
    }
}
