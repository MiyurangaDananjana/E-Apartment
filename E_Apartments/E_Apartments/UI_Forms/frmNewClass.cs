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
    public partial class frmNewClass : Form
    {
        public frmNewClass()
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
                APARTMENT_CLASS name = new APARTMENT_CLASS();
                name.CLASS_NAME = textBox2.Text;
                Apartment_BLL.AddNewClass(name);
                textBox2.Clear();
                MessageBox.Show("Add Success!");
            }
        }
    }
}
