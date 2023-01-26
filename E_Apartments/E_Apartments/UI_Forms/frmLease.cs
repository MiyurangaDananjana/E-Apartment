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
using static E_Apartments.Genaral;

namespace E_Apartments.UI_Forms
{
    public partial class frmLease : Form
    {
        public static frmLease leaseInstance;
        public Label lblcustomerID;
        public Label lblCustomerName;
        public Label lblCustomerNIC;

        public Label LabelAparementID;
        public Label LabelLocation;
        public Label LabelApartmentName;
        public Label LabelRent;
        public Label LabelAmount;
        public Label LabelDepositAmount;
        public Label LabelFee;
        public frmLease()
        {
            InitializeComponent();
            leaseInstance = this;
            lblcustomerID = lblcustomerid;
            lblCustomerName = lblcustomername;
            lblCustomerNIC = lblnic;

            LabelAparementID = lblaprtmentid;
            LabelLocation = lbllocation;
            LabelApartmentName = lblapartmentname;
            LabelRent = lblrent;
            LabelAmount = lblamount;
            LabelDepositAmount = lbldeamount;
            LabelFee = lblfee;
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            frmCustomerView frm = new frmCustomerView();
            frm.Show();
        }

        private void btnaprtment_Click(object sender, EventArgs e)
        {
            frmApartmentView frm = new frmApartmentView();
            frm.ShowDialog();
        }

        List<PAYMENT_METHOD> Paymant_Methad = new List<PAYMENT_METHOD>();

        private void frmLease_Load(object sender, EventArgs e)
        {
            Paymant_Methad = Lease_BLL.Get_Payment_Method();
            cmbpaymentmethod.DataSource = Paymant_Methad;
            cmbpaymentmethod.DisplayMember = "PAYMENT_TYPE";
            cmbpaymentmethod.ValueMember = "ID";
            cmbpaymentmethod.SelectedValue = -1;
            txtparkingrental.Text = 0.ToString();
        }

        private void txtrent_TextChanged(object sender, EventArgs e)
        {

            if (txtrent.Text.Length == 0)
            {
                lblrent.Text = Genaral.Applicable_Rent_Property.ToString();


            }
            decimal textboxNumber, result;
            decimal.TryParse(txtrent.Text, out textboxNumber);
            decimal lblrent_property = Genaral.Applicable_Rent_Property;
            result = textboxNumber - lblrent_property;
            lblrent.Text = result.ToString();


        }

        private void txtrent_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Genaral.isNumber(e);
        }

        private void txtamount_TextChanged(object sender, EventArgs e)
        {

            if (txtamount.Text.Length == 0)
            {
                lblamount.Text = Genaral.Applicable_Amount.ToString();


            }
            decimal textboxNumber, result;
            decimal.TryParse(txtamount.Text, out textboxNumber);
            decimal lblrent_property = Genaral.Applicable_Amount;
            result = textboxNumber - lblrent_property;
            lblamount.Text = result.ToString();
        }

        private void txtdeamount_TextChanged(object sender, EventArgs e)
        {

            if (txtdeamount.Text.Length == 0)
            {
                lbldeamount.Text = Genaral.Applicable_Amount.ToString();


            }
            decimal textboxNumber, result;
            decimal.TryParse(txtdeamount.Text, out textboxNumber);
            decimal lblrent_property = Genaral.Applicable_Deposite_Amount_Property;
            result = textboxNumber - lblrent_property;
            lbldeamount.Text = result.ToString();
        }

        private void txtfee_TextChanged(object sender, EventArgs e)
        {
            if (txtfee.Text.Length == 0)
            {
                lblfee.Text = Genaral.Applicable_Amount.ToString();

            }
            decimal textboxNumber, result;
            decimal.TryParse(txtfee.Text, out textboxNumber);
            decimal lblrent_property = Genaral.Applicable_Reservation_Property;
            result = textboxNumber - lblrent_property;
            lblfee.Text = result.ToString();
        }

