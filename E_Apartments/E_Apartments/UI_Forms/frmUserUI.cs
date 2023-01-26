using E_Apartments.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Apartments.UI_Forms
{
    public partial class frmUserUI : Form
    {
        public frmUserUI()
        {
            InitializeComponent();
        }

        private void frmUserUI_Load(object sender, EventArgs e)
        {
            lblusername.Text = Genaral.User_Name;

            using (DBContextDataContext db = new DBContextDataContext())
            {
                var userChack = db.APARTMENT_LEASEs.Where(x => x.CUSTOMER_ID == Genaral.Login_Emp_ID).FirstOrDefault();
                lblleaseid.Text = userChack.ID.ToString();
                startdate.Text = userChack.LEASE_START_DATE.ToString();
                enddate.Text = userChack.END_DATE.ToString();
                lblmonthlyrental.Text = userChack.FRIST_RENT_AMOUNT.ToString();
                lblparkingspaceid.Text = userChack.PARKING_SPACE_ID.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmLogin frm = new frmLogin();
            this.Hide();
            Genaral.Login_Emp_ID = 0;
            frm.ShowDialog();
        }

        private void btnDashbord_Click(object sender, EventArgs e)
        {
            frmComment frm = new frmComment();
            frm.ShowDialog();
        }
    }
}
