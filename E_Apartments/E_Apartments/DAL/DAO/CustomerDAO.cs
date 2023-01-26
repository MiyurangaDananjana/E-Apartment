using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E_Apartments.DAL.DTO;

namespace E_Apartments.DAL.DAO
{
    public class CustomerDAO : DbContext
    {
        internal static List<RELATIONSHIP> Get_User_Relationship_list()
        {
            return db.RELATIONSHIPs.ToList();
        }

        internal static void Add_Customer_Detail(CUSTOMER_DETAIL dto)
        {
            try
            {
                db.CUSTOMER_DETAILs.InsertOnSubmit(dto);
                db.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        internal static List<Customer_Detail_DTO> Get_Customer_Details(int rollCustomer)
        {
            List<Customer_Detail_DTO> customer_detail_list = new List<Customer_Detail_DTO>();
            var list = (from customerDetail in db.SYSTEM_USERS_DETAILs
                        where customerDetail.ROLE_ID == rollCustomer
                        join usertb in db.SYSTEM_USERS_DETAILs on customerDetail.ID equals usertb.ID
                        select new
                        {
                            id = customerDetail.ID,
                            fullName = customerDetail.FULL_NAME,
                            sureName = customerDetail.SURNAME,
                            NIC = customerDetail.NIC,
                            phoneNumber = customerDetail.PHONENUMBER,
                            telephoneNumber = customerDetail.TELEPHONE,
                            address = customerDetail.ADDRESS,
                            dob = customerDetail.DOB,
                            ename = customerDetail.ENAME,
                            ePhoneNumber = customerDetail.EPHONENUMBER,
                            create_emp_name = usertb.FULL_NAME,
                            createDate = customerDetail.CREATE_DTIME,
                            userName = customerDetail.SYSTEM_USER_NAME
                        }) ;
            foreach(var item in list)
            {
                Customer_Detail_DTO dto = new Customer_Detail_DTO();
                dto.ID = item.id;
                dto.FullName = item.fullName;
                dto.SureName = item.sureName;
                dto.NIC = item.NIC;
                dto.PhoneNumber = item.phoneNumber;
                dto.TelephoneNumber = item.telephoneNumber;
                dto.Address = item.address;
                dto.DOB = item.dob;
                dto.EName = item.ename;
                dto.EPhoneNumber = item.ePhoneNumber;
                dto.Create_Emp_Name = item.create_emp_name;
                dto.CreateDateTime = item.createDate;
                dto.UserName = item.userName;
                customer_detail_list.Add(dto);
            }
            return customer_detail_list;
        }

        internal static void add_customer_comment(CUSTOMER_COMMENT comment)
        {
            try
            {
                db.CUSTOMER_COMMENTs.InsertOnSubmit(comment);
                db.SubmitChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        internal static List<Customer_Wating_List> Get_Customer_Details()
        {
            List<Customer_Wating_List> add_list = new List<Customer_Wating_List>();

            var list = (from CUSTOMER_WATING_LIST in db.CUSTOMER_WATING_LISTs

                        select new
                        {
                            id = CUSTOMER_WATING_LIST.ID,
                            customeName = CUSTOMER_WATING_LIST.CUSTOMER_NAME,
                            nic = CUSTOMER_WATING_LIST.NIC,
                            phoneNumebr = CUSTOMER_WATING_LIST.PHONE_NUMBER,
                            dateTime = CUSTOMER_WATING_LIST.DATE_TIME,
                            apartmentID = CUSTOMER_WATING_LIST.APARTMENT_ID,

                        }
                        );
            foreach(var item in list)
            {
                Customer_Wating_List dto = new Customer_Wating_List();
                dto.ID = item.id;
                dto.CustomerName = item.customeName;
                dto.NicNumber = item.nic;
                dto.PhoneNumber = item.phoneNumebr;
                dto.DateTime = item.dateTime;
                dto.ApartmentID = item.apartmentID;
                add_list.Add(dto);

            }
            return add_list;
        }

        internal static void AddNewWatingCustomer(CUSTOMER_WATING_LIST cwl)
        {
            try
            {
                db.CUSTOMER_WATING_LISTs.InsertOnSubmit(cwl);
                db.SubmitChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        internal static List<Customer_Detail_DTO> Get_Customer_Details(int rollManager, int rollClack, int rollAdmin)
        {

            List<Customer_Detail_DTO> customer_detail_list = new List<Customer_Detail_DTO>();
            var list = (from customerDetail in db.SYSTEM_USERS_DETAILs
                        where customerDetail.ROLE_ID == rollManager || customerDetail.ROLE_ID == rollClack || customerDetail.ROLE_ID == rollAdmin
                        join usertb in db.SYSTEM_USERS_DETAILs on customerDetail.ID equals usertb.ID
                        join roll in db.ROLLs on customerDetail.ROLE_ID equals roll.ID
                        select new
                        {
                            id = customerDetail.ID,
                            fullName = customerDetail.FULL_NAME,
                            sureName = customerDetail.SURNAME,
                            NIC = customerDetail.NIC,
                            phoneNumber = customerDetail.PHONENUMBER,
                            telephoneNumber = customerDetail.TELEPHONE,
                            address = customerDetail.ADDRESS,
                            dob = customerDetail.DOB,
                            ename = customerDetail.ENAME,
                            ePhoneNumber = customerDetail.EPHONENUMBER,
                            create_emp_name = usertb.FULL_NAME,
                            createDate = customerDetail.CREATE_DTIME,
                            userName = customerDetail.SYSTEM_USER_NAME,
                            userRoll = roll.ROLL1
                        });
            foreach (var item in list)
            {
                Customer_Detail_DTO dto = new Customer_Detail_DTO();
                dto.ID = item.id;
                dto.FullName = item.fullName;
                dto.SureName = item.sureName;
                dto.NIC = item.NIC;
                dto.PhoneNumber = item.phoneNumber;
                dto.TelephoneNumber = item.telephoneNumber;
                dto.Address = item.address;
                dto.DOB = item.dob;
                dto.EName = item.ename;
                dto.EPhoneNumber = item.ePhoneNumber;
                dto.Create_Emp_Name = item.create_emp_name;
                dto.CreateDateTime = item.createDate;
                dto.UserName = item.userName;
                dto.roleName = item.userRoll;
                customer_detail_list.Add(dto);
            }
            return customer_detail_list;
        }

        internal static void DeleteRelation(int v)
        {
            CUSTOMER_RELATION cr = db.CUSTOMER_RELATIONs.First(x => x.ID == v);
            db.CUSTOMER_RELATIONs.DeleteOnSubmit(cr);
            db.SubmitChanges();
        }

        internal static void UpdateRelationName(CUSTOMER_RELATION cr)
        {
            try
            {
                CUSTOMER_RELATION customerRelation = db.CUSTOMER_RELATIONs.First(x => x.ID == cr.ID);
                customerRelation.NAME = cr.NAME;
                db.SubmitChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

      

        internal static void UpdateCustomer(SYSTEM_USERS_DETAIL dto)
        {
            try
            {
                SYSTEM_USERS_DETAIL cd = db.SYSTEM_USERS_DETAILs.First(x => x.ID == dto.ID);
                cd.FULL_NAME = dto.FULL_NAME;
                cd.SURNAME = dto.SURNAME;
                cd.NIC = dto.NIC;
                cd.PHONENUMBER = dto.PHONENUMBER;
                cd.TELEPHONE = dto.TELEPHONE;
                cd.ADDRESS = dto.ADDRESS;
                cd.DOB = dto.DOB;
                cd.ENAME = dto.ENAME;
                cd.EPHONENUMBER = dto.EPHONENUMBER;
                db.SubmitChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }     
        }
        internal static List<CustomerRelationDetails> GEtRelationDetail(int relation_ID)
        {
            List<CustomerRelationDetails> crd = new List<CustomerRelationDetails>();
            var list = (from relation in db.CUSTOMER_RELATIONs
                        where relation.CUSTOMER_ID == relation_ID
                        join relationship in db.RELATIONSHIPs on relation.RID equals relationship.RID
                        join customer in db.SYSTEM_USERS_DETAILs on relation.CUSTOMER_ID equals customer.ID
                        select new
                        {
                            id = relation.ID,
                            Relation = relationship.FamilyMember,
                            Name = relation.NAME,
                            dob = relation.DOB,
                            CustomerName = customer.FULL_NAME
                        }
                        );
            foreach (var item in list)
            {
                CustomerRelationDetails dto = new CustomerRelationDetails();
                dto.ID = item.id;
                dto.Relation = item.Relation;
                dto.Name = item.Name;
                dto.dob = item.dob;
                dto.CustomerName = item.CustomerName;
                crd.Add(dto);

            }
            return crd;
        }
        internal static void addCustomerRelation(CUSTOMER_RELATION customerRelation)
        {
            try
            {
                db.CUSTOMER_RELATIONs.InsertOnSubmit(customerRelation);
                db.SubmitChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
