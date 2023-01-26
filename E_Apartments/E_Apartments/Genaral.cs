using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Apartments
{
    public class Genaral
    {
        public static int Login_Emp_ID { get; set; }
        public static string User_Name { get; set; }
        public static string System_User_Name { get; set; }
        public static int Relation_ID { get; set; }
        public static int LockCheck { get; set; }
        public static int ID { get; set; }

        public static int Customer_ID { get; set; }
        public static string Customer_Name { get; set; }
        public static string Customer_Nic { get; set; }

        public static int Apartment_ID { get; set; }

        public static int Apartment_occupation { get; set; }
        public static string Location { get; set; }

        public static decimal Applicable_Rent_Property { get; set; }

        public static decimal Applicable_Amount { get; set; }
        public static decimal Applicable_Deposite_Amount_Property { get; set; }
        public static decimal Applicable_Reservation_Property { get; set; }
        public static bool isNumber(KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))// can type nu,ber only
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static string hashPassword (string Password)
        {
            SHA1CryptoServiceProvider sha1 = new SHA1CryptoServiceProvider();
            byte[] password_bytes = Encoding.ASCII.GetBytes(Password);
            byte[] encrypted_bytes = sha1.ComputeHash(password_bytes);
            return Convert.ToBase64String(encrypted_bytes);


        }

        public enum ManagerActivitie
        {
            Created,
            Manager_Approved,
            Reject
        }


    }
}
