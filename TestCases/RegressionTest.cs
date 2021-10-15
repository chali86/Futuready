using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using OpenQA.Selenium;
using Futuready_Automation.Pages;
using Futuready_Automation.Utils;
using System.Configuration;
using System.IO;
using System.Reflection;
using System.Threading;

namespace Futuready_Automation
{
    [TestClass]
    public class RegressionTest
    {
        IWebDriver WebDriver;
        private TestContext testContextInstance;
        private const int timeout = 60000 * 30;

        #region Thailand Project Test Cases

        [TestMethod]
        [TestProperty("TestCaseID", "00001")]
        [TestCategory("RegressionTest")]
        [Timeout(timeout)]
        [TestProperty("TestCaseTitle", "[TH] Login To Freiends App")]
        public void LoginToFreiendsApp()
        {
            Login login = new Login(Utils.Enum.URLType.Landing, Utils.Enum.UserRole.Manager);
            WebDriver = login.LaunchWebDriver();
            login.LogintoWebsite(WebDriver);
            WebDriver.Dispose();
        }

        [TestMethod]
        [TestProperty("TestCaseID", "00002")]
        [TestCategory("RegressionTest")]
        [Timeout(timeout)]
        [TestProperty("TestCaseTitle", "[TH] Select Covid-19 Product")]
        public void SelectCovid19Product()
        {
            Login login = new Login(Utils.Enum.URLType.Landing, Utils.Enum.UserRole.Manager);
            WebDriver = login.LaunchWebDriver();
            login.LogintoWebsite(WebDriver);
            Thread.Sleep(5000);
            Dashboard dashboard = new Dashboard(WebDriver);
            Plan plan = new Plan(WebDriver);
            dashboard.ClickCovid19();
            plan.SelectDateOfBirth();
            plan.ClickSearchPlan();
            plan.SelectPlan();
            WebDriver.Dispose();
        }

        [TestMethod]
        [TestProperty("TestCaseID", "00003")]
        [TestCategory("RegressionTest")]
        [Timeout(timeout)]
        [TestProperty("TestCaseTitle", "[TH] Enter Customer Details")]
        public void EnterCustomerDetails()
        {
            Login login = new Login(Utils.Enum.URLType.Landing, Utils.Enum.UserRole.Manager);
            WebDriver = login.LaunchWebDriver();
            login.LogintoWebsite(WebDriver);
            Thread.Sleep(5000);
            Dashboard dashboard = new Dashboard(WebDriver);
            Plan plan = new Plan(WebDriver);
            dashboard.ClickCovid19();
            plan.SelectDateOfBirth();
            plan.ClickSearchPlan();
            plan.SelectPlan();
            ProspectDetail prospectDetail = new ProspectDetail(WebDriver);
            prospectDetail.AddDetails();
            prospectDetail.ClickRefer();
            WebDriver.Dispose();
        }

        [TestMethod]
        [TestProperty("TestCaseID", "00004")]
        [TestCategory("RegressionTest")]
        [Timeout(timeout)]
        [TestProperty("TestCaseTitle", "[TH] Customer Received Order Request By Email")]
        public void CustomerReceivedOrderRequestByEmail()
        {
            Login login = new Login(Utils.Enum.URLType.Landing, Utils.Enum.UserRole.Manager);
            WebDriver = login.LaunchWebDriver();
            login.LogintoWebsite(WebDriver);
            Thread.Sleep(5000);
            Dashboard dashboard = new Dashboard(WebDriver);
            Plan plan = new Plan(WebDriver);
            dashboard.ClickCovid19();
            plan.SelectDateOfBirth();
            plan.ClickSearchPlan();
            plan.SelectPlan();
            ProspectDetail prospectDetail = new ProspectDetail(WebDriver);
            prospectDetail.AddDetails();
            prospectDetail.ClickRefer();
            WebDriver.Dispose();

            Login login1 = new Login(Utils.Enum.URLType.TrialBase, Utils.Enum.UserRole.EmailUser);
            WebDriver = login1.LaunchWebDriver();
            login1.LogintoGmail(WebDriver);
            ReadEmail readEmail = new ReadEmail(WebDriver);
            readEmail.SelectEmail();
            readEmail.ClickProceedButton();
            Thread.Sleep(5000);

            Extension.WaitforPageLoad(WebDriver);
            Extension.SwitchTab(WebDriver);
            readEmail.ClickInboxButton();
            readEmail.DeleteFirstEmail();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            WebDriver.Close();
            Extension.SwitchTab(WebDriver);

            Plan plan1 = new Plan(WebDriver);
            plan1.ClickConfirmPlan();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            Application application = new Application(WebDriver);
            application.FillApplication();
            WebDriver.Dispose();
        }

