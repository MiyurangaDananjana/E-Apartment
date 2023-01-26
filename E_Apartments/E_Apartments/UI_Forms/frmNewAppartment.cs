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
    public partial class frmNewAppartment : Form
    {
        public frmNewAppartment()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Trim() == "")
            {
                MessageBox.Show("Name is empty");
            }
            else
            {
                APARTMENT_NAME name = new APARTMENT_NAME();
                name.APARTMENT_NAME1 = textBox2.Text;
                name.ADD_BY = Convert.ToInt32(Genaral.Login_Emp_ID);
                name.ADD_DATE = DateTime.Today;
                Apartment_BLL.AddApartmentName(name);
                textBox2.Clear();
                MessageBox.Show("Add successfully!");
            }
           
        }

        private void frmNewAppartment_Load(object sender, EventArgs e)
        {

        }
    }
}
