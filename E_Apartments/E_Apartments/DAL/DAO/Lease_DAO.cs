using E_Apartments.DAL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Apartments.DAL.DAO
{
    public class Lease_DAO : DbContext
    {
        internal static void Add_Lease(APARTMENT_LEASE al)
        {
            try
            {
                db.APARTMENT_LEASEs.InsertOnSubmit(al);
                db.SubmitChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        internal static List<PAYMENT_METHOD> Get_Payment_Method()
        {
            return db.PAYMENT_METHODs.ToList();
        }

        internal static List<Lease_DTO_Detail> Get_Apartment_Lease_Request(int states)
        {
            List<Lease_DTO_Detail> Lease_list = new List<Lease_DTO_Detail>();
            var list = (from lease in db.APARTMENT_LEASEs
                        where lease.STATES == states
                        join custame_detail in db.SYSTEM_USERS_DETAILs on lease.CUSTOMER_ID equals custame_detail.ID
                        join apartment in db.APARTMENTs on lease.APARTMENT_ID equals apartment.ID
                        join apartment_name in db.APARTMENT_NAMEs on apartment.APARTMENT_ID equals apartment_name.AP_NAME_ID
                        join paymentmethod in db.PAYMENT_METHODs on lease.PAYMENT_TYPE_ID equals paymentmethod.ID
                        // join Create_By in db.SYSTEM_USERS_DETAILs on lease.CREATE_BY equals Create_By.CREATE_EMP_ID
                        select new
                        {
                            ID = lease.ID,
                            Custome_ID = lease.CUSTOMER_ID,
                            Customer_Name = custame_detail.FULL_NAME,
                            Customer_NIC = custame_detail.NIC,
                            Apartment_ID = lease.APARTMENT_ID,
                            Apartment_Location = apartment.LOCATION,
                            Apartment_Name = apartment_name.APARTMENT_NAME1,
                            Parking_Space_ID = lease.PARKING_SPACE_ID,
                            E_P_Space = lease.PARKING_SPACE_EXTRA_ID,
                            Extra_Parking_Space_Rental = lease.PARKING_SPACE_EXTRA_MONTHLY_RENTAL,
                            Monthly_Rental = apartment.APPLICABLE_RENT,
                            Deposite_Amount = lease.DEPOSITE_AMOUNT,

                            Start_Date = lease.LEASE_START_DATE,
                            End_Date = lease.END_DATE,
                            PaymentMethod = paymentmethod.PAYMENT_TYPE,

                            Create_Date = lease.CREATE_DATE,

                            Months = lease.TOTALE_MONTHS
                        });
            foreach (var item in list)
            {
                Lease_DTO_Detail dto = new Lease_DTO_Detail();
                dto.ID = item.ID;
                dto.Customer_ID = item.Custome_ID;
                dto.Customer_Name = item.Customer_Name;
                dto.Customer_NIC = item.Customer_NIC;
                dto.Apartment_ID = item.Apartment_ID;
                dto.Apartment_Location = item.Apartment_Location;
                dto.Apartment_Name = item.Apartment_Name;
                dto.Parking_Space_ID = item.Parking_Space_ID;
                dto.Extra_Parking_Space_ID = item.E_P_Space;
                dto.Extra_Parking_Space_Rental = item.Extra_Parking_Space_Rental;
                dto.Monthly_Rental = item.Monthly_Rental;
                dto.Deposite_Amount = item.Deposite_Amount;
                dto.Start_Date = item.Start_Date;
                dto.End_Date = item.End_Date;
                dto.Payment_Method = item.PaymentMethod;

                dto.Create_Date = item.Create_Date;
                dto.Months = item.Months;
                Lease_list.Add(dto);
            }
            return Lease_list;
        }

     

    internal static void Receipt(PAYMENT pay)
    {
        try
        {
            db.PAYMENTs.InsertOnSubmit(pay);
            db.SubmitChanges();
        }
        catch (Exception ex)
        {

            throw ex;
        }
    }

    internal static void UpdateMonth(APARTMENT_LEASE aprtment_lease)
    {
        try
        {
            APARTMENT_LEASE update = db.APARTMENT_LEASEs.First(x => x.ID == aprtment_lease.ID);
            update.TOTALE_MONTHS = aprtment_lease.TOTALE_MONTHS;
            db.SubmitChanges();
        }
        catch (Exception ex)
        {

            throw ex;
        }
    }

    internal static void Update_Aprove(APARTMENT_LEASE al)
    {
        try
        {
            APARTMENT_LEASE apartmentLase = db.APARTMENT_LEASEs.First(x => x.ID == al.ID);
            apartmentLase.STATES = al.STATES;
            apartmentLase.APPROVED_BY = al.APPROVED_BY;
            apartmentLase.APPROVED_DATE = al.APPROVED_DATE;
            db.SubmitChanges();
        }
        catch (Exception ex)
        {

            throw ex;
        }
    }
}
}