        [TestMethod]
        [TestProperty("TestCaseID", "00005")]
        [TestCategory("RegressionTest")]
        [Timeout(timeout)]
        [TestProperty("TestCaseTitle", "[TH] End to End Testing")]
        public void EndToEndTestCase()
        {
            IWebDriver WebDriver1;
            Login login = new Login(Utils.Enum.URLType.Landing, Utils.Enum.UserRole.Manager);
            WebDriver = login.LaunchWebDriver();
            login.LogintoWebsite(WebDriver);
            Thread.Sleep(5000);
            Dashboard dashboard = new Dashboard(WebDriver);
            Plan plan = new Plan(WebDriver);
            dashboard.ClickCovid19();
            plan.SelectDateOfBirth();
            plan.ClickSearchPlan();
            plan.SelectPlan();
            ProspectDetail prospectDetail = new ProspectDetail(WebDriver);
            prospectDetail.AddDetails();
            prospectDetail.ClickRefer();
            WebDriver.Dispose();

            Login login1 = new Login(Utils.Enum.URLType.TrialBase, Utils.Enum.UserRole.EmailUser);
            WebDriver = login1.LaunchWebDriver();
            login1.LogintoGmail(WebDriver);
            ReadEmail readEmail = new ReadEmail(WebDriver);
            readEmail.SelectEmail();
            readEmail.ClickProceedButton();
            Thread.Sleep(5000);

            Extension.WaitforPageLoad(WebDriver);
            Extension.SwitchTab(WebDriver);
            readEmail.ClickInboxButton();
            readEmail.DeleteFirstEmail();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            WebDriver.Close();
            Extension.SwitchTab(WebDriver);

            Plan plan1 = new Plan(WebDriver);
            plan1.ClickConfirmPlan();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            Application application = new Application(WebDriver);
            application.FillApplication();
            application.FillOtherDetails();
            application.ClickNextandConfirm();

            Login login2 = new Login(Utils.Enum.URLType.TrialBase, Utils.Enum.UserRole.EmailUser);
            WebDriver1 = login2.LaunchWebDriver();
            login2.LogintoGmail(WebDriver1);
            ReadEmail readEmail1 = new ReadEmail(WebDriver1);
            readEmail1.SelectOTPEmail();
            Thread.Sleep(10000);
            string OTPNumber = readEmail1.GetOTPNumber();
            readEmail1.ClickInboxButton();
            readEmail1.DeleteFirstEmail();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            WebDriver1.Dispose();

            application.CompleteOTPNo(OTPNumber);
            application.ClickSubmitButton();
            Health health = new Health(WebDriver);
            health.FillHealthQuestionnaire();
            health.ClickNextStep();
            Extension.WaitforPageLoad(WebDriver);
            Thread.Sleep(TimeSpan.FromSeconds(15));
            Extension.ScrollDown(WebDriver);
            health.ClickNextStep();

            UploadDocument uploadDocument = new UploadDocument(WebDriver);
            uploadDocument.UploadIDCard();
            Extension.ScrollDown(WebDriver);
            uploadDocument.ClickNextStep();
            Extension.WaitforPageLoad(WebDriver);

            PaymentPage paymentPage = new PaymentPage(WebDriver);
            Thread.Sleep(TimeSpan.FromSeconds(20));
            paymentPage.ClickPaymentMethod();
            Extension.WaitforPageLoad(WebDriver);
            Thread.Sleep(TimeSpan.FromSeconds(20));
            paymentPage.FillCardDetails();
            paymentPage.ClickContinuePayment();
            Thread.Sleep(TimeSpan.FromSeconds(10));
            paymentPage.EnterOTPNumber("123456");
            paymentPage.ClickProceed();
            WebDriver.Dispose();
        }

        [TestMethod]
        [TestProperty("TestCaseID", "00006")]
        [TestCategory("RegressionTest")]
        [Timeout(timeout)]
        [TestProperty("TestCaseTitle", "[TH] End To End Test With Motor Thai")]
        public void EndToEndTestWithMotorThai()
        {
            IWebDriver WebDriver1;
            Login login = new Login(Utils.Enum.URLType.Landing, Utils.Enum.UserRole.Manager);
            WebDriver = login.LaunchWebDriver();
            login.LogintoWebsite(WebDriver);
            Dashboard dashboard = new Dashboard(WebDriver);
            dashboard.ClickMotor();
            MI_Plans plan = new MI_Plans(WebDriver);
            plan.SelectBrand();
            plan.SelectYear("2019");
            plan.SelectModel("C-HR");
            plan.SelectSubModel("Entry CVT, 1800 CC");
            plan.ClickSearchPlan();
            plan.ClickSelectPlan();
            plan.ClickProceed();

            MI_ProspectDetail prospectDetail = new MI_ProspectDetail(WebDriver);
            prospectDetail.AddDetails();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            WebDriver.Dispose();

            Login login1 = new Login(Utils.Enum.URLType.TrialBase, Utils.Enum.UserRole.EmailUser);
            WebDriver = login1.LaunchWebDriver();
            login1.LogintoGmail(WebDriver);
            ReadEmail readEmail = new ReadEmail(WebDriver);
            readEmail.SelectEmail();
            readEmail.ClickProceedButton();
            Thread.Sleep(5000);

            Extension.WaitforPageLoad(WebDriver);
            Extension.SwitchTab(WebDriver);
            readEmail.ClickInboxButton();
            readEmail.DeleteFirstEmail();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            WebDriver.Close();
            Extension.SwitchTab(WebDriver);

            Plan plan1 = new Plan(WebDriver);
            plan1.ClickConfirmPlan();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            Application application = new Application(WebDriver);
            application.FillApplication();
            application.ClickNextandConfirm();

            Login login2 = new Login(Utils.Enum.URLType.TrialBase, Utils.Enum.UserRole.EmailUser);
            WebDriver1 = login2.LaunchWebDriver();
            login2.LogintoGmail(WebDriver1);
            ReadEmail readEmail1 = new ReadEmail(WebDriver1);
            readEmail1.SelectOTPEmail();
            Thread.Sleep(10000);
            string OTPNumber = readEmail1.GetOTPNumber();
            readEmail1.ClickInboxButton();
            readEmail1.DeleteFirstEmail();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            WebDriver1.Dispose();

            application.CompleteOTPNo(OTPNumber);
            application.ClickSubmitButton();
            Health health = new Health(WebDriver);
            health.FillHealthQuestionnaire();
            health.ClickNextStep();
            Extension.WaitforPageLoad(WebDriver);
            Thread.Sleep(TimeSpan.FromSeconds(15));
            Extension.ScrollDown(WebDriver);
            health.ClickNextStep();

            UploadDocument uploadDocument = new UploadDocument(WebDriver);
            uploadDocument.UploadIDCard();
            Extension.ScrollDown(WebDriver);
            uploadDocument.ClickNextStep();
            Extension.WaitforPageLoad(WebDriver);

            PaymentPage paymentPage = new PaymentPage(WebDriver);
            Thread.Sleep(TimeSpan.FromSeconds(20));
            paymentPage.ClickPaymentMethod();
            Extension.WaitforPageLoad(WebDriver);
            Thread.Sleep(TimeSpan.FromSeconds(20));
            paymentPage.FillCardDetails();
            paymentPage.ClickContinuePayment();
            Thread.Sleep(TimeSpan.FromSeconds(10));
            paymentPage.EnterOTPNumber("123456");
            paymentPage.ClickProceed();
            WebDriver.Dispose();
        }

