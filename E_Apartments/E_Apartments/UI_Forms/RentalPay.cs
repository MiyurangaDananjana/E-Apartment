using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using E_Apartments.BLL;
using E_Apartments.DAL;
using E_Apartments.DAL.DTO;
using E_Apartments.Report;

namespace E_Apartments.UI_Forms
{
    public partial class RentalPay : Form
    {
        public static RentalPay InstanceRentalPay;

        public TextBox Lese_ID;
        public TextBox Customer_Name;
        public Label Monthly_Rental;

        public RentalPay()
        {
            InitializeComponent();
            InstanceRentalPay = this;
            Lese_ID = txtleaseID;
            Customer_Name = txtCustomername;
            Monthly_Rental = lblrental;

        }
        List<PAYMENT_METHOD> Paymant_Methad = new List<PAYMENT_METHOD>();
        private void RentalPay_Load(object sender, EventArgs e)
        {
            Paymant_Methad = Lease_BLL.Get_Payment_Method();
            cmbpaymentmethod.DataSource = Paymant_Methad;
            cmbpaymentmethod.DisplayMember = "PAYMENT_TYPE";
            cmbpaymentmethod.ValueMember = "ID";
            cmbpaymentmethod.SelectedValue = -1;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmApproveLease frm = new frmApproveLease();
            frm.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            if (txtrental.Text.Length == 0)
            {
                lblrental.Text = Genaral.Applicable_Rent_Property.ToString();


            }
            decimal textboxNumber, result;
            decimal.TryParse(txtrental.Text, out textboxNumber);
            decimal lblrent_property = Genaral.Applicable_Rent_Property;
            result = textboxNumber - lblrent_property;
            lblrental.Text = result.ToString();
        }

        private void btnrent_Click(object sender, EventArgs e)
        {
            using (DBContextDataContext db = new DBContextDataContext())
            {
                var declared_months = db.APARTMENT_LEASEs.Where(x => x.ID == Convert.ToInt32(txtleaseID.Text)).First();
                if (declared_months.TOTALE_MONTHS > 0)
                {
                    int total_month = Convert.ToInt32(declared_months.TOTALE_MONTHS);


                    int declare_this_month = total_month - 1;

                    if (txtleaseID.Text.Trim() == "")
                    {
                        MessageBox.Show("Select the lease id");
                    }
                    else
                    {
                        APARTMENT_LEASE aprtment_lease = new APARTMENT_LEASE();
                        aprtment_lease.ID = Convert.ToInt32(txtleaseID.Text);
                        aprtment_lease.TOTALE_MONTHS = declare_this_month;
                        Lease_BLL.UpdateMonth(aprtment_lease);
                        PAYMENT pay = new PAYMENT();
                        pay.LEASE_ID = Convert.ToInt32(txtleaseID.Text);
                        pay.AMOUNT = Convert.ToDecimal(txtrental.Text);
                        pay.ARREARS_AMOUNT = Convert.ToDecimal(lblrental.Text);
                        pay.PAYMENT_TYPE = Convert.ToInt32(cmbpaymentmethod.SelectedValue);
                        pay.DATE = DateTime.Now;
                        pay.RECEIPT_BY = Convert.ToInt32(Genaral.Login_Emp_ID);
                        txtCustomername.Clear();
                        txtleaseID.Clear();
                        txtrental.Clear();
                        Genaral.Applicable_Rent_Property = 0;
                        Lease_BLL.Receipt(pay);
                    }

                }
                else
                {
                    MessageBox.Show("nothing to pay");
                }


            }
        }

        private void txtleaseID_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Genaral.isNumber(e);
        }

        private void txtrental_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Genaral.isNumber(e);
        }

        List<Payment_Last_ID_List> paymentList = new List<Payment_Last_ID_List>();
        Lease_DTO dto = new Lease_DTO();
        private void btnprint_Click(object sender, EventArgs e)
        {
            using (DBContextDataContext db = new DBContextDataContext())
            {
                var LastID = db.PAYMENTs.ToArray().LastOrDefault();
                int LastInvoiceID = LastID.ID + 1;

                frmReport frm = new frmReport();
                PaymentInvoice Invoice = new PaymentInvoice();

                TextObject fullname_text = (TextObject)Invoice.ReportDefinition.Sections["Section1"].ReportObjects["txtinvoicenumber"];
                fullname_text.Text = LastInvoiceID.ToString();

                TextObject txtleaseid = (TextObject)Invoice.ReportDefinition.Sections["Section1"].ReportObjects["txtleaseid"];
                txtleaseid.Text = txtleaseID.Text;

                TextObject txtcustomerid = (TextObject)Invoice.ReportDefinition.Sections["Section1"].ReportObjects["txtcustomerid"];
                txtcustomerid.Text = txtCustomername.Text;

                TextObject txtrentall = (TextObject)Invoice.ReportDefinition.Sections["Section1"].ReportObjects["txtrental"];
                txtrentall.Text = txtrental.Text;

                TextObject txtpaymenttype = (TextObject)Invoice.ReportDefinition.Sections["Section1"].ReportObjects["txtpaymenttype"];
                txtpaymenttype.Text = cmbpaymentmethod.Text;

                frm.crystalReportViewer1.ReportSource = Invoice;
                frm.ShowDialog();
            }




        }
    }
}
