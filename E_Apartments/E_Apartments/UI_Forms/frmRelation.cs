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
    public partial class frmRelation : Form
    {
        public frmRelation()
        {
            InitializeComponent();
        }
        Customer_DTO customerRelation = new Customer_DTO();
        private void frmRelation_Load(object sender, EventArgs e)
        {
            customerRelation = Customer_BLL.GetRelationDetails(Genaral.Relation_ID);
            dataGridView1.DataSource = customerRelation.Relations;
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].HeaderText = "RELATION";
            dataGridView1.Columns[2].HeaderText = "NAME";
            dataGridView1.Columns[3].HeaderText = "DOB";
            dataGridView1.Columns[4].HeaderText = "CUSTOMER NAME";
        }

        private void btnremove_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure to delete", "Warning", MessageBoxButtons.YesNo);
            if (DialogResult.Yes == result)
            {
                if (txtid.Text != "")
                {
                    Customer_BLL.DeleteRelation(Convert.ToInt32(txtid.Text));
                    MessageBox.Show("Delete Position");
                }
                else
                {
                    MessageBox.Show("User ID Empty!");
                    
                }
                
                
            }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            if(txtid.Text != "")
            {
                CUSTOMER_RELATION cr = new CUSTOMER_RELATION();
                cr.ID = Convert.ToInt32(txtid.Text);
                cr.NAME = txtname.Text;
                Customer_BLL.UpdateRelationName(cr);
                MessageBox.Show("Update Success !");
            }
            else
            {
                MessageBox.Show("User ID Empty!");
            }
           

        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {

                txtid.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtname.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();

            }
        }
    }
}