        [TestMethod]
        [TestProperty("TestCaseID", "00006")]
        [TestCategory("RegressionTest")]
        [Timeout(timeout)]
        [TestProperty("TestCaseTitle", "[TH] Login To Freiends App Travel")]
        public void LoginToFreiendsAppTravel()
        {
            Login login = new Login(Utils.Enum.URLType.Landing, Utils.Enum.UserRole.Manager);
            WebDriver = login.LaunchWebDriver();
            login.LogintoWebsite(WebDriver);
            Dashboard dashboard = new Dashboard(WebDriver);
            dashboard.ClickTravel();
            Travel_Plans plan = new Travel_Plans(WebDriver);
            plan.SelectDestination("Switzerland");
            plan.PasengerCount("2");
            plan.ClickSearchPlan();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            plan.SelectPlan();

            ProspectDetail prospectDetail = new ProspectDetail(WebDriver);
            prospectDetail.SelectDOB();
            prospectDetail.AddDetails();
            prospectDetail.ClickReferForTravel();
            WebDriver.Dispose();

            Login login1 = new Login(Utils.Enum.URLType.TrialBase, Utils.Enum.UserRole.EmailUser);
            WebDriver = login1.LaunchWebDriver();
            login1.LogintoGmail(WebDriver);
            ReadEmail readEmail = new ReadEmail(WebDriver);
            readEmail.SelectTravelEmail();
            string SessionID = readEmail.GetSessioIDNumber();
            readEmail.ClickProceedButton();
            Thread.Sleep(5000);

            Extension.WaitforPageLoad(WebDriver);
            Extension.SwitchTab(WebDriver);
            readEmail.ClickInboxButton();
            readEmail.DeleteFirstEmail();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            WebDriver.Close();
            Extension.SwitchTab(WebDriver);

            SessionPage sessionPage = new SessionPage(WebDriver);
            sessionPage.EnterSessionID(SessionID);
            sessionPage.SelectPlan();
            WebDriver.Dispose();
        }

        #endregion

        #region Indoneasian Project Test Cases

        [TestMethod]
        [TestProperty("TestCaseID", "10001")]
        [Timeout(timeout)]
        [TestProperty("TestCaseTitle", "[IN] Login")]
        public void Login1()
        {
            Login login = new Login(Utils.Enum.URLType.Admin, Utils.Enum.UserRole.Manager);
            WebDriver = login.LaunchWebDriver();
            Dashboard_IN dashboard = new Dashboard_IN(WebDriver);
            dashboard.SelectBrand();
            dashboard.SelectYear("2021");
            dashboard.SelectModel("CHR 1.8 DUAL TONE");
            dashboard.SelectCode("AA - Kedu");
            Extension.ScrollDown(WebDriver);
            dashboard.ClickCarAsurenceButton();

            Plan_IN plan = new Plan_IN(WebDriver);
            plan.SelectPlan();
            plan.ClickConfirmPlan();
            DetailedPage_IN detailedPage = new DetailedPage_IN(WebDriver);
            detailedPage.AddDetails();
            detailedPage.ClickNextButton();
            ProposalForm_IN proposalForm = new ProposalForm_IN(WebDriver);
            proposalForm.ConfirmProposal();

            PaymentPage_IN paymentPage = new PaymentPage_IN(WebDriver);
            Thread.Sleep(TimeSpan.FromSeconds(30));
            paymentPage.ClickPaymentMethod();
            Extension.WaitforPageLoad(WebDriver);
            Thread.Sleep(TimeSpan.FromSeconds(20));
            paymentPage.FillCardDetails();
            paymentPage.ClickContinuePayment();
            Thread.Sleep(TimeSpan.FromSeconds(10));
            paymentPage.EnterOTPNumber("112233");
            paymentPage.ClickProceed();
            WebDriver.Dispose();
        }

