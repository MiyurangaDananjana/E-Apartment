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
    public partial class Appartment_UC : UserControl
    {
        public Appartment_UC()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbAppartmentName.Text.Trim() == "")
                {
                    MessageBox.Show("Apartment name is empty");
                }
                else if (txtlocation.Text.Trim() == "")
                {
                    MessageBox.Show("apartment location is empty");
                }
                else
                {
                    APARTMENT apartmnt = new APARTMENT();
                    apartmnt.APARTMENT_ID = Convert.ToInt32(cmbAppartmentName.SelectedValue);
                    apartmnt.LOCATION = txtlocation.Text;
                    apartmnt.CLASS_ID = Convert.ToInt32(cmbclass.SelectedValue);
                    apartmnt.FLOW_AREA = Convert.ToInt32(txtFlowarea.Text);
                    apartmnt.APPLICABLE_RENT = Convert.ToDecimal(txtApplicablerent.Text);
                    apartmnt.APPLICABLE_AMOUNT = Convert.ToDecimal(txtApplicableAmountmount.Text);
                    apartmnt.APPLICABLE_DEPOSIT_AMOUNT = Convert.ToDecimal(txtdepositeamount.Text);
                    apartmnt.APPLICABLE_MAXIMUM_N_F_OCCUP = Convert.ToInt32(txtmax.Text);
                    apartmnt.APPLICABLE_RESERVATION_FEE = Convert.ToDecimal(txtReservetionFee.Text);
                    apartmnt.NUMBER_AVAILABLE = Convert.ToInt32(txtNumber.Text);
                    Apartment_BLL.Add_Apartment(apartmnt);
                    MessageBox.Show("Add New Apartment");
                    LoadData();
                } 
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error" + ex);
            }
          
            
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Genaral.isNumber(e);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Genaral.isNumber(e);
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Genaral.isNumber(e);
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Genaral.isNumber(e);
        }

        List<APARTMENT_CLASS> ap_class = new List<APARTMENT_CLASS>();
        List<APARTMENT_NAME> ap_Name = new List<APARTMENT_NAME>();
        Apartment_DTO ad = new Apartment_DTO();
        private void Appartment_UC_Load(object sender, EventArgs e)
        {
            LoadData();

            /// Load the Class tabel data to combox

            ap_Name = Apartment_BLL.GetApartmentName();
            cmbAppartmentName.DataSource = ap_Name;
            cmbAppartmentName.DisplayMember = "APARTMENT_NAME1";
            cmbAppartmentName.ValueMember = "AP_NAME_ID";
            cmbAppartmentName.SelectedValue = -1;

            ap_class = Apartment_BLL.Get_Apartment_List();
            cmbclass.DataSource = ap_class;
            cmbclass.DisplayMember = "CLASS_NAME";
            cmbclass.ValueMember = "APARTMENT_CLASS_ID";
            cmbclass.SelectedValue = -1;

        }
        private void LoadData()
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
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                Genaral.ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                cmbAppartmentName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtlocation.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                


            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                APARTMENT apartmnt = new APARTMENT();
                apartmnt.ID = Genaral.ID;
                apartmnt.APARTMENT_ID = Convert.ToInt32(cmbAppartmentName.SelectedValue);
                apartmnt.LOCATION = txtlocation.Text;
                apartmnt.CLASS_ID = Convert.ToInt32(cmbclass.SelectedValue);
                apartmnt.FLOW_AREA = Convert.ToInt32(txtFlowarea.Text);
                apartmnt.APPLICABLE_RENT = Convert.ToDecimal(txtApplicablerent.Text);
                apartmnt.APPLICABLE_AMOUNT = Convert.ToDecimal(txtApplicableAmountmount.Text);
                apartmnt.APPLICABLE_DEPOSIT_AMOUNT = Convert.ToDecimal(txtdepositeamount.Text);
                apartmnt.APPLICABLE_MAXIMUM_N_F_OCCUP = Convert.ToInt32(txtmax.Text);
                apartmnt.APPLICABLE_RESERVATION_FEE = Convert.ToDecimal(txtReservetionFee.Text);
                apartmnt.NUMBER_AVAILABLE = Convert.ToInt32(txtNumber.Text);
                LoadData();
                Apartment_BLL.UpdateApartment(apartmnt);
                MessageBox.Show("update Apartment");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error" + ex);
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Are you sure to delete", "Warning", MessageBoxButtons.YesNo);
            if (DialogResult.Yes == result)
            {
                Apartment_BLL.Deleteapartment(Convert.ToInt32(Genaral.ID));
                MessageBox.Show("Delete !");

            }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.Handled = Genaral.isNumber(e);
        }

        private void textBox2_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.Handled = Genaral.isNumber(e);
        }

        private void textBox3_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.Handled = Genaral.isNumber(e);
        }

        private void textBox4_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.Handled = Genaral.isNumber(e);
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Genaral.isNumber(e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmUserCheck frm = new frmUserCheck();
            frm.txtUserName.Text = Genaral.System_User_Name;
            Genaral.LockCheck = 2;
            frm.ShowDialog();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmUserCheck frm = new frmUserCheck();
            frm.txtUserName.Text = Genaral.System_User_Name;
            Genaral.LockCheck = 1 ;
            frm.ShowDialog();
            //frmNewClass frm = new frmNewClass();
            //frm.ShowDialog();
        }
    }
}
