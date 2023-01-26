using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E_Apartments.DAL.DTO;
using E_Apartments.DAL;
using E_Apartments.DAL.DAO;

namespace E_Apartments.BLL
{
    public class Customer_BLL
    {
        internal static List<RELATIONSHIP> Get_User_Relationship_list()
        {
            return CustomerDAO.Get_User_Relationship_list();
        }

        internal static void Add_Customer_Details(CUSTOMER_DETAIL dto)
        {
            CustomerDAO.Add_Customer_Detail(dto);
        }

        internal static Customer_DTO Get_CUstomer_Details(int rollCustomer)
        {
            Customer_DTO customer_details = new Customer_DTO();
            customer_details.Customers = CustomerDAO.Get_Customer_Details(rollCustomer);
            return customer_details;
        }

        internal static Customer_DTO GetRelationDetails(int relation_ID)
        {
            Customer_DTO dto = new Customer_DTO();
            dto.Relations = CustomerDAO.GEtRelationDetail(relation_ID);
            return dto;
        }

        internal static void Add_Customer_Comment(CUSTOMER_COMMENT comment)
        {
            CustomerDAO.add_customer_comment(comment);
        }

        internal static void AddNewWatingList(CUSTOMER_WATING_LIST cwl)
        {
            CustomerDAO.AddNewWatingCustomer(cwl);
        }

        internal static void AddCustemrRelations(CUSTOMER_RELATION customerRelation)
        {
            CustomerDAO.addCustomerRelation(customerRelation);
        }

      

        internal static void DeleteRelation(int v)
        {
            CustomerDAO.DeleteRelation(v);
        }

       

        internal static void UpdateRelationName(CUSTOMER_RELATION cr)
        {
            CustomerDAO.UpdateRelationName(cr);
        }

        internal static Customer_DTO Get_Customer_Wating_List()
        {
            Customer_DTO dto = new Customer_DTO();
            dto.CustomerWatingList = CustomerDAO.Get_Customer_Details();
            return dto;
        }

        internal static Customer_DTO Get_CUstomer_Details(int rollManager, int rollClack, int rollAdmin)
        {
            Customer_DTO customer_details = new Customer_DTO();
            customer_details.Customers = CustomerDAO.Get_Customer_Details(rollManager,rollClack,rollAdmin);
            return customer_details;
        }
    }
}
