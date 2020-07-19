using CentralModule.GetSet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace CentralModule.Objects
{
   class DBTestData : DBConnection
    {
        public void NewCreatedCustomerData(string nic)
        {
            Console.WriteLine("New Customer is Created");
            Console.WriteLine("DB saved data:");
            Console.WriteLine("");

            SQLConnectionDetails();
            /*
             * *********************************
             * msd.BusinessPartner Table details
             * *********************************
             */
            query = "SELECT * FROM msd.BusinessPartner " +
                                       "WHERE NICNo ='" + nic + "'";
            DataAdapterDetails();
            rowCount = DataSetDetails();
            
            if (rowCount > 0)
            {
                int Id = int.Parse(RowsValue(0, 0));
                Console.WriteLine("###############################");
                Console.WriteLine("Id------------------->:" + RowsValue(0, 0));
                Console.WriteLine("Code----------------->:" + RowsValue(0, 1));
                Console.WriteLine("First Name----------->:" + RowsValue(0, 6));
                Console.WriteLine("Middle Name---------->:" + RowsValue(0, 7));
                Console.WriteLine("Last Name------------>:" + RowsValue(0, 8));
                Console.WriteLine("Name with Initials--->:" + RowsValue(0, 9));
                Console.WriteLine("Gender--------------->:" + RowsValue(0, 10));
                Console.WriteLine("NIC Number----------->:" + RowsValue(0, 11));
                Console.WriteLine("NIC Issues Date------>:" + RowsValue(0, 12));
                Console.WriteLine("Date of Birth-------->:" + RowsValue(0, 13));
                Console.WriteLine("Place of Birth------->:" + RowsValue(0, 14));
                Console.WriteLine("Created Date Time---->:" + RowsValue(0, 35));

                /*
                 * ****************************************
                 * msd.BusinessPartnerAddress Table details
                 * ****************************************
                 */
                query = "SELECT * FROM msd.BusinessPartnerAddress " +
                                           "WHERE BusinessPartnerId ='" + Id + "' ORDER BY CreatedDateTime DESC";
                DataAdapterDetails();
                rowCount = DataSetDetails();

                if (rowCount > 0)
                {
                    Console.WriteLine("");
                    Console.WriteLine("###############################");
                    Console.WriteLine("Business Partner Id-->:" + RowsValue(0, 1));
                    Console.WriteLine("Address1------------->:" + RowsValue(0, 2));
                    Console.WriteLine("Address2------------->:" + RowsValue(0, 3));
                    Console.WriteLine("Address3------------->:" + RowsValue(0, 4));
                    Console.WriteLine("Created Date Time---->:" + RowsValue(0, 12));                   
                }
                else
                {
                    Console.WriteLine("Business Partner Address is not saved on Database !");
                }
            }
            else
            {
                Console.WriteLine("Business Partner is not saved on Database !");
            }           
        }

        public void UpdatedCustomerData(string nic)
        {
            Console.WriteLine("New Customer is Updated");
            Console.WriteLine("DB saved data:");
            Console.WriteLine("");

            SQLConnectionDetails();
            /*
             * *********************************
             * msd.BusinessPartner Table details
             * *********************************
             */
            query = "SELECT * FROM msd.BusinessPartner " +
                                       "WHERE NICNo ='" + nic + "'";
            DataAdapterDetails();
            rowCount = DataSetDetails();

            if (rowCount > 0)
            {
                int Id = int.Parse(RowsValue(0, 0));
                Console.WriteLine("###############################");
                Console.WriteLine("Id------------------->:" + RowsValue(0, 0));
                Console.WriteLine("Code----------------->:" + RowsValue(0, 1));
                Console.WriteLine("First Name----------->:" + RowsValue(0, 6));
                Console.WriteLine("Middle Name---------->:" + RowsValue(0, 7));
                Console.WriteLine("Last Name------------>:" + RowsValue(0, 8));
                Console.WriteLine("Name with Initials--->:" + RowsValue(0, 9));
                Console.WriteLine("Gender--------------->:" + RowsValue(0, 10));
                Console.WriteLine("NIC Number----------->:" + RowsValue(0, 11));
                Console.WriteLine("NIC Issues Date------>:" + RowsValue(0, 12));
                Console.WriteLine("Date of Birth-------->:" + RowsValue(0, 13));
                Console.WriteLine("Place of Birth------->:" + RowsValue(0, 14));
                Console.WriteLine("Created Date Time---->:" + RowsValue(0, 35));

                /*
                 * ****************************************
                 * msd.BusinessPartnerAddress Table details
                 * ****************************************
                 */
                query = "SELECT * FROM msd.BusinessPartnerAddress " +
                                           "WHERE BusinessPartnerId ='" + Id + "' ORDER BY CreatedDateTime DESC";
                DataAdapterDetails();
                rowCount = DataSetDetails();

                if (rowCount > 0)
                {
                    Console.WriteLine("");
                    Console.WriteLine("###############################");
                    Console.WriteLine("Business Partner Id-->:" + RowsValue(0, 1));
                    Console.WriteLine("Address1------------->:" + RowsValue(0, 2));
                    Console.WriteLine("Address2------------->:" + RowsValue(0, 3));
                    Console.WriteLine("Address3------------->:" + RowsValue(0, 4));
                    Console.WriteLine("Created Date Time---->:" + RowsValue(0, 12));
                }
                else
                {
                    Console.WriteLine("Business Partner Address is not saved on Database !");
                }
            }
            else
            {
                Console.WriteLine("Business Partner is not saved on Database !");
            }
        }

        public void ChangedStatusBusinessPartner(string nic)
        {
            Console.WriteLine("Business Partner Status is Changed");
            Console.WriteLine("DB saved data:");
            Console.WriteLine("");

            SQLConnectionDetails();
            /*
             * *********************************
             * msd.BusinessPartner Table details
             * *********************************
             */
            query = "SELECT BP.Code,NameWithInitials,NICNo,mpt_BusinessPartnerStatusEnum, Description " +
                "FROM msd.businesspartner BP " +
                "INNER JOIN EclipseQA.msd.vw_BusinessPartnerStatus BPS " +
                "ON BP.mpt_BusinessPartnerStatusEnum = BPS.Data " +
                "WHERE NICNo = '" + nic + "'";
 
            DataAdapterDetails();
            rowCount = DataSetDetails();

            if (rowCount > 0)
            {
                Console.WriteLine("");
                Console.WriteLine("###############################");
                Console.WriteLine("Business Partner Code---------->:" + RowsValue(0, 0));
                Console.WriteLine("Name with Initials------------->:" + RowsValue(0, 1));
                Console.WriteLine("NIC Number--------------------->:" + RowsValue(0, 2));
                Console.WriteLine("mpt_BusinessPartnerStatusEnum-->:" + RowsValue(0, 3));
                Console.WriteLine("Description-------------------->:" + RowsValue(0, 4));
            }
            else
            {
                Console.WriteLine("###############################");
                Console.WriteLine("Invalid Business Partner");
            }
        }

        public void NoteMaintenance(string nic)
        {
            Console.WriteLine("Added a new Note to the Business Partner");
            Console.WriteLine("DB saved data:");
            Console.WriteLine("");

            SQLConnectionDetails();
            /*
             * *********************************
             * msd.BusinessPartner Table details
             * *********************************
             */
            query = "SELECT ReferenceId,Code,NICNo,NameWithInitials,Description " +
                    "FROM msd.businesspartner BP " +
                    "INNER JOIN msd.Note NT " +
                    "ON BP.Id = NT.ReferenceId " +
                    "WHERE NICNo = '" + nic + "'";

            DataAdapterDetails();
            rowCount = DataSetDetails();

            if (rowCount > 0)
            {
                Console.WriteLine("");
                Console.WriteLine("###############################");
                Console.WriteLine("Business Partner Refference ID---->:" + RowsValue(0, 0));
                Console.WriteLine("Business Partner Code------------->:" + RowsValue(0, 1));
                Console.WriteLine("NIC Number------------------------>:" + RowsValue(0, 2));
                Console.WriteLine("Name iwth Initials---------------->:" + RowsValue(0, 3));
                Console.WriteLine("Description----------------------->:" + RowsValue(0, 4));
            }
            else
            {
                Console.WriteLine("###############################");
                Console.WriteLine("Note is not Added to the Business Partner");
            }

        }
    }
}
