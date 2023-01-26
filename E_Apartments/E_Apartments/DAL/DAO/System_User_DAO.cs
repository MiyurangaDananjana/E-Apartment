using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E_Apartments.DAL.DTO;

namespace E_Apartments.DAL.DAO
{
    public class System_User_DAO : DbContext
    {
        internal static List<ROLL> Get_Roll()
        {
            return db.ROLLs.ToList();
        }

        public static void Add_New_User(SYSTEM_USERS_DETAIL userDto)
        {
            try
            {
                db.SYSTEM_USERS_DETAILs.InsertOnSubmit(userDto);
                db.SubmitChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        internal static List<APARTMENT_NAME> Get_Apartment_List()
        {
            return db.APARTMENT_NAMEs.ToList();
        }

        internal static List<System_user_Detail_DTO> LoadSystemUserDetail()
        {
            List<System_user_Detail_DTO> UserDetail = new List<System_user_Detail_DTO>();
            var list = (from UserDetailtb in db.SYSTEM_USERS_DETAILs 
                        join Rolltb in db.ROLLs on UserDetailtb.ROLE_ID equals Rolltb.ID
                        join Create_Emp_ID in db.SYSTEM_USERS_DETAILs on UserDetailtb.ID equals Create_Emp_ID.CREATE_EMP_ID
                        select new
                        {
                            id = UserDetailtb.ID,
                            fullName = UserDetailtb.FULL_NAME,
                            SureName = UserDetailtb.SURNAME,
                            NIC = UserDetailtb.NIC,
                            PhoneNumber = UserDetailtb.PHONENUMBER,
                            TelephoneNumber = UserDetailtb.TELEPHONE,
                            Address = UserDetailtb.ADDRESS,
                            DOB = UserDetailtb.DOB,
                            eName = UserDetailtb.ENAME,
                            EPhoneNumber = UserDetailtb.EPHONENUMBER,
                            Create_Emp_Name = Create_Emp_ID.FULL_NAME,
                            Create_Date = UserDetailtb.CREATE_DTIME,
                            UserName = UserDetailtb.SYSTEM_USER_NAME,
                            RollName = Rolltb.ROLL1

                        });
            foreach (var item in list)
            {
                System_user_Detail_DTO dto = new System_user_Detail_DTO();
                dto.ID = item.id;
                dto.FullName = item.fullName;
                dto.SureName = item.SureName;
                dto.NIC = item.NIC;
                dto.PhoneNumber = item.PhoneNumber;
                dto.TelephoneNumber = item.TelephoneNumber;
                dto.Address = item.Address;
                dto.DOB = item.DOB;
                dto.EName = item.eName;
                dto.EPhoneNumber = item.EPhoneNumber;
                dto.CreateEmpName = item.Create_Emp_Name;
                dto.CreateDateTime = item.Create_Date;
                dto.UserName = item.UserName;
                dto.roleName = item.RollName;
                UserDetail.Add(dto);
            }
            return UserDetail;
        }

        internal static void DeleteUser(int v)
        {
            SYSTEM_USERS_DETAIL sud = db.SYSTEM_USERS_DETAILs.First(x => x.ID == v);
            db.SYSTEM_USERS_DETAILs.DeleteOnSubmit(sud);
            db.SubmitChanges();
        }

        internal static void UpdateUser(SYSTEM_USERS_DETAIL userDto)
        {
            try
            {
                SYSTEM_USERS_DETAIL sud = db.SYSTEM_USERS_DETAILs.First(x => x.ID == userDto.ID);
                sud.FULL_NAME = userDto.FULL_NAME;
                sud.SURNAME = userDto.SURNAME;
                sud.NIC = userDto.NIC;
                sud.PHONENUMBER = userDto.PHONENUMBER;
                sud.TELEPHONE = userDto.TELEPHONE;
                sud.ADDRESS = userDto.ADDRESS;
                sud.DOB = userDto.DOB;
                sud.ENAME = userDto.ENAME;
                sud.EPHONENUMBER = userDto.EPHONENUMBER;
                
                sud.SYSTEM_USER_NAME = userDto.SYSTEM_USER_NAME;
                sud.PASS = userDto.PASS;
                sud.ROLE_ID = userDto.ROLE_ID;
                db.SubmitChanges();
            }
            catch (Exception)
            {

                throw;
            }
            
        }
    }
}
