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
    public class UploadDocument
    {
        private IWebDriver driver;

        By ClickUploadButton = By.XPath("//div[@class='fib-form-upload upload2']");
        By ClickNextButton = By.XPath("//div[@class='btn-nav']/button[2]");

        public UploadDocument(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void UploadIDCard()
        {
            Thread.Sleep(TimeSpan.FromSeconds(1));
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            wait.Until(ExpectedConditions.ElementToBeClickable(ClickUploadButton)).Click();
            Thread.Sleep(TimeSpan.FromSeconds(1));
            SendKeys.SendWait(@"E:\Futuready\Futuready_Automation\TestData\download.png");
            SendKeys.SendWait(@"{Enter}");
        }

        public void ClickNextStep()
        {
            Thread.Sleep(TimeSpan.FromSeconds(2));
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            wait.Until(ExpectedConditions.ElementToBeClickable(ClickNextButton)).Click();
        }

    }
}
