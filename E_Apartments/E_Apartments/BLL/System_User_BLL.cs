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
    class System_User_BLL
    {
        internal static List<ROLL> Get_Roll()
        {
            return System_User_DAO.Get_Roll();
        }

        public static void Insert(SYSTEM_USERS_DETAIL userDto)
        {
            System_User_DAO.Add_New_User(userDto);
        }

        public static List<APARTMENT_NAME> Get_Apartment_List()
        {
            return System_User_DAO.Get_Apartment_List();
        }

        internal static void Add_User(SYSTEM_USERS_DETAIL userDto)
        {
            System_User_DAO.Add_New_User(userDto);
        }

        internal static System_User_DTO LoadSystemUserDetail()
        {
            System_User_DTO system_user = new System_User_DTO();
            system_user.System_User_Ditail = System_User_DAO.LoadSystemUserDetail();
            return system_user;
        }

        internal static void UpdateUser(SYSTEM_USERS_DETAIL userDto)
        {
            System_User_DAO.UpdateUser(userDto);
        }

        internal static void DeleteUser(int v)
        {
            System_User_DAO.DeleteUser(v);
        }
    }
}
