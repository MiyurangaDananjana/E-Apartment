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
    public class Apartment_BLL
    {
        internal static void Add_Apartment(APARTMENT apartmnt)
        {
            Apartment_DAO.Add_Apartment(apartmnt);
        }

        internal static Apartment_DTO GetApartmentDetail()
        {
            Apartment_DTO ad = new Apartment_DTO();
            ad.Apartment_Details = Apartment_DAO.GetApartmentDetail();
            return ad;
        }

        internal static void UpdateApartment(APARTMENT apartmnt)
        {
            Apartment_DAO.UpdateApartment(apartmnt);
        }

        internal static void AddApartmentName(APARTMENT_NAME name)
        {
            Apartment_DAO.AddApartmentName(name);
        }

        internal static void AddNewClass(APARTMENT_CLASS name)
        {
            Apartment_DAO.AddNewClass(name);
        }

        internal static void Deleteapartment(int v)
        {
            Apartment_DAO.DeleteApartment(v);
        }

        internal static List<APARTMENT_CLASS> Get_Apartment_List()
        {
            return Apartment_DAO.GetApartmentClass();
        }

        internal static List<APARTMENT_NAME> GetApartmentName()
        {
            return Apartment_DAO.GetApartmentName();
        }
    }
}