        [TestMethod]
        [TestProperty("TestCaseID", "10002")]
        [Timeout(timeout)]
        [TestProperty("TestCaseTitle", "[IN] Customer wants to complete their data")]
        public void CustomerWantstoCompleteTheirData()
        {
            Login login = new Login(Utils.Enum.URLType.Admin, Utils.Enum.UserRole.Manager);
            WebDriver = login.LaunchWebDriver();
            Dashboard_IN dashboard = new Dashboard_IN(WebDriver);
            dashboard.SelectJiwaBerjangka();
            dashboard.SelectDOBYear("1989");
            dashboard.SelectDOB();
            Plan_IN plan = new Plan_IN(WebDriver);
            plan.SelectJiwaBerjangkaPlan();
            plan.ClickConfirmPlan();

            DetailedPage_IN detailedPage = new DetailedPage_IN(WebDriver);
            detailedPage.AddDetails();
            Extension.ScrollToEnd(WebDriver);
            detailedPage.ClickHealthDecleration();
            detailedPage.ClickNextButton();

            Thread.Sleep(TimeSpan.FromSeconds(10));
            Extension.ScrollToEnd(WebDriver);
            detailedPage.ClickNextButton();
            PaymentPage_IN paymentPage = new PaymentPage_IN(WebDriver);
            Thread.Sleep(TimeSpan.FromSeconds(30));
            paymentPage.ClickPaymentMethod();
            Extension.WaitforPageLoad(WebDriver);
            Thread.Sleep(TimeSpan.FromSeconds(20));
            paymentPage.FillCardDetails();
            paymentPage.ClickContinuePayment();
            Thread.Sleep(TimeSpan.FromSeconds(10));
            paymentPage.EnterOTPNumber("112233");
            paymentPage.ClickProceed();
            paymentPage.ClickConfirm();

            Onboarding_IN onboarding = new Onboarding_IN(WebDriver);
            onboarding.FillOnboardingForm();
            Extension.ScrollDown(WebDriver);
            onboarding.SelectProffession("Engineer");
            onboarding.FillAddress();
            onboarding.SelectProvince("DKI JAKARTA");
            Extension.ScrollToEnd(WebDriver);
            onboarding.SelectCity("Kota Administrasi Jakarta Barat");
            onboarding.EnterValues();
            onboarding.ClickNext();

            CustomerDetail_IN customerDetail = new CustomerDetail_IN(WebDriver);
            customerDetail.FillCustomerForm();
            customerDetail.SelectDateOfBirth();
            customerDetail.ClickNext();
            customerDetail.FillEmergencyDetails();
            WebDriver.Dispose();
        }

        [TestMethod]
        [TestProperty("TestCaseID", "10003")]
        [Timeout(timeout)]
        [TestProperty("TestCaseTitle", "[IN] Customer did not completed the data")]
        public void CustomerDidNotCompletedTheData()
        {
            Login login = new Login(Utils.Enum.URLType.Admin, Utils.Enum.UserRole.Manager);
            WebDriver = login.LaunchWebDriver();
            Dashboard_IN dashboard = new Dashboard_IN(WebDriver);
            dashboard.SelectJiwaBerjangka();
            dashboard.SelectDOBYear("1989");
            dashboard.SelectDOB();
            Plan_IN plan = new Plan_IN(WebDriver);
            plan.SelectJiwaBerjangkaPlan();
            plan.ClickConfirmPlan();

            DetailedPage_IN detailedPage = new DetailedPage_IN(WebDriver);
            detailedPage.AddDetails();
            Extension.ScrollToEnd(WebDriver);
            detailedPage.ClickHealthDecleration();
            detailedPage.ClickNextButton();

            Thread.Sleep(TimeSpan.FromSeconds(10));
            Extension.ScrollToEnd(WebDriver);
            detailedPage.ClickNextButton();
            PaymentPage_IN paymentPage = new PaymentPage_IN(WebDriver);
            Thread.Sleep(TimeSpan.FromSeconds(30));
            paymentPage.ClickPaymentMethod();
            Extension.WaitforPageLoad(WebDriver);
            Thread.Sleep(TimeSpan.FromSeconds(20));
            paymentPage.FillCardDetails();
            paymentPage.ClickContinuePayment();
            Thread.Sleep(TimeSpan.FromSeconds(10));
            paymentPage.EnterOTPNumber("112233");
            paymentPage.ClickProceed();
            paymentPage.ClickConfirm();

            Onboarding_IN onboarding = new Onboarding_IN(WebDriver);
            Extension.ScrollToEnd(WebDriver);
            onboarding.ClickNext();
            Thread.Sleep(TimeSpan.FromSeconds(3));
            Assert.AreEqual(true, onboarding.VerifyValidation());
            WebDriver.Dispose();
        }

        [TestMethod]
        [TestProperty("TestCaseID", "10004")]
        [Timeout(timeout)]
        [TestProperty("TestCaseTitle", "[IN] End To End Test with Linkaja Motor")]
        public void EndToEndTestwithLinkajaMotor()
        {
            Login login = new Login(Utils.Enum.URLType.LinkAjaMotorcycle, Utils.Enum.UserRole.Manager);
            WebDriver = login.LaunchWebDriver();
            Dashboard_IN_LA_MC dashboard = new Dashboard_IN_LA_MC(WebDriver);
            Extension.ScrollDown(WebDriver);
            dashboard.FillDetails();
            Extension.ScrollDown(WebDriver);
            dashboard.ClickLinkAjaPayment();
            dashboard.ClickContinuePaymentButton();

            PaymentPage_IN paymentPage = new PaymentPage_IN(WebDriver);
            Thread.Sleep(TimeSpan.FromSeconds(20));
            paymentPage.ClickPaymentMethod();
            Thread.Sleep(TimeSpan.FromSeconds(5));
            WebDriver.Dispose();
        }

