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

namespace E_Apartments.UC
{
    public partial class UC_Admin_Dashbord : UserControl
    {
        public UC_Admin_Dashbord()
        {
            InitializeComponent();
        }

        private void UC_Admin_Dashbord_Load(object sender, EventArgs e)
        {
            using (DBContextDataContext db = new DBContextDataContext())
            {
                var Apartment_Count = db.APARTMENT_NAMEs.Select(x => x.AP_NAME_ID).Count() ;
                lbltotalflor.Text = Apartment_Count.ToString();

                var countCustome = db.SYSTEM_USERS_DETAILs.Select(x => x.ROLE_ID == 4).Count();
                lblcustomers.Text = countCustome.ToString();

                var customerComment = db.CUSTOMER_COMMENTs.Select(x => x.ID).Count();
                lblcomment.Text = customerComment.ToString();


            }
        }
    }
}
