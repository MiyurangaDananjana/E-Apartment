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
    public partial class UC_CustomerDetail : UserControl
    {
        public UC_CustomerDetail()
        {
            InitializeComponent();
        }
        List<RELATIONSHIP> List_Relationship = new List<RELATIONSHIP>();
        Customer_DTO customer_details = new Customer_DTO();
        private void UC_CustomerDetail_Load(object sender, EventArgs e)
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

            dataGridView1.Columns[12].Visible = false;
            dataGridView1.Columns[13].Visible = false;

        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                Genaral.ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                lblid.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                lblfullname.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                lblsurename.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                lblnic.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                lblphonenumber.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                lbltelephonenumber.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                lbladdress.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                lbldob.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
                lblename.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
                lblephone.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();

            }
        }

        private void btnview_Click(object sender, EventArgs e)
        {
            Genaral.Relation_ID = Convert.ToInt32(lblid.Text);
            frmRelation frm = new frmRelation();
            frm.txtid.Enabled = false;
            frm.txtname.Enabled = false;
            frm.btnModify.Enabled = false;
            frm.btnremove.Enabled = false;
            frm.ShowDialog();
        }
    }
}
