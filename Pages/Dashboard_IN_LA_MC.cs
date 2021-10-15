using Futuready_Automation.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Futuready_Automation.Pages
{
    public class Dashboard_IN_LA_MC
    {
        private IWebDriver driver;

        By NameTXT = By.Id("name");
        By EmailTXT = By.Id("email");
        By MobileNoTXT = By.Id("phone");
        By ApplyforInsuranceBTN = By.XPath("//div[@id='scrollAjukan']/form/div[4]/button");
        By AcceptChkBox = By.XPath("//div[@class='agreement-card']/label/span");
        By LinkAjaChkBox = By.XPath("//div[@class='details-gadget-option']/div[1]/label/span[1]");
        By ContinueButton = By.XPath("//div[@class='price-button']/div[2]/button");

        public Dashboard_IN_LA_MC(IWebDriver driver)
        {
            this.driver = driver;

        }

        public void FillDetails()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            wait.Until(ExpectedConditions.ElementToBeClickable(NameTXT)).SendKeys("Test Automation");
            wait.Until(ExpectedConditions.ElementToBeClickable(EmailTXT)).SendKeys("Test@gmail.com");
            wait.Until(ExpectedConditions.ElementToBeClickable(MobileNoTXT)).SendKeys("08123456789");
            wait.Until(ExpectedConditions.ElementToBeClickable(ApplyforInsuranceBTN)).Click();
        }

        public void ClickLinkAjaPayment()
        {
            Thread.Sleep(TimeSpan.FromSeconds(5));
            Extension.ScrollToEnd(driver);
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));  
            wait.Until(ExpectedConditions.ElementToBeClickable(AcceptChkBox)).Click();
            wait.Until(ExpectedConditions.ElementToBeClickable(LinkAjaChkBox)).Click();
        }

        public void ClickContinuePaymentButton()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            wait.Until(ExpectedConditions.ElementToBeClickable(ContinueButton)).Click();
        }
    }
}
