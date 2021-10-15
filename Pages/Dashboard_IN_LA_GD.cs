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
    public class Dashboard_IN_LA_GD
    {
        private IWebDriver driver;

        By NameTXT = By.CssSelector("div[class='container mt-4 px-3'] input[name='name']");
        By EmailTXT = By.CssSelector("div[class='container mt-4 px-3'] input[name='email']");
        By MobileNoTXT = By.CssSelector("div[class='container mt-4 px-3'] input[name='phone']");
        By IMEINoTXT = By.CssSelector("div[class='container mt-4 px-3'] input[name='imei']");
        By HpAgeDropdown = By.CssSelector("div[class='container mt-4 px-3'] input[name='phone']");
        By ApplyBTN = By.XPath("//div[@class='container mt-4 px-3']/div[1]/form/button");
        By AcceptChkBox = By.XPath("//div[@class='details-gadget-box px-3']/label/span[1]");
        By LinkAjaChkBox = By.XPath("//div[@class='px-3']/div[2]/div[1]/div[1]");
        By ContinueButton = By.XPath("//div[@class='price-button']/div[2]/button");

        public Dashboard_IN_LA_GD(IWebDriver driver)
        {
            this.driver = driver;

        }

        public void FillDetails()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            wait.Until(ExpectedConditions.ElementToBeClickable(NameTXT)).SendKeys("Test Automation");
            wait.Until(ExpectedConditions.ElementToBeClickable(EmailTXT)).SendKeys("Test@gmail.com");
            wait.Until(ExpectedConditions.ElementToBeClickable(MobileNoTXT)).SendKeys("08123456789");
            wait.Until(ExpectedConditions.ElementToBeClickable(IMEINoTXT)).SendKeys("123456789");
        }

        public void SelectHPAge(string year)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(ExpectedConditions.ElementToBeClickable(HpAgeDropdown)).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));

            IList<IWebElement> yearlist = driver.FindElements(By.XPath("//form[@class='mt-1 mb-3']/div[4]/div[1]/span/select/option"));

            foreach (IWebElement years in yearlist)
            {
                if (years.Text.Equals(year))
                {
                    years.Click();
                }
            }
        }

        public void ClickApplyButton()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            wait.Until(ExpectedConditions.ElementToBeClickable(ApplyBTN)).Click();
        }

        public void ClickLinkAjaPayment()
        {
            Thread.Sleep(TimeSpan.FromSeconds(5));
            Extension.ScrollDown(driver);
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            wait.Until(ExpectedConditions.ElementToBeClickable(AcceptChkBox)).Click();
            Extension.ScrollDown(driver);
            Thread.Sleep(TimeSpan.FromSeconds(3));
            wait.Until(ExpectedConditions.ElementToBeClickable(LinkAjaChkBox)).Click();
        }

        public void ClickContinuePaymentButton()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            wait.Until(ExpectedConditions.ElementToBeClickable(ContinueButton)).Click();
        }

    }
}
