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
    public partial class frmApartmentView : Form
    {
        public frmApartmentView()
        {
            InitializeComponent();
        }
        Apartment_DTO ad = new Apartment_DTO();
        private void frmApartmentView_Load(object sender, EventArgs e)
        {
            ad = Apartment_BLL.GetApartmentDetail();
            dataGridView1.DataSource = ad.Apartment_Details;
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].HeaderText = "APARTMENT NAME";
            dataGridView1.Columns[2].HeaderText = "LOCATION";
            dataGridView1.Columns[3].HeaderText = "CLASS";
            dataGridView1.Columns[4].HeaderText = "FLOW_AREA";
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].Visible = false;
            dataGridView1.Columns[8].Visible = false;
            dataGridView1.Columns[9].Visible = false;
            dataGridView1.Columns[10].Visible = false;
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e) //5
        {
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                Genaral.Apartment_ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                lblid.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                frmLease.leaseInstance.LabelAparementID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();


                frmLease.leaseInstance.LabelApartmentName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();


                frmLease.leaseInstance.LabelLocation.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                Genaral.Location = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();


                frmLease.leaseInstance.LabelRent.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                Genaral.Applicable_Rent_Property = Convert.ToDecimal(dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString());
                
                frmLease.leaseInstance.LabelAmount.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                Genaral.Applicable_Amount = Convert.ToDecimal(dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString());

                frmLease.leaseInstance.LabelDepositAmount.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
                Genaral.Applicable_Deposite_Amount_Property = Convert.ToDecimal(dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString());

                
                Genaral.Apartment_occupation = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString());

                frmLease.leaseInstance.LabelFee.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
                Genaral.Applicable_Reservation_Property = Convert.ToDecimal(dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString());

            }
        }
    }
}
