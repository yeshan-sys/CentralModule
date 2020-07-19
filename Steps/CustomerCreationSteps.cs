using CentralModule.GetSet;
using CentralModule.Objects;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace CentralModule.Steps
{
    [Binding]
    public sealed class CustomerCreationSteps
    {
        /*
         * ********************************************************************
         * *******************************LOGIN********************************
         * ********************************************************************
         */

        [Given(@"I navigated to Login page")]
        public void GivenINavigatedToLoginPage()
        {
            WebDriver.driver = new ChromeDriver();
            WebDriver.driver.Manage().Window.Maximize();
            WebDriver.driver.Navigate().GoToUrl("http://centralqaweb/#/login");
            WebDriver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(25);
            Console.WriteLine("********************************************");

            Console.WriteLine("");
        }

        [Given(@"I have entered username (.*) and password (.*)")]
        public void GivenIHaveEnteredUsernameAndPassword(string username, string password)
        {
            Console.WriteLine("********************************************");
            //dynamic data = table.CreateDynamicInstance();
            Login login = new Login();
            login.EnterDataLogin(username, password);

            Console.WriteLine("");
        }

        [When(@"I press login  button")]
        public void WhenIPressLoginButton()
        {
            Console.WriteLine("********************************************");
            Login login = new Login();
            login.ClickLogin();

            Console.WriteLine("");
        }

        /*
         * ********************************************************************
         * *******************BUSINESS PARTNER CREATION************************
         * ********************************************************************
         */

        [Then(@"Navigate to Customer Registration")]
        public void ThenNavigateToCustomerRegistration()
        {
            Console.WriteLine("********************************************");
            Navigation navigate = new Navigation();
            navigate.CustomerCreation();

            Console.WriteLine("");
        }
      


        [Then(@"I filled the Basic informations (.*),(.*),(.*),(.*),(.*),(.*)")]
        public void ThenIFilledTheBasicInformations(string nic, string date, string firstName, string middleName, string lastName, string placeOfBirth)
        {
            Console.WriteLine("********************************************");
            //dynamic data = table.CreateDynamicInstance();
            BSPBasicInformations bspInfo = new BSPBasicInformations();
            bspInfo.FillMandatoryData(nic, date, firstName, middleName, lastName, placeOfBirth);

            Console.WriteLine("");
        }

        [Then(@"I filled and added the (.*),(.*),(.*) Contact Information (.*)")]
        public void ThenIFilledAndAddedTheContactInformation(string addFirst, string addSec, string addThird, Int64 TelNo)
        {
            Console.WriteLine("********************************************");
            //dynamic data = table.CreateDynamicInstance();
            BSPContactInformation bspContact = new BSPContactInformation();
            bspContact.FillContactDetails(addFirst, addSec, addThird, TelNo);

            Console.WriteLine("");
        }

        [Then(@"I filled and added the comman tab (.*),(.*),(.*) data")]
        public void ThenIFilledAndAddedTheCommanTabData(int km, int m, int cost)
        {
            Console.WriteLine("********************************************");
            //dynamic data = table.CreateDynamicInstance();
            BSPTransportInformation bspTransport = new BSPTransportInformation();
            bspTransport.FillCommonDetails(km,m,cost);

            Console.WriteLine("");
        }

        [Then(@"I add a Attachment (.*)")]
        public void ThenIAddAAttachment(string attachment)
        {
            Console.WriteLine("********************************************");
            BSPAttchment attachments = new BSPAttchment();
            attachments.AttachFile(attachment);

            Console.WriteLine("");
        }

        [When(@"I clicked on the save button")]
        public void WhenIClickedOnTheSaveButton()
        {
            Console.WriteLine("********************************************");
            BSPAttchment attachment = new BSPAttchment();
            attachment.SaveBusinessPartner();

            Console.WriteLine("");
        }

        [Then(@"Saved DB data is displayed (.*)")]
        public void ThenSavedDBDataIsDsiplayed(string nic)
        {
            Console.WriteLine("********************************************");
            //dynamic data = table.CreateDynamicInstance();
            DBTestData dbData = new DBTestData();
            dbData.NewCreatedCustomerData(nic);

            Console.WriteLine("");
        }
        [When(@"I navigated to WorkBench")]
        public void WhenINavigatedToWorkBench()
        {
            Console.WriteLine("********************************************");
            Navigation workbenchCompleted = new Navigation();
            workbenchCompleted.WorkBenchCompleted();

            Console.WriteLine("");
        }

        [Then(@"Verify the workflow data (.*)")]
        public void ThenVerifyTheWorkflowData(string nic)
        {
            Console.WriteLine("********************************************");
            //dynamic data = table.CreateDynamicInstance();
            WorkBench completed = new WorkBench();
            completed.GetBspId(nic);

            Console.WriteLine("");
        }

        [Then(@"Logout from the system")]
        public void ThenLogoutFromTheSystem()
        {
            Console.WriteLine("********************************************");
            Login logout = new Login();
            logout.Logout();
            Thread.Sleep(2000);
            Actions close = new Actions(WebDriver.driver);           
            WebDriver.driver.Quit();

            Console.WriteLine("");
        }

        /*
         * ********************************************************************
         * *******************BUSINESS PARTNER UPDATE**************************
         * ********************************************************************
         */

        [Then(@"Navigate to Customer Inquiry page")]
        public void ThenNavigateToCustomerInquiryPage()
        {
            Console.WriteLine("********************************************");
            Navigation customerInquiry = new Navigation();
            customerInquiry.CustomerInquiry();

            Console.WriteLine("");
        }

        [Then(@"Search for a business partner to update (.*)")]
        public void ThenSearchForABusinessPartnerToUpdateV(string nic)
        {
            Console.WriteLine("********************************************");
            BSPUpdateBasicInfor searchBSP = new BSPUpdateBasicInfor();
            searchBSP.SearchBusinessPartner(nic);

            Console.WriteLine("");
        }

        [Then(@"I Updated name (.*), (.*), (.*) and Place of birth (.*)")]
        public void ThenIUpdatedNameBhanukaSandaruwanPereraAndPlaceOfBirthMatara(string firstName, string secName, string thirName, string birthPlace)
        {
            Console.WriteLine("********************************************");
            BSPUpdateBasicInfor BSPBasic = new BSPUpdateBasicInfor();
            BSPBasic.UpdateBasicDetails(firstName, secName, thirName, birthPlace);

            Console.WriteLine("");
        }

        [Then(@"I Updated the business partner address and  (.*), (.*), (.*), changed Contact Information (.*)")]
        public void ThenIUpdatedTheBusinessPartnerAddressAndJennyPamburanaPallawaChangedContactInformation(string addFirst, string addSec, string addThird, Int64 TelNo)
        {
            Console.WriteLine("********************************************");
            BSPUpdateBasicInfor contact = new BSPUpdateBasicInfor();
            contact.UpdateContactDetails(addFirst, addSec, addThird, TelNo);

            Console.WriteLine("");

        }

        [Then(@"I added a new transport detail (.*), (.*), (.*) data")]
        public void ThenIAddedANewTransportDetailData(string km, string m, string cost)
        {
            Console.WriteLine("********************************************");
            BSPUpdateBasicInfor transport = new BSPUpdateBasicInfor();
            transport.UpdateCommonDetails();

            Console.WriteLine("");
        }

        [Then(@"I added a Attachment (.*)")]
        public void ThenIAddedAAttachment(string attach)
        {
            Console.WriteLine("********************************************");
            BSPUpdateBasicInfor attachment = new BSPUpdateBasicInfor();
            attachment.UpdateFinalStepDetails(attach);

            Console.WriteLine("");
        }       

        [When(@"I clicked on the save button for Update business partner")]
        public void WhenIClickedOnTheSaveButtonForUpdateBusinessPartner()
        {
            Console.WriteLine("********************************************");
            BSPUpdateBasicInfor save = new BSPUpdateBasicInfor();
            save.SaveBusinessPartner();

            Console.WriteLine("");
        }
    
        [When(@"I navigated to WorkBench Incompleted Activities")]
        public void WhenINavigatedToWorkBenchIncompletedActivities()
        {
            Console.WriteLine("********************************************");
            Navigation incompleted = new Navigation();
            incompleted.WorkBenchIncompleted();

            Console.WriteLine("");
        }

        [Then(@"Verify the Workflow data for updated business partner (.*)")]
        public void ThenVerifyTheWorkflowDataForUpdatedBusinessPartnerV(string nic)
        {
            Console.WriteLine("********************************************");
            WorkBench incompleted = new WorkBench();
            incompleted.CheckIncompletedBusinessPartner(nic);

            Console.WriteLine("");
        }

        [Then(@"Navigate Workbench to approve the Updated Business Partner")]
        public void ThenNavigateWorkbenchToApproveTheUpdatedBusinessPartner()
        {
            Console.WriteLine("********************************************");
            Navigation approval = new Navigation();
            approval.WorkBenchApproval();

            Console.WriteLine("");
        }

        [Then(@"Verify the Updated Business Partner Details in Approvals tab of Workbench (.*)")]
        public void ThenVerifyTheUpdatedBusinessPartnerDetailsInApprovalsTabOfWorkbenchV(string nic)
        {
            Console.WriteLine("********************************************");
            WorkBench approval = new WorkBench();
            approval.CheckApprovalBusinessPartner(nic);

            Console.WriteLine("");
        }

        [Then(@"Approve the Updated Business Partner (.*)")]
        public void ThenApproveTheUpdatedBusinessPartner(string comment)
        {
            Console.WriteLine("********************************************");
            WorkBench approval = new WorkBench();          
            approval.ApproveInCentral(comment);

            Console.WriteLine("");
        }

        [Then(@"Verify the Business Partner Details in Completed Activities (.*)")]
        public void ThenVerifyTheBusinessPartnerDetailsInCompletedActivitiesV(string nic)
        {
            Console.WriteLine("********************************************");
            Navigation complete = new Navigation();
            complete.CompletedCentral();
            WorkBench Completed = new WorkBench();
            Completed.GetBspId(nic);

            Console.WriteLine("");
        }

        [Then(@"Verify the DB updated data of Updated Busines Partner (.*)")]
        public void ThenVerifyTheDBUpdatedDataOfUpdatedBusinesPartnerV(string nic)
        {
            Console.WriteLine("********************************************");
            DBTestData updatedData = new DBTestData();
            updatedData.UpdatedCustomerData(nic);

            Console.WriteLine("");

        }

        [Then(@"Verify the Business Partner Update Details in Completed Activities (.*)")]
        public void ThenVerifyTheBusinessPartnerUpdateDetailsInCompletedActivitiesV(string nic)
        {
            Console.WriteLine("********************************************");

            WorkBench Completed = new WorkBench();
            Completed.GetBspId(nic);

            Console.WriteLine("");
            Console.WriteLine("********************************************");
        }


        /*
         * ********************************************************************
         * ************************COMPANY CREATION****************************
         * ********************************************************************
         */

        [Then(@"Navigate to Company Registration")]
        public void ThenNavigateToCompanyRegistration()
        {
            Console.WriteLine("********************************************");
            Navigation navigate = new Navigation();
            navigate.CompanyCreation();

            Console.WriteLine("");
        }

        [Then(@"I filled the Basic informations of Company Registration (.*),(.*), (.*)")]
        public void ThenIFilledTheBasicInformationsOfCompanyRegistrationMAAAKASUNTRADERSJOHN(string br, string name, string othername)
        {
            Console.WriteLine("********************************************");
            CompanyCreationBasic basic = new CompanyCreationBasic();
            basic.FillBasicInformation(br, name, othername);

            Console.WriteLine("");
        }

        [Then(@"I filled and added the Contact Details of Company (.*), (.*), (.*), (.*)")]
        public void ThenIFilledAndAddedTheContactDetailsOfCompany(string address1, string address2, string address3, Int64 telNo)
        {
            Console.WriteLine("********************************************");
            CompanyCreationContact contact = new CompanyCreationContact();
            contact.FillContactDetails(address1, address2, address3, telNo);

            Console.WriteLine("");
        }

        [Then(@"I filled and added the comman details of Company (.*), (.*), (.*), (.*)")]
        public void ThenIFilledAndAddedTheCommanDetailsOfCompanyVSCONDOFFICER(string nic, string description, string shares, string voting)
        {
            Console.WriteLine("********************************************");
            CompanyCreationCommon common = new CompanyCreationCommon();
            common.FilltheCommonDetails(nic, description, shares, voting);

            Console.WriteLine("");
        }

        [Then(@"I add a Attachments for Company (.*)")]
        public void ThenIAddAAttachmentsForCompanyCUsersChamikayPicturesScreenshotsProductCreationAbc_Png(string brAttachment)
        {
            Console.WriteLine("********************************************");
            CompanyCreationOther other = new CompanyCreationOther();
            other.AddAttahcment(brAttachment);

            Console.WriteLine("");
        }

        [When(@"I Saved the Company")]
        public void WhenISavedTheCompany()
        {
            Console.WriteLine("********************************************");
            CompanyCreationOther other = new CompanyCreationOther();
            other.SaveCompany();

            Console.WriteLine("");
        }

        [Then(@"Saved Date is displayed for Company (.*)")]
        public void ThenSavedDateIsDisplayedForCompanyMAAA(string p0)
        {
            
        }

        [Then(@"Verified that Comapny DB data in Completed Activities of Workbench (.*)")]
        public void ThenVerifiedThatComapnyDBDataInCompletedActivitiesOfWorkbenchMAAA(string br)
        {
            WorkBench completed = new WorkBench();
            completed.CompanyCompletedActivities(br);
        }


        /*
         * ********************************************************************
         * ************************STATUS MAINTENANCE**************************
         * ********************************************************************
         */

        [Then(@"Navigate Status Maintenance")]
        public void ThenNavigateStatusMaintenance()
        {
            Console.WriteLine("********************************************");
            Navigation StatusMaintenance = new Navigation();
            StatusMaintenance.StatusMaintainance();

            Console.WriteLine("");
        }

        [Then(@"Search business partner for Change the status (.*)")]
        public void ThenSearchBusinessPartnerForChangeTheStatusV(string nic)
        {
            Console.WriteLine("********************************************");
            StatusMaintenance ChangeStatus = new StatusMaintenance();
            ChangeStatus.SearchForChangeStatus(nic);

            Console.WriteLine("");
        }

        [Then(@"Change the business partner status (.*), (.*)")]
        public void ThenChangeTheBusinessPartnerStatus(string description, string attach)
        {
            Console.WriteLine("********************************************");
            StatusMaintenance ChangeStatus = new StatusMaintenance();
            ChangeStatus.ChangeStatus(description, attach);

            Console.WriteLine("");
        }

        [Then(@"save the data of changed status")]
        public void ThenSaveTheDataOfChangedStatus()
        {
            Console.WriteLine("********************************************");
            StatusMaintenance ChangeStatus = new StatusMaintenance();
            ChangeStatus.SaveStatus();

            Console.WriteLine("");
        }

        [Then(@"Verify the Business Partner details in Incompleted Workbench (.*)")]
        public void ThenVerifyTheBusinessPartnerDetailsInIncompletedWorkbenchV(string nic)
        {
            Console.WriteLine("********************************************");
            Navigation IncompletedWorkbench = new Navigation();
            IncompletedWorkbench.WorkBenchIncompleted();

            WorkBench CheckIncompletedBSDData = new WorkBench();
            CheckIncompletedBSDData.CheckIncompletedBusinessPartner(nic);          

            Console.WriteLine("");
        }


        [Then(@"Navigate Workbench to approve the status changed Business Partner")]
        public void ThenNavigateWorkbenchToApproveTheStatusChangedBusinessPartner()
        {
            Console.WriteLine("********************************************");
            Navigation ApproveWorkbench = new Navigation();
            ApproveWorkbench.WorkBenchApproval();

            Console.WriteLine("");
        }

        [Then(@"Verify the Business Partner Details in Approvals tab of Workbench (.*)")]
        public void ThenVerifyTheBusinessPartnerDetailsInApprovalsTabOfWorkbenchV(string nic)
        {
            Console.WriteLine("********************************************");
            WorkBench ApproveStatusChanged = new WorkBench();
            ApproveStatusChanged.ApprovalChangedStatus(nic);

            Console.WriteLine("");
        }

        [Then(@"Approve the status changed Business Partner (.*)")]
        public void ThenApproveTheStatusChangedBusinessPartner(string comment)
        {
            Console.WriteLine("********************************************");
            WorkBench ApproveStatusChanged = new WorkBench();
            ApproveStatusChanged.ChangeStatusBusinessPartner(comment);

            Console.WriteLine("");
        }

        [Then(@"Navigate to Completed Activities")]
        public void ThenNavigateToCompletedActivities()
        {
            Navigation Completed = new Navigation();
            Completed.CompletedCentral();
        }


        [Then(@"Verify Completed Activities (.*)")]
        public void ThenVerifyCompletedActivitiesV(string nic)
        {
            Console.WriteLine("********************************************");

            WorkBench Completed = new WorkBench();
            Completed.CompletedActivies(nic);

            Console.WriteLine("");
            Console.WriteLine("********************************************");
        }


        [Then(@"Verify the DB Business Partner staus (.*)")]
        public void ThenVerifyTheDBBusinessPartnerStausV(string nic)
        {
            Console.WriteLine("********************************************");
            DBTestData ChangeStatus = new DBTestData();
            ChangeStatus.ChangedStatusBusinessPartner(nic);

            Console.WriteLine("");
        }

        /*
         * ********************************************************************
         * ************************NOTE MAINTENANCE****************************
         * ********************************************************************
         */

        [Then(@"Navigate Note Maintenance")]
        public void ThenNavigateNoteMaintenance()
        {
            Console.WriteLine("********************************************");
            Navigation NoteMaintenance = new Navigation();
            NoteMaintenance.NoteMaintenance();

            Console.WriteLine("");
        }

        [Then(@"Search for a Business Partner for add a Note (.*)")]
        public void ThenSearchForABusinessPartnerForAddANoteV(string nic)
        {
            Console.WriteLine("********************************************");
            NoteMaintenance Note = new NoteMaintenance();
            Note.SearchBusinessPartner(nic);

            Console.WriteLine("");
        }

        [Then(@"Add the Note for the Business Partner (.*)")]
        public void ThenAddTheNoteForTheBusinessPartner(string note)
        {
            Console.WriteLine("********************************************");
            NoteMaintenance Note = new NoteMaintenance();
            Note.SaveAddNote(note);

            Console.WriteLine("");
        }
        
        [Then(@"Verify the DB for newly added note of Business Partner (.*)")]
        public void ThenVerifyTheDBForNewlyAddedNoteOfBusinessPartnerV(string nic)
        {
            Console.WriteLine("********************************************");
            DBTestData Note = new DBTestData();
            Note.NoteMaintenance(nic);
            Console.WriteLine("********************************************");

            Console.WriteLine("");
        }
        
    }
}
