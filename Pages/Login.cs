using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using static Futuready_Automation.Utils.Enum;
using OpenQA.Selenium.Chrome;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;

namespace Futuready_Automation.Pages
{
    internal class Login
    {
        private System.Uri baseURL;
        private string userName;
        private string UserPassword;

        //#region crosstest
//        private static string browserT = ConfigurationManager.AppSettings["browserName"];
        protected IWebDriver browser;
        private string seleniumChromeDriverPath;
        //#endregion

        #region Elements

        By clickHereButton = By.LinkText("Click here");
        By UserName = By.CssSelector("div[class='control is-expanded is-clearfix'] input[class='input']");
        By Password = By.CssSelector("div[class='control has-icons-right is-expanded'] input[class='input']");
        By ClickLoginButton = By.CssSelector("div[class='field mt-3'] button[class='button is-secondary is-fullwidth']");
        By gmailUserName = By.Id("identifierId");
        By gmailPassword = By.XPath("//div[@id='password']/div[1]/div[1]/div[1]/input");
        By GmailNextButton = By.XPath("//div[@id='view_container']/div[1]/div[1]/div[2]/div[1]/div[2]/div[1]/div[1]/div[1]/div[1]/button");
        By GmailSecondNextButton = By.XPath("//div[@class='zQJV3']/div[1]/div[1]/div[1]/div[1]/button");

        #endregion Elements

        internal Login(URLType urlType, UserRole userRole)/*Initialize site URLs and Users*/
        {
            seleniumChromeDriverPath = ConfigurationManager.AppSettings["Selenium.ChromeDriverPath"];

            switch (urlType)
            {
                case URLType.Landing:
                    baseURL = new System.Uri(ConfigurationManager.AppSettings["LandingUrl"]);
                    break;
                case URLType.Admin:
                    baseURL = new System.Uri(ConfigurationManager.AppSettings["AdminUrl"]);
                    break;
                case URLType.TrialBase:
                    baseURL = new System.Uri(ConfigurationManager.AppSettings["TrialBaseUrl"]);
                    break;
                case URLType.LinkAjaMotorcycle:
                    baseURL = new System.Uri(ConfigurationManager.AppSettings["LinkAjaMotorcycleURL"]);
                    break;
                case URLType.LinkAjaGadget:
                    baseURL = new System.Uri(ConfigurationManager.AppSettings["LinkAjaGadgeteURL"]);
                    break;
                case URLType.HCPCampaign:
                    baseURL = new System.Uri(ConfigurationManager.AppSettings["HCPCampaignURL"]);
                    break;
                default:
                    baseURL = new System.Uri(ConfigurationManager.AppSettings["LandingUrl"]);
                    break;
            }

            switch (userRole)
            {
                case UserRole.Manager:
                    userName = ConfigurationManager.AppSettings["ManagerUser"];
                    UserPassword = ConfigurationManager.AppSettings["ManagerUserPwd"];
                    break;
                case UserRole.Admin:
                    userName = ConfigurationManager.AppSettings["AdminUser"];
                    UserPassword = ConfigurationManager.AppSettings["AdminUserPwd"];
                    break;
                case UserRole.AppUser:
                    userName = ConfigurationManager.AppSettings["AppUser"];
                    UserPassword = ConfigurationManager.AppSettings["AppUserPwd"];
                    break;
                case UserRole.EmailUser:
                    userName = ConfigurationManager.AppSettings["EmailUser"];
                    UserPassword = ConfigurationManager.AppSettings["EmailUserPwd"];
                    break;
            }

        }

        public IWebDriver LaunchWebDriver()
        {
            var option = new ChromeOptions();
            option.AddArgument("--start-maximized");
            IWebDriver browser = new ChromeDriver(ChromeDriverService.CreateDefaultService(seleniumChromeDriverPath, "chromedriver.exe"), option, TimeSpan.FromMinutes(2));
            browser.Navigate().GoToUrl(baseURL.ToString());
            return browser;
        }

        public void LogintoWebsite(IWebDriver webDriver)
        {
            WebDriverWait wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(30));
            wait.Until(ExpectedConditions.ElementToBeClickable(UserName)).SendKeys(userName);
            wait.Until(ExpectedConditions.ElementToBeClickable(Password)).SendKeys(UserPassword);
            wait.Until(ExpectedConditions.ElementToBeClickable(ClickLoginButton)).Click();

        }

        public void LogintoGmail(IWebDriver webDriver)
        {
            Thread.Sleep(TimeSpan.FromSeconds(3));
            WebDriverWait wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(30));
            wait.Until(ExpectedConditions.ElementToBeClickable(gmailUserName)).SendKeys(userName);
            wait.Until(ExpectedConditions.ElementToBeClickable(GmailNextButton)).Click();
            Thread.Sleep(TimeSpan.FromSeconds(3));
            wait.Until(ExpectedConditions.ElementToBeClickable(gmailPassword)).SendKeys(UserPassword);
            wait.Until(ExpectedConditions.ElementToBeClickable(GmailSecondNextButton)).Click();

        }
    }
}