        [TestMethod]
        [TestProperty("TestCaseID", "10005")]
        [Timeout(timeout)]
        [TestProperty("TestCaseTitle", "[IN] End To End Test with Linkaja Gadget")]
        public void EndToEndTestwithLinkajaGadget()
        {
            Login login = new Login(Utils.Enum.URLType.LinkAjaGadget, Utils.Enum.UserRole.Manager);
            WebDriver = login.LaunchWebDriver();
            Dashboard_IN_LA_GD dashboard = new Dashboard_IN_LA_GD(WebDriver);
            Extension.ScrollDown(WebDriver);
            dashboard.FillDetails();
            dashboard.SelectHPAge("15");
            dashboard.ClickApplyButton();
            Extension.ScrollDown(WebDriver);
            dashboard.ClickLinkAjaPayment();
            dashboard.ClickContinuePaymentButton();

            PaymentPage_IN paymentPage = new PaymentPage_IN(WebDriver);
            Thread.Sleep(TimeSpan.FromSeconds(20));
            paymentPage.ClickPaymentMethod();
            Thread.Sleep(TimeSpan.FromSeconds(5));
            WebDriver.Dispose();
        }

        [TestMethod]
        [TestProperty("TestCaseID", "10006")]
        [Timeout(timeout)]
        [TestProperty("TestCaseTitle", "[IN] End To End Test with HCP Campaign")]
        public void EndToEndTestwithHCPCampaign()
        {
            Login login = new Login(Utils.Enum.URLType.HCPCampaign, Utils.Enum.UserRole.Manager);
            WebDriver = login.LaunchWebDriver();
            Dashboard_HCP_CPG dashboard = new Dashboard_HCP_CPG(WebDriver);
            Extension.ScrollDown(WebDriver);
            dashboard.SelectInsurance("Diri Sendiri");
            dashboard.FillDetails();
            Extension.ScrollDown(WebDriver);
            dashboard.SelectDOB();
            dashboard.SelectProffession("Engineer");
            dashboard.SelectProvince("DKI JAKARTA");
            dashboard.SelectCity("Kota Administrasi Jakarta Barat");
            Extension.ScrollDown(WebDriver);
            dashboard.ClickAgree();
            Extension.ScrollDown(WebDriver);
            dashboard.ClickNextButton();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            dashboard.ClickPayButton();

            PaymentPage_IN paymentPage = new PaymentPage_IN(WebDriver);
            Thread.Sleep(TimeSpan.FromSeconds(30));
            paymentPage.ClickPaymentMethod();
            Extension.WaitforPageLoad(WebDriver);
            Thread.Sleep(TimeSpan.FromSeconds(20));
            paymentPage.FillCardDetails();
            paymentPage.ClickContinuePayment();
            Thread.Sleep(TimeSpan.FromSeconds(10));
            paymentPage.EnterOTPNumber("112233");
            paymentPage.ClickProceed();
            paymentPage.ClickConfirm();
            WebDriver.Dispose();
        }

        [TestMethod]
        [TestProperty("TestCaseID", "10007")]
        [Timeout(timeout)]
        [TestProperty("TestCaseTitle", "[IN] End-to-End International Destination Individual Traveler, Payment using Credit Card")]
        public void EndtoEndInternationalDestinationIndividualTravelerCreditCard()
        {
            Login login = new Login(Utils.Enum.URLType.Admin, Utils.Enum.UserRole.Manager);
            WebDriver = login.LaunchWebDriver();
            Dashboard_IN dashboard = new Dashboard_IN(WebDriver);
            Thread.Sleep(TimeSpan.FromSeconds(2));
            Extension.ScrollDown(WebDriver);
            Extension.ScrollDown(WebDriver);
            Extension.ScrollDown(WebDriver);
            Thread.Sleep(TimeSpan.FromSeconds(2));
            dashboard.ClickTravel();
            Travel_Plan_IN travel = new Travel_Plan_IN(WebDriver);
            travel.SelectDestination("Switzerland");
            travel.ClickCarryOn();
            travel.ClickCarryOn();
            travel.SelectInDate();
            travel.SelectOutDate();
            travel.ClickCarryOn();
            travel.SelectPlan();
            travel.SelectBuyInsurence();

            DetailedPage_IN detailedPage = new DetailedPage_IN(WebDriver);
            detailedPage.AddDetails();
            Extension.ScrollToEnd(WebDriver);
            detailedPage.ClickNextButton();
            Thread.Sleep(TimeSpan.FromSeconds(5));
            Extension.ScrollToEnd(WebDriver);
            detailedPage.ClickNextButton();

            PaymentPage_IN paymentPage = new PaymentPage_IN(WebDriver);
            Thread.Sleep(TimeSpan.FromSeconds(30));
            paymentPage.ClickPaymentMethod();
            Extension.WaitforPageLoad(WebDriver);
            Thread.Sleep(TimeSpan.FromSeconds(20));
            paymentPage.FillCardDetails();
            paymentPage.ClickContinuePayment();
            Thread.Sleep(TimeSpan.FromSeconds(10));
            paymentPage.EnterOTPNumber("112233");
            paymentPage.ClickProceed();
            paymentPage.ClickConfirm();

            Onboarding_Travel_IN onboarding = new Onboarding_Travel_IN(WebDriver);
            onboarding.FillOnboardingForm();
            onboarding.EnterPassport();
            Extension.ScrollDown(WebDriver);
            onboarding.SelectStatus("Lajang");
            onboarding.SelectProffession("Engineer");
            onboarding.FillAddress();
            onboarding.SelectProvince("DKI JAKARTA");
            Extension.ScrollToEnd(WebDriver);
            onboarding.SelectCity("Kota Administrasi Jakarta Barat");
            onboarding.EnterPostalCode();
            onboarding.ClickNext();

            Emergency_Contact_IN emergencyDetail = new Emergency_Contact_IN(WebDriver);
            emergencyDetail.FillForm();
            emergencyDetail.UploadIDCard();
            emergencyDetail.ClickNextBtn();
            WebDriver.Dispose();
        }

