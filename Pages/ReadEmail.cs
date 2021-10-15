using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Futuready_Automation.Utils;

namespace Futuready_Automation.Pages
{
    public class ReadEmail
    {
        private IWebDriver driver;

        By ProceedButton = By.XPath("//div[@class='gs']/div[3]/div[3]/div[1]/div[2]/div[2]/div[2]/div[2]/table/tbody/tr/td/table/tbody/tr/td/table/tbody/tr[16]/td/table/tbody/tr/td/table/tbody/tr/td/a");
        By SelectFirstEmail = By.XPath("//div[@class='UI']/div[1]/div[1]/div[3]/div[1]/table/tbody/tr[1]/td[2]/div");
        By DeleteButton = By.XPath("//*[@id=':4']/div[1]/div[1]/div[1]/div[1]/div[1]/div[2]/div[3]");
        By ClickInbox = By.XPath("//div[@class='aim ain']/div[1]/div[1]/div[2]/span");
        By GetOTP = By.XPath("//div[@class='adn ads']/div[2]/div[3]/div[3]/div[1]");
        By GetSessionID = By.XPath("//div[@class='adn ads']/div[2]/div[3]/div[3]/div[1]/div[2]/div[2]/div[2]/div[2]/table[1]/tbody[1]/tr[1]/td[1]/table[1]/tbody[1]/tr[1]/td[1]/table[1]/tbody[1]/tr[6]/td[1]/table[1]/tbody[1]/tr[1]/td[1]/table[1]/tbody[1]/tr[1]/td[2]/table[1]/tbody[1]/tr[1]/td[1]/table[1]/tbody[1]/tr[1]/td[1]/p[2]/font");


        public ReadEmail(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void SelectEmail()
        {
            Thread.Sleep(TimeSpan.FromSeconds(5));
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            IList<IWebElement> SubjectMsgs = driver.FindElements(By.XPath("//div[@class='UI']/div[1]/div[1]/div[3]/div[1]/table/tbody/tr/td[5]/div[1]/div[1]/div[2]/span/span"));

            string ExpectSubject = "[TEST] Futuready - Order Request Notification";

            foreach (IWebElement Subjectmsg in SubjectMsgs)
            {
                if (Subjectmsg.Text.Equals(ExpectSubject))
                {
                    Subjectmsg.Click();
                }
            }
        }

        public void ClickProceedButton()
        {
            Thread.Sleep(TimeSpan.FromSeconds(5));
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            Extension.ScrollDown(driver);
            wait.Until(ExpectedConditions.ElementToBeClickable(ProceedButton)).Click();
        }
        public void ClickInboxButton()
        {
            Thread.Sleep(TimeSpan.FromSeconds(2));
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            wait.Until(ExpectedConditions.ElementToBeClickable(ClickInbox)).Click();
        }

        public void DeleteFirstEmail()
        {
            Thread.Sleep(TimeSpan.FromSeconds(2));
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            wait.Until(ExpectedConditions.ElementToBeClickable(SelectFirstEmail)).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            wait.Until(ExpectedConditions.ElementToBeClickable(DeleteButton)).Click();
        }

        public void SelectOTPEmail()
        {
            Thread.Sleep(TimeSpan.FromSeconds(5));
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            IList<IWebElement> SubjectMsgs = driver.FindElements(By.XPath("//div[@class='UI']/div[1]/div[1]/div[3]/div[1]/table/tbody/tr/td[5]/div[1]/div[1]/div[2]/span/span"));

            string ExpectSubject = "[TEST] Futuready - OTP Verification";

            foreach (IWebElement Subjectmsg in SubjectMsgs)
            {
                if (Subjectmsg.Text.Equals(ExpectSubject))
                {
                    Subjectmsg.Click();
                }
            }
        }

        public string GetOTPNumber()
        {
            Thread.Sleep(TimeSpan.FromSeconds(5));
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            string OTPNumber = wait.Until(ExpectedConditions.ElementToBeClickable(GetOTP)).Text.Split().Last().ToString();
           // int OTPNo = int.Parse(OTPNumber);
            return OTPNumber;
        }

        public void SelectTravelEmail()
        {
            Thread.Sleep(TimeSpan.FromSeconds(5));
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            IList<IWebElement> SubjectMsgs = driver.FindElements(By.XPath("//div[@class='UI']/div[1]/div[1]/div[3]/div[1]/table/tbody/tr/td[5]/div[1]/div[1]/div[2]/span/span"));

            string ExpectSubject = "[TEST] Order Request Notification";

            foreach (IWebElement Subjectmsg in SubjectMsgs)
            {
                if (Subjectmsg.Text.Equals(ExpectSubject))
                {
                    Subjectmsg.Click();
                }
            }
        }

        public string GetSessioIDNumber()
        {
            Thread.Sleep(TimeSpan.FromSeconds(5));
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            string SessionID = wait.Until(ExpectedConditions.ElementToBeClickable(GetSessionID)).Text.ToString();
            // int OTPNo = int.Parse(OTPNumber);
            return SessionID;
        }
    }
}
