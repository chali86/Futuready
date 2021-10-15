using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Futuready_Automation.Utils;
using System.Windows.Forms;

namespace Futuready_Automation.Pages
{
    public class Emergency_Contact_IN
    {
        private IWebDriver driver;

        By EnterFullNameTXT = By.CssSelector("div[class='field column is-full'] input[name='emergency_name']");
        By MaleCHKBox = By.XPath("//div[@class='container']/div[1]/div[1]/div[3]/form/div[2]/div[1]/label[1]/span[1]");
        By EnterMobileTXT = By.CssSelector("div[class='field column is-full'] input[name='emergency_phone']");
        By EnterEmailTXT = By.CssSelector("div[class='field column is-full'] input[name='emergency_email']");
        By EnterConnectionTXT = By.CssSelector("div[class='field column is-full'] input[name='emergency_relation']");
        By NextBTN = By.XPath("//div[@class='container']/div[1]/div[1]/div[3]/div[1]/button");
        By UploadBTN = By.CssSelector("div[class='container'] div[class='upload-placeholder is-flex']");
        By Next1BTN = By.XPath("//div[@class='container']/div[1]/div[1]/div[4]/div[1]/button");

        public Emergency_Contact_IN(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void FillForm()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            Thread.Sleep(TimeSpan.FromSeconds(3));
            wait.Until(ExpectedConditions.ElementToBeClickable(EnterFullNameTXT)).SendKeys("Test Automation");
            wait.Until(ExpectedConditions.ElementToBeClickable(MaleCHKBox)).Click();
            wait.Until(ExpectedConditions.ElementToBeClickable(EnterMobileTXT)).SendKeys("123456789");
            wait.Until(ExpectedConditions.ElementToBeClickable(EnterEmailTXT)).SendKeys("Test@test.com");
            wait.Until(ExpectedConditions.ElementToBeClickable(EnterConnectionTXT)).SendKeys("123");
            Extension.ScrollToEnd(driver);
            wait.Until(ExpectedConditions.ElementToBeClickable(NextBTN)).Click();
        }

        public void UploadIDCard()
        {
            Thread.Sleep(TimeSpan.FromSeconds(1));
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            wait.Until(ExpectedConditions.ElementToBeClickable(UploadBTN)).Click();
            Thread.Sleep(TimeSpan.FromSeconds(1));
            SendKeys.SendWait(@"E:\Futuready\Futuready_Automation\TestData\download.png");
            SendKeys.SendWait(@"{Enter}");
        }

        public void ClickNextBtn()
        {
            Thread.Sleep(TimeSpan.FromSeconds(1));
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            wait.Until(ExpectedConditions.ElementToBeClickable(Next1BTN)).Click();
        }
    }
}