        [TestMethod]
        [TestProperty("TestCaseID", "10008")]
        [Timeout(timeout)]
        [TestProperty("TestCaseTitle", "[IN] End-to-End International Destination 2 Travelers, Payment Using Bank Transfer (BCA)")]
        public void EndtoEndInternationalDestinationDuoTravelersBCA()
        {
            Login login = new Login(Utils.Enum.URLType.Admin, Utils.Enum.UserRole.Manager);
            WebDriver = login.LaunchWebDriver();
            Dashboard_IN dashboard = new Dashboard_IN(WebDriver);
            Thread.Sleep(TimeSpan.FromSeconds(2));
            Extension.ScrollDown(WebDriver);
            Extension.ScrollDown(WebDriver);
            Extension.ScrollDown(WebDriver);
            Thread.Sleep(TimeSpan.FromSeconds(2));
            dashboard.ClickTravel();
            Travel_Plan_IN travel = new Travel_Plan_IN(WebDriver);
            travel.SelectDestination("Switzerland");
            travel.ClickCarryOn();
            travel.SelectDuo();
            travel.EnterPeopleCount("2");
            travel.ClickCarryOn();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            travel.SelectInDate();
            travel.SelectOutDate();
            travel.ClickCarryOn();
            travel.SelectPlan();
            travel.SelectBuyInsurence();

            DetailedPage_IN detailedPage = new DetailedPage_IN(WebDriver);
            detailedPage.AddDetails();
            Extension.ScrollToEnd(WebDriver);
            detailedPage.ClickNextButton();
            Thread.Sleep(TimeSpan.FromSeconds(5));
            Extension.ScrollToEnd(WebDriver);
            detailedPage.ClickNextButton();

            PaymentPage_IN paymentPage = new PaymentPage_IN(WebDriver);
            Thread.Sleep(TimeSpan.FromSeconds(30));
            paymentPage.ClickBankTransferBCAPaymentMethod();           
            WebDriver.Dispose();
        }

        [TestMethod]
        [TestProperty("TestCaseID", "10009")]
        [Timeout(timeout)]
        [TestProperty("TestCaseTitle", "[IN] End-to-End international Destination Family, Payment Using Credit Card")]
        public void EndtoEndInternationalDestinationFamilyCreditCard()
        {
            Login login = new Login(Utils.Enum.URLType.Admin, Utils.Enum.UserRole.Manager);
            WebDriver = login.LaunchWebDriver();
            Dashboard_IN dashboard = new Dashboard_IN(WebDriver);
            Thread.Sleep(TimeSpan.FromSeconds(2));
            Extension.ScrollDown(WebDriver);
            Extension.ScrollDown(WebDriver);
            Extension.ScrollDown(WebDriver);
            Thread.Sleep(TimeSpan.FromSeconds(2));
            dashboard.ClickTravel();
            Travel_Plan_IN travel = new Travel_Plan_IN(WebDriver);
            travel.SelectDestination("Switzerland");
            travel.ClickCarryOn();
            travel.SelectFamily();
            travel.EnterPeopleCount("2");
            travel.EnterChildCount("1");
            travel.ClickCarryOn();
            travel.SelectInDate();
            travel.SelectOutDate();
            travel.ClickCarryOn();
            travel.SelectPlan();
            travel.SelectBuyInsurence();

            DetailedPage_IN detailedPage = new DetailedPage_IN(WebDriver);
            detailedPage.AddDetails();
            Extension.ScrollToEnd(WebDriver);
            detailedPage.ClickNextButton();
            Thread.Sleep(TimeSpan.FromSeconds(5));
            Extension.ScrollToEnd(WebDriver);
            detailedPage.ClickNextButton();

            PaymentPage_IN paymentPage = new PaymentPage_IN(WebDriver);
            Thread.Sleep(TimeSpan.FromSeconds(30));
            paymentPage.ClickPaymentMethod();
            Extension.WaitforPageLoad(WebDriver);
            Thread.Sleep(TimeSpan.FromSeconds(20));
            paymentPage.FillCardDetails();
            paymentPage.ClickContinuePayment();
            Thread.Sleep(TimeSpan.FromSeconds(10));
            paymentPage.EnterOTPNumber("112233");
            paymentPage.ClickProceed();
            paymentPage.ClickConfirm();

            Onboarding_Travel_IN onboarding = new Onboarding_Travel_IN(WebDriver);
            Thread.Sleep(TimeSpan.FromSeconds(5));
            onboarding.EnterPassport();
            onboarding.FillOnboardingForm();           
            Extension.ScrollDown(WebDriver);
            onboarding.SelectStatus("Lajang");
            onboarding.SelectProffession("Engineer");
            onboarding.FillAddress();
            onboarding.SelectProvince("DKI JAKARTA");
            Extension.ScrollToEnd(WebDriver);
            onboarding.SelectCity("Kota Administrasi Jakarta Barat");
            onboarding.EnterPostalCode();
            onboarding.ClickNext();
            onboarding.FillFirstInsuredDetail();
            onboarding.SelectFirstInsuredPersonRelationship("Orang Tua");
            onboarding.FillSecondInsuredDetail();
            onboarding.SelectSecondInsuredPersonRelationship("Anak");
            onboarding.ClickSecondNext();

            Emergency_Contact_IN emergencyDetail = new Emergency_Contact_IN(WebDriver);
            emergencyDetail.FillForm();
            emergencyDetail.UploadIDCard();
            emergencyDetail.UploadIDCard();
            emergencyDetail.UploadIDCard();
            Extension.ScrollToEnd(WebDriver);
            emergencyDetail.ClickNextBtn();
            WebDriver.Dispose();
        }