        private void btnDashbord_Click(object sender, EventArgs e)
        {
            DateTime Start_Date_Value = dtpstartdate.Value;
            DateTime End_Date_VAlue = dtpenddate.Value;

            int TotalMonths = (End_Date_VAlue.Year - Start_Date_Value.Year) * 12 + Start_Date_Value.Month - End_Date_VAlue.Month;

            int states = (int)ManagerActivitie.Created; // public enum 
            using (DBContextDataContext db = new DBContextDataContext())
            {
                //  var userChack = db.SYSTEM_USERS_DETAILs.Where(x => x.SYSTEM_USER_NAME == txtUserName.Text && x.PASS == Genaral.hashPassword(txtPass.Text)).FirstOrDefault(); 
                var chechUserHaveActiveLease = db.APARTMENT_LEASEs.Where(x => x.CUSTOMER_ID == Convert.ToInt32(Genaral.Customer_ID) && x.STATES == Convert.ToInt32(1)).FirstOrDefault();
                if(chechUserHaveActiveLease != null)
                {
                    MessageBox.Show("customer already have apartment lease");

                }
                else
                {

                    APARTMENT_LEASE al = new APARTMENT_LEASE();
                    al.APARTMENT_ID = Convert.ToInt32(Genaral.Apartment_ID);
                    al.CUSTOMER_ID = Convert.ToInt32(Genaral.Customer_ID);
                    al.FRIST_RENT_AMOUNT = Convert.ToDecimal(txtrent.Text);
                    al.APP_AMOUNT = Convert.ToDecimal(txtamount.Text);
                    al.DEPOSITE_AMOUNT = Convert.ToDecimal(txtdeamount.Text);
                    al.APPLICABLE_FEE = Convert.ToDecimal(txtfee.Text);
                    al.LEASE_START_DATE = dtpstartdate.Value;
                    al.END_DATE = dtpenddate.Value;
                    al.DUE_DATE = dtpduedate.Value;
                    al.DESCRIPTION = txtdescription.Text;
                    al.STATES = Convert.ToInt32(states);
                    al.CREATE_BY = Convert.ToInt32(Genaral.Login_Emp_ID);
                    al.CREATE_DATE = DateTime.Today;
                    al.PARKING_SPACE_ID = txtparkingspace.Text;
                    al.PARKING_SPACE_EXTRA_ID = txtExtra_parking.Text;
                    al.PARKING_SPACE_EXTRA_MONTHLY_RENTAL = Convert.ToDecimal(txtparkingrental.Text);
                    al.PAYMENT_TYPE_ID = Convert.ToInt32(cmbpaymentmethod.SelectedValue);
                    al.TOTALE_MONTHS = TotalMonths;

                    Lease_BLL.Add_Customer_Lease_Detail(al);

                    MessageBox.Show("Insert to the system");
                   
                }
            }


              


        }

        private void btnprint_Click(object sender, EventArgs e)
        {
            DateTime Start_Date_Value = dtpstartdate.Value;
            DateTime End_Date_VAlue = dtpenddate.Value;

            int TotalMonths = (End_Date_VAlue.Year - Start_Date_Value.Year) * 12 + Start_Date_Value.Month - End_Date_VAlue.Month;
            decimal Totel_Rent = Genaral.Applicable_Rent_Property * TotalMonths;




            frmReport frm = new frmReport();
            Lease_Invoice_CR agreement = new Lease_Invoice_CR();

            TextObject fullname_text = (TextObject)agreement.ReportDefinition.Sections["Section1"].ReportObjects["company_addree"];
            fullname_text.Text = Genaral.Location;

            TextObject Start_Date = (TextObject)agreement.ReportDefinition.Sections["Section1"].ReportObjects["start_date"];
            Start_Date.Text = dtpstartdate.Value.ToString("yyyy/MM/dd");

            TextObject End_Date = (TextObject)agreement.ReportDefinition.Sections["Section1"].ReportObjects["End_Date"];
            End_Date.Text = dtpenddate.Value.ToString("yyyy/MM/dd");

            TextObject StartDate = (TextObject)agreement.ReportDefinition.Sections["Section1"].ReportObjects["startdate"];
            StartDate.Text = dtpstartdate.Value.ToString("yyyy/MM/dd");

            TextObject enddate = (TextObject)agreement.ReportDefinition.Sections["Section1"].ReportObjects["enddate"];
            enddate.Text = dtpenddate.Value.ToString("yyyy/MM/dd");


            TextObject totalRent = (TextObject)agreement.ReportDefinition.Sections["Section1"].ReportObjects["TotalRent"];
            totalRent.Text = Totel_Rent.ToString();


            TextObject Location1 = (TextObject)agreement.ReportDefinition.Sections["Section1"].ReportObjects["Location_1"];
            Location1.Text = Genaral.Location;

            TextObject Renter_Name = (TextObject)agreement.ReportDefinition.Sections["Section1"].ReportObjects["Renter_Name"];
            Renter_Name.Text = Genaral.Customer_Name;

            TextObject Monthly_rent = (TextObject)agreement.ReportDefinition.Sections["Section1"].ReportObjects["rent"];
            Monthly_rent.Text = Genaral.Applicable_Rent_Property.ToString();

            TextObject Payment_Method = (TextObject)agreement.ReportDefinition.Sections["Section1"].ReportObjects["paymentMethod"];
            Payment_Method.Text = cmbpaymentmethod.Text;

            TextObject deposite_amount = (TextObject)agreement.ReportDefinition.Sections["Section1"].ReportObjects["depositeAmount"];
            deposite_amount.Text = txtdeamount.Text;



            TextObject occupation = (TextObject)agreement.ReportDefinition.Sections["Section1"].ReportObjects["occupation"];
            occupation.Text = Genaral.Apartment_occupation.ToString();

            frm.crystalReportViewer1.ReportSource = agreement;
            frm.ShowDialog();

        }
    }
}
