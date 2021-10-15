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
    public class ProspectDetail
    {
        private IWebDriver driver;

        By FirstNameText = By.XPath("//div[@class='column is-full-mobile']/div[2]/div[1]/div[1]/div[1]/input");
        By LastNameText = By.XPath("//div[@class='column is-full-mobile']/div[2]/div[2]/div[1]/div[1]/input");
        By MobileNO = By.XPath("//div[@class='column is-full-mobile']/div[4]/div[1]/div[1]/div[1]/div[1]/input");
        By Email = By.XPath("//div[@class='column is-full-mobile']/div[4]/div[2]/div[1]/div[1]/input");
        By ClickReferBTN = By.XPath("//div[@class='column is-full-mobile']/div[6]/div[1]/button");
        By CalenderBTN = By.XPath("//div[@class='container']/div[1]/div[2]/div[5]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/input");
        By DateBTN = By.XPath("//div[@class='container']/div[1]/div[2]/div[5]/div[1]/div[1]/div[1]/div[1]/div[3]/div[1]/div[1]/div[1]/div[1]/section/div[1]/div[2]/a[4]");
        By ClickReferBTN1 = By.XPath("//div[@class='column is-full-mobile']/div[7]/button");

        public ProspectDetail(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void AddDetails()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            Thread.Sleep(TimeSpan.FromSeconds(5));
            wait.Until(ExpectedConditions.ElementToBeClickable(FirstNameText)).SendKeys("Test");
            wait.Until(ExpectedConditions.ElementToBeClickable(LastNameText)).SendKeys("Automation");
            wait.Until(ExpectedConditions.ElementToBeClickable(MobileNO)).SendKeys("123456789");
            wait.Until(ExpectedConditions.ElementToBeClickable(Email)).SendKeys("futureadyautomation@gmail.com");
            Extension.ScrollToEnd(driver);
            Thread.Sleep(TimeSpan.FromSeconds(5));
        }

        public void ClickRefer()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            wait.Until(ExpectedConditions.ElementToBeClickable(ClickReferBTN)).Click();
            Thread.Sleep(TimeSpan.FromSeconds(5));
        }

        public void ClickReferForTravel()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            wait.Until(ExpectedConditions.ElementToBeClickable(ClickReferBTN1)).Click();
            Thread.Sleep(TimeSpan.FromSeconds(5));
        }

        public void SelectDOB()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            wait.Until(ExpectedConditions.ElementToBeClickable(CalenderBTN)).Click();
            wait.Until(ExpectedConditions.ElementToBeClickable(DateBTN)).Click();
        }
    }
}
