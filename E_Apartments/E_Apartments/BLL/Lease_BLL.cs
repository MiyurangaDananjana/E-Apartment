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
    public class Lease_BLL
    {
        internal static void Add_Customer_Lease_Detail(APARTMENT_LEASE al)
        {
            Lease_DAO.Add_Lease(al);
        }

        internal static List<PAYMENT_METHOD> Get_Payment_Method()
        {
            return Lease_DAO.Get_Payment_Method();
        }

        internal static Lease_DTO Get_Apartment_Lease_Request(int states)
        {
            Lease_DTO dto = new Lease_DTO();
            dto.Apartment_Lease = Lease_DAO.Get_Apartment_Lease_Request(states);
            return dto;
        }

        internal static void Update_Aprove(APARTMENT_LEASE al)
        {
            Lease_DAO.Update_Aprove(al);
        }

        internal static void UpdateMonth(APARTMENT_LEASE aprtment_lease)
        {
            Lease_DAO.UpdateMonth(aprtment_lease);
        }

        internal static void Receipt(PAYMENT pay)
        {
            Lease_DAO.Receipt(pay);
        }

        
    }
}