        [TestMethod]
        [TestProperty("TestCaseID", "10010")]
        [Timeout(timeout)]
        [TestProperty("TestCaseTitle", "[IN] End-to-End Domestic Destination Individual Traveler, Payment Using Credit Card")]
        public void EndtoEndDomesticDestinationIndividualTravelerCreditCard()
        {
            Login login = new Login(Utils.Enum.URLType.Admin, Utils.Enum.UserRole.Manager);
            WebDriver = login.LaunchWebDriver();
            Dashboard_IN dashboard = new Dashboard_IN(WebDriver);
            Thread.Sleep(TimeSpan.FromSeconds(2));
            Extension.ScrollDown(WebDriver);
            Extension.ScrollDown(WebDriver);
            Extension.ScrollDown(WebDriver);
            Thread.Sleep(TimeSpan.FromSeconds(2));
            dashboard.ClickTravel();
            Travel_Plan_IN travel = new Travel_Plan_IN(WebDriver);
            travel.SelectTravelType("Domestik");
            travel.SelectDestination("Kota Palembang, SUMATERA SELATAN, INDONESIA");
            travel.ClickCarryOn();
            travel.ClickCarryOn();
            travel.SelectInDate();
            travel.SelectOutDate();
            travel.ClickCarryOn();
            travel.SelectPlan();
            travel.SelectBuyInsurence();

            DetailedPage_IN detailedPage = new DetailedPage_IN(WebDriver);
            detailedPage.AddDetails();
            Extension.ScrollToEnd(WebDriver);
            detailedPage.ClickNextButton();
            Thread.Sleep(TimeSpan.FromSeconds(5));
            Extension.ScrollToEnd(WebDriver);
            detailedPage.ClickNextButton();

            PaymentPage_IN paymentPage = new PaymentPage_IN(WebDriver);
            Thread.Sleep(TimeSpan.FromSeconds(30));
            paymentPage.ClickPaymentMethod();
            Extension.WaitforPageLoad(WebDriver);
            Thread.Sleep(TimeSpan.FromSeconds(20));
            paymentPage.FillCardDetails();
            paymentPage.ClickContinuePayment();
            Thread.Sleep(TimeSpan.FromSeconds(10));
            paymentPage.EnterOTPNumber("112233");
            paymentPage.ClickProceed();
            paymentPage.ClickConfirm();

            Onboarding_Travel_IN onboarding = new Onboarding_Travel_IN(WebDriver);
            onboarding.FillOnboardingForm();
            Extension.ScrollDown(WebDriver);
            onboarding.SelectStatus("Lajang");
            onboarding.SelectProffession("Engineer");
            onboarding.FillAddress();
            onboarding.SelectProvince("DKI JAKARTA");
            Extension.ScrollToEnd(WebDriver);
            onboarding.SelectCity("Kota Administrasi Jakarta Barat");
            onboarding.EnterPostalCode();
            onboarding.ClickNext();

            Emergency_Contact_IN emergencyDetail = new Emergency_Contact_IN(WebDriver);
            emergencyDetail.FillForm();
            emergencyDetail.UploadIDCard();
            emergencyDetail.ClickNextBtn();
            WebDriver.Dispose();
        }

        [TestMethod]
        [TestProperty("TestCaseID", "10011")]
        [Timeout(timeout)]
        [TestProperty("TestCaseTitle", "[IN] End-to-End Domestic Destination Individual Traveler, Payment Using Indomaret")]
        public void EndtoEndDomesticDestinationIndividualTravelerIndomaret()
        {
            Login login = new Login(Utils.Enum.URLType.Admin, Utils.Enum.UserRole.Manager);
            WebDriver = login.LaunchWebDriver();
            Dashboard_IN dashboard = new Dashboard_IN(WebDriver);
            Thread.Sleep(TimeSpan.FromSeconds(2));
            Extension.ScrollDown(WebDriver);
            Extension.ScrollDown(WebDriver);
            Extension.ScrollDown(WebDriver);
            Thread.Sleep(TimeSpan.FromSeconds(2));
            dashboard.ClickTravel();
            Travel_Plan_IN travel = new Travel_Plan_IN(WebDriver);
            travel.SelectTravelType("Domestik");
            travel.SelectDestination("Kota Palembang, SUMATERA SELATAN, INDONESIA");
            travel.ClickCarryOn();
            travel.ClickCarryOn();
            travel.SelectInDate();
            travel.SelectOutDate();
            travel.ClickCarryOn();
            travel.SelectPlan();
            travel.SelectBuyInsurence();

            DetailedPage_IN detailedPage = new DetailedPage_IN(WebDriver);
            detailedPage.AddDetails();
            Extension.ScrollToEnd(WebDriver);
            detailedPage.ClickNextButton();
            Thread.Sleep(TimeSpan.FromSeconds(5));
            Extension.ScrollToEnd(WebDriver);
            detailedPage.ClickNextButton();

            PaymentPage_IN paymentPage = new PaymentPage_IN(WebDriver);
            Thread.Sleep(TimeSpan.FromSeconds(30));
            paymentPage.ClickIndomaretPaymentMethod();        
            WebDriver.Dispose();
        }

