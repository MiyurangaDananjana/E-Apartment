using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Apartments.DAL.DTO
{
    public class Customer_Detail_DTO
    {
        public int ID { get; set; }
        public string FullName { get; set; }
        public string SureName { get; set; }
        public string NIC { get; set; }
        public int? PhoneNumber { get; set; }
        public int? TelephoneNumber { get; set; }
        public string Address { get; set; }
        public DateTime? DOB { get; set; }
        public string EName { get; set; }
        public int? EPhoneNumber { get; set; }
        public string Create_Emp_Name { get; set; }
        public DateTime? CreateDateTime { get; set; }

        public string UserName { get; set; }
        public string roleName { get; set; }
    }    

    public class CustomerRelationDetails
    {
        public int ID { get; set; }
        public string Relation { get; set; }
        public string Name { get; set; }
        public DateTime? dob { get; set; }
        public string CustomerName { get; set; }
    }
}
