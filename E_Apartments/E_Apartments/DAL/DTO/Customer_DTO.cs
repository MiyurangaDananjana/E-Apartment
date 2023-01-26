using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Apartments.DAL.DTO
{
    public class Customer_DTO
    {
        public List<Customer_Detail_DTO> Customers { get; set; }

        public List<CustomerRelationDetails> Relations { get; set; }

        public List<Customer_Wating_List> CustomerWatingList { get; set; }
    }

    public class System_User_DTO
    {
        public List<System_user_Detail_DTO> System_User_Ditail { get; set; }
    }


}