        [TestMethod]
        [TestProperty("TestCaseID", "10012")]
        [Timeout(timeout)]
        [TestProperty("TestCaseTitle", "[IN] End-to-End Domestic Destination Individual Traveler, Payment Using Alfamart")]
        public void EndtoEndDomesticDestinationIndividualTravelerAlfamart()
        {
            Login login = new Login(Utils.Enum.URLType.Admin, Utils.Enum.UserRole.Manager);
            WebDriver = login.LaunchWebDriver();
            Dashboard_IN dashboard = new Dashboard_IN(WebDriver);
            Thread.Sleep(TimeSpan.FromSeconds(2));
            Extension.ScrollDown(WebDriver);
            Extension.ScrollDown(WebDriver);
            Extension.ScrollDown(WebDriver);
            Thread.Sleep(TimeSpan.FromSeconds(2));
            dashboard.ClickTravel();
            Travel_Plan_IN travel = new Travel_Plan_IN(WebDriver);
            travel.SelectTravelType("Domestik");
            travel.SelectDestination("Kota Palembang, SUMATERA SELATAN, INDONESIA");
            travel.ClickCarryOn();
            travel.ClickCarryOn();
            travel.SelectInDate();
            travel.SelectOutDate();
            travel.ClickCarryOn();
            travel.SelectPlan();
            travel.SelectBuyInsurence();

            DetailedPage_IN detailedPage = new DetailedPage_IN(WebDriver);
            detailedPage.AddDetails();
            Extension.ScrollToEnd(WebDriver);
            detailedPage.ClickNextButton();
            Thread.Sleep(TimeSpan.FromSeconds(5));
            Extension.ScrollToEnd(WebDriver);
            detailedPage.ClickNextButton();

            PaymentPage_IN paymentPage = new PaymentPage_IN(WebDriver);
            Thread.Sleep(TimeSpan.FromSeconds(30));
            Extension.ScrollToEnd(WebDriver);
            paymentPage.ClickAlfamartPaymentMethod();
            WebDriver.Dispose();
        }

        [TestMethod]
        [TestProperty("TestCaseID", "10013")]
        [Timeout(timeout)]
        [TestProperty("TestCaseTitle", "[IN] End-to-End Domestic Destination Family Traveler, Payment Using Bank Transfer (Permata)")]
        public void EndtoEndDomesticDestinationIndividualTravelerPermata()
        {
            Login login = new Login(Utils.Enum.URLType.Admin, Utils.Enum.UserRole.Manager);
            WebDriver = login.LaunchWebDriver();
            Dashboard_IN dashboard = new Dashboard_IN(WebDriver);
            Thread.Sleep(TimeSpan.FromSeconds(2));
            Extension.ScrollDown(WebDriver);
            Extension.ScrollDown(WebDriver);
            Extension.ScrollDown(WebDriver);
            Thread.Sleep(TimeSpan.FromSeconds(2));
            dashboard.ClickTravel();
            Travel_Plan_IN travel = new Travel_Plan_IN(WebDriver);
            travel.SelectTravelType("Domestik");
            travel.SelectDestination("Kota Palembang, SUMATERA SELATAN, INDONESIA");
            travel.ClickCarryOn();
            travel.SelectFamily();
            travel.EnterPeopleCount("2");
            travel.EnterChildCount("1");
            travel.ClickCarryOn();
            travel.SelectInDate();
            travel.SelectOutDate();
            travel.ClickCarryOn();
            travel.SelectPlan();
            travel.SelectBuyInsurence();

            DetailedPage_IN detailedPage = new DetailedPage_IN(WebDriver);
            detailedPage.AddDetails();
            Extension.ScrollToEnd(WebDriver);
            detailedPage.ClickNextButton();
            Thread.Sleep(TimeSpan.FromSeconds(5));
            Extension.ScrollToEnd(WebDriver);
            detailedPage.ClickNextButton();

            PaymentPage_IN paymentPage = new PaymentPage_IN(WebDriver);
            Thread.Sleep(TimeSpan.FromSeconds(30));
            paymentPage.ClickBankTransferPermartaPaymentMethod();
            WebDriver.Dispose();
        }

        #endregion

        #region TestCleanUp
        [TestCleanup]

            public void CleanUp()
            {
                if (TestContext.CurrentTestOutcome.Equals(UnitTestOutcome.Failed))
                {
                    GetScreenshot();
                }

                WebDriver.Quit();
            }

        #endregion

        public void GetScreenshot()
        {
            Screenshot ss = ((ITakesScreenshot)this.WebDriver).GetScreenshot();
            DateTime time = DateTime.Now;
            string dateToday = "_date_" + time.ToString("yyyy-MM-dd") + "_time_" + time.ToString("HH-mm-ss");
            string path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + String.Format("{0}.png", TestContext.TestName+dateToday);
            ss.SaveAsFile(path);
            this.TestContext.AddResultFile(path);
        }

        public TestContext TestContext
        {
            get 
            {
                return testContextInstance;
            }

            set 
            {
                testContextInstance = value;
            }
        }
    }
}
