using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Apartments.DAL.DTO
{
    public class Lease_DTO_Detail
    {
        public int ID { get; set; }
        public int? Customer_ID { get; set; }
        public string Customer_Name { get; set; }
        public string Customer_NIC { get; set; }
        public int? Apartment_ID { get; set; }
        public string Apartment_Location { get; set; }
        public string  Apartment_Name { get; set; }
        public string Parking_Space_ID { get; set; }
        public string  Extra_Parking_Space_ID { get; set; }
        public decimal? Extra_Parking_Space_Rental { get; set; }

        public decimal? Monthly_Rental { get; set; }
        public decimal? Deposite_Amount { get; set; }

      
        public DateTime? Start_Date { get; set; }
        public DateTime? End_Date  { get; set; }
        public string Payment_Method { get; set; }
      
        public DateTime? Create_Date { get; set; }

        public int? Months { get; set; }

    }
    public class Lease_DTO
    {
        public List<Lease_DTO_Detail> Apartment_Lease { get; set; }

        public List<Payment_Last_ID_List> Id_list { get; set; }
    }

    public class Payment_Last_ID_List
    {
        public int ID { get; set; }
    }
}
