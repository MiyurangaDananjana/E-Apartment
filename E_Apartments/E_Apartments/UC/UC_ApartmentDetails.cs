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

namespace E_Apartments.UC
{
    public partial class UC_ApartmentDetails : UserControl
    {
        public UC_ApartmentDetails()
        {
            InitializeComponent();
        }
        Apartment_DTO ad = new Apartment_DTO();
        private void UC_ApartmentDetails_Load(object sender, EventArgs e)
        {
            
            ad = Apartment_BLL.GetApartmentDetail();
            dataGridView1.DataSource = ad.Apartment_Details;
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].HeaderText = "APARTMENT NAME";
            dataGridView1.Columns[2].HeaderText = "LOCATION";
            dataGridView1.Columns[3].HeaderText = "CLASS";
            dataGridView1.Columns[4].HeaderText = "FLOW_AREA";
            dataGridView1.Columns[5].HeaderText = "APPLICABLE_RENT";
            dataGridView1.Columns[6].HeaderText = "APPLICABLE_AMOUNT";
            dataGridView1.Columns[7].HeaderText = "APPLICABLE_DEPOSIT_AMOUNT";
            dataGridView1.Columns[8].HeaderText = "APPLICABLE_MAXIMUM_N_F_OCCUP";
            dataGridView1.Columns[9].HeaderText = "APPLICABLE_RESERVATION_FEE";
            dataGridView1.Columns[10].HeaderText = "NUMBER OF AVAILABLE";


        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {

            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                Genaral.ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                lblid.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                lblapartmentname.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                lbllocation.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                lblclass.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                lblflowarea.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                lblrent.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                lblamount.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                lbldamount.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
                lblmax.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
                lblfee.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
                lblnumber.Text = dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString();


            }
        }
    }
}
