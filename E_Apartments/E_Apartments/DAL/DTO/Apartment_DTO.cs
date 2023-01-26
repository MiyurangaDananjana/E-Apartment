using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Apartments.DAL.DTO
{
    public class Apartment_Detail_DTO
    {
        public int ID { get; set; }
        public string ApartmentName { get; set; }
        public string Location { get; set; }
        public string ClassName { get; set; }
        public int? flowArea { get; set; }
        public decimal? applicableRent { get; set; }
        public decimal? applicableAmount { get; set; }
        public decimal? applicableDepositAmount { get; set; }
        public int? applicableMaxOccupation { get; set; }
        public decimal? ApplicableReservationFee { get; set; }

        public int? Numbaravailable { get; set; }

    }
    public class Apartment_DTO
    {
        public List<Apartment_Detail_DTO> Apartment_Details { get; set; }
    }

    public class Customer_Wating_List
    {
        public int ID { get; set; }
        public string CustomerName { get; set; }
        public string NicNumber { get; set; }
        public int? PhoneNumber { get; set; }
        public DateTime? DateTime { get; set; }
        public int? ApartmentID { get; set; }
    }
}
