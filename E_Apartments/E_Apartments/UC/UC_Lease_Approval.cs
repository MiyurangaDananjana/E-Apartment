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
using static E_Apartments.Genaral;

namespace E_Apartments.UC
{
    public partial class UC_Lease_Approval : UserControl
    {
        //15
        public UC_Lease_Approval()
        {
            InitializeComponent();
        }
        Lease_DTO dto = new Lease_DTO();
        private void UC_Lease_Approval_Load(object sender, EventArgs e)
        {
            Load_Table();
        }
        private void Load_Table()
        {


            int states = (int)ManagerActivitie.Created;

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
            dataGridView1.Columns[16].Visible = false;
        }
        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {

            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                Genaral.ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                lblcustomr_id.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                lblcustomer_name.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                lblnic.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                lblapartmentid.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                lbllocation.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                lblapartmentname.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                lblparkingspace.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
                lblextraparkingspace.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
                lblexrental.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
                lblmonthlyrental.Text = dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString();
                lbldepositramount.Text = dataGridView1.Rows[e.RowIndex].Cells[11].Value.ToString();
                lblstartdate.Text = dataGridView1.Rows[e.RowIndex].Cells[12].Value.ToString();
                lblenddate.Text = dataGridView1.Rows[e.RowIndex].Cells[13].Value.ToString();
                lblpaymentmethad.Text = dataGridView1.Rows[e.RowIndex].Cells[14].Value.ToString();
                lblcreatedate.Text = dataGridView1.Rows[e.RowIndex].Cells[15].Value.ToString();


                DateTime StartDate = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells[12].Value.ToString());
                DateTime EndDate = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells[13].Value.ToString());
                int total_months = (EndDate.Year - StartDate.Year) * 12 + StartDate.Month - EndDate.Month;
                decimal Total_Rental = Convert.ToDecimal(dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString()) * total_months;
                lbltotalrental.Text = Total_Rental.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int states = (int)ManagerActivitie.Manager_Approved;

                APARTMENT_LEASE al = new APARTMENT_LEASE();
                al.ID = Genaral.ID;
                al.STATES = states;
                al.APPROVED_BY = Genaral.Login_Emp_ID;
                al.APPROVED_DATE = DateTime.Today;
                Lease_BLL.Update_Aprove(al);
                Load_Table();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error" + ex);
            }

        }

        private void btnview_Click(object sender, EventArgs e)
        {
            try
            {
                int states = (int)ManagerActivitie.Reject;

                APARTMENT_LEASE al = new APARTMENT_LEASE();
                al.ID = Genaral.ID;
                al.STATES = states;
                al.APPROVED_BY = Genaral.Login_Emp_ID;
                al.APPROVED_DATE = DateTime.Today;
                Lease_BLL.Update_Aprove(al);
                Load_Table();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error" + ex);
            }
        }
    }
}
