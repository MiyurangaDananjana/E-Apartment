using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E_Apartments.DAL.DTO;

namespace E_Apartments.DAL.DAO
{
    public class Apartment_DAO : DbContext
    {
        internal static void Add_Apartment(APARTMENT apartmnt)
        {
            try
            {
                db.APARTMENTs.InsertOnSubmit(apartmnt);
                db.SubmitChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        internal static List<Apartment_Detail_DTO> GetApartmentDetail()
        {
            List<Apartment_Detail_DTO> add = new List<Apartment_Detail_DTO>();
            var list = (from APARTMENT in db.APARTMENTs
                        join apClass in db.APARTMENT_CLASSes on APARTMENT.CLASS_ID equals apClass.APARTMENT_CLASS_ID
                        join apName in db.APARTMENT_NAMEs on APARTMENT.APARTMENT_ID equals apName.AP_NAME_ID
                        select new
                        {
                            id = APARTMENT.ID,
                            apartmentName = apName.APARTMENT_NAME1,
                            location = APARTMENT.LOCATION,
                            apClass = apClass.CLASS_NAME,
                            flowArea=APARTMENT.FLOW_AREA,
                            apRent=APARTMENT.APPLICABLE_RENT,
                            apAmount = APARTMENT.APPLICABLE_AMOUNT,
                            apDepositAmount = APARTMENT.APPLICABLE_DEPOSIT_AMOUNT,
                            apMAx = APARTMENT.APPLICABLE_MAXIMUM_N_F_OCCUP,
                            apReFee = APARTMENT.APPLICABLE_RESERVATION_FEE,
                            NumbarAvailable =APARTMENT.NUMBER_AVAILABLE
                        });
            foreach(var item in list)
            {
                Apartment_Detail_DTO dto = new Apartment_Detail_DTO();
                dto.ID = item.id;
                dto.ApartmentName = item.apartmentName;
                dto.Location = item.location;
                dto.ClassName = item.apClass;
                dto.flowArea = item.flowArea;
                dto.applicableRent = item.apRent;
                dto.applicableAmount = item.apAmount;
                dto.applicableDepositAmount = item.apDepositAmount;
                dto.applicableMaxOccupation = item.apMAx;
                dto.ApplicableReservationFee = item.apReFee;
                dto.Numbaravailable = item.NumbarAvailable;
                add.Add(dto);

            }
            return add;
        }

        

        internal static void AddNewClass(APARTMENT_CLASS name)
        {
            try
            {
                db.APARTMENT_CLASSes.InsertOnSubmit(name);
                db.SubmitChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        internal static void AddApartmentName(APARTMENT_NAME name)
        {
            try
            {
                db.APARTMENT_NAMEs.InsertOnSubmit(name);
                db.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        internal static List<APARTMENT_NAME> GetApartmentName()
        {
            return db.APARTMENT_NAMEs.ToList();
        }

        internal static List<APARTMENT_CLASS> GetApartmentClass()
        {
            return db.APARTMENT_CLASSes.ToList();
        }

        internal static void DeleteApartment(int v)
        {
            APARTMENT ap = db.APARTMENTs.First(x => x.ID == v);
            db.APARTMENTs.DeleteOnSubmit(ap);
            db.SubmitChanges();
        }

        internal static void UpdateApartment(APARTMENT apartmnt)
        {
            try
            {
                APARTMENT ap = db.APARTMENTs.First(x => x.ID == apartmnt.ID);
                ap.APARTMENT_ID = apartmnt.APARTMENT_ID;
                ap.LOCATION = apartmnt.LOCATION;
                ap.CLASS_ID = apartmnt.CLASS_ID;
                ap.APARTMENT_ID = apartmnt.APARTMENT_ID;
                ap.FLOW_AREA = apartmnt.FLOW_AREA;
                ap.APPLICABLE_RENT = apartmnt.APPLICABLE_RENT;
                ap.APPLICABLE_AMOUNT = apartmnt.APPLICABLE_AMOUNT;
                ap.APPLICABLE_DEPOSIT_AMOUNT = apartmnt.APPLICABLE_DEPOSIT_AMOUNT;
                ap.APPLICABLE_MAXIMUM_N_F_OCCUP = apartmnt.APPLICABLE_MAXIMUM_N_F_OCCUP;
                ap.APPLICABLE_RESERVATION_FEE = apartmnt.APPLICABLE_RESERVATION_FEE;
                ap.NUMBER_AVAILABLE = apartmnt.NUMBER_AVAILABLE;
                
                db.SubmitChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
