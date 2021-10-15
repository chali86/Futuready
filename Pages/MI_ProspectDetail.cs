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
    public class MI_ProspectDetail
    {
        private IWebDriver driver;

        By FirstNameText = By.XPath("//div[@class='column is-full-mobile']/div[1]/div[1]/div[1]/div[1]/input");
        By LastNameText = By.XPath("//div[@class='column is-full-mobile']/div[1]/div[2]/div[1]/div[1]/input");
        By ThaiFirstNameText = By.XPath("//div[@class='column is-full-mobile']/div[2]/div[1]/div[1]/div[1]/input");
        By ThaiLastNameText = By.XPath("//div[@class='column is-full-mobile']/div[2]/div[2]/div[1]/div[1]/input");
        By MobileNO = By.XPath("//div[@class='column is-full-mobile']/div[3]/div[1]/div[1]/div[1]/div[1]/input");
        By Email = By.XPath("//div[@class='column is-full-mobile']/div[3]/div[2]/div[1]/div[1]/input");
        By ClickRefer = By.XPath("//div[@class='column is-full-mobile']/div[5]/button");

        public MI_ProspectDetail(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void AddDetails()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            Thread.Sleep(TimeSpan.FromSeconds(5));
            wait.Until(ExpectedConditions.ElementToBeClickable(FirstNameText)).SendKeys("Test");
            wait.Until(ExpectedConditions.ElementToBeClickable(LastNameText)).SendKeys("Automation");
            wait.Until(ExpectedConditions.ElementToBeClickable(ThaiFirstNameText)).SendKeys("Test");
            wait.Until(ExpectedConditions.ElementToBeClickable(ThaiLastNameText)).SendKeys("Automation");
            wait.Until(ExpectedConditions.ElementToBeClickable(MobileNO)).SendKeys("123456789");
            wait.Until(ExpectedConditions.ElementToBeClickable(Email)).SendKeys("futureadyautomation@gmail.com");
            Thread.Sleep(TimeSpan.FromSeconds(5));
            wait.Until(ExpectedConditions.ElementToBeClickable(ClickRefer)).Click();
            Thread.Sleep(TimeSpan.FromSeconds(5));
        }

    }
}
