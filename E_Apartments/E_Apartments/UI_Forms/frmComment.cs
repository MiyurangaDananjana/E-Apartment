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

namespace E_Apartments.UI_Forms
{
    public partial class frmComment : Form
    {
        public frmComment()
        {
            InitializeComponent();
            txtcomment.MaxLength = 200;
        }

        private void btnDashbord_Click(object sender, EventArgs e)
        {
            if(txtcomment.Text.Trim() == "")
            {
              
                lblmessage.Text = "Comment box is empty";
            }
            else
            {
                CUSTOMER_COMMENT comment = new CUSTOMER_COMMENT();
                comment.COMMENT = txtcomment.Text;
                comment.DATETIME = DateTime.Now;
                comment.STATES = Convert.ToInt32(1); // 1 - non read message
                Customer_BLL.Add_Customer_Comment(comment);
                txtcomment.Clear();
                
                lblmessage.Text = "Sent User Comment to admin";
            }
            
        }

        private void txtcomment_TextChanged(object sender, EventArgs e)
        {
            lblcount.Text = txtcomment.Text.Length.ToString();
            if(txtcomment.Text.Length == 200)
            {
                panel1.BackColor = Color.Red;
            }
            else if(txtcomment.Text.Length == 0)
            {
                panel1.BackColor = Color.DarkViolet;
            }
            
            
        }

        private void frmComment_Load(object sender, EventArgs e)
        {

        }
    }
}
