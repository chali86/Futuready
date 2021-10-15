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
    public class Plan
    {
        private IWebDriver driver;

        By ClickCalender = By.XPath("//div[@class='container']/div[1]/div[2]/form/div[1]/div[1]/div[1]/div[1]/div[1]/input");
        By selectDate = By.XPath("//div[@class='datepicker-content']/section/div[1]/div[2]/a[1]");
        By SearchPlans = By.XPath("//div[@class='field mt-4']/div[1]/button");
        By ClickSelectPlan = By.XPath("//div[@class='column']/div[2]/div[1]/div[1]/div[1]/div[5]/div[1]/button");
        By ConfirmPlan = By.CssSelector("div[class='container wrapper-recommend-plan'] button[class='button is-primary is-fullwidth']");

        public Plan(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void SelectDateOfBirth()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(ExpectedConditions.ElementToBeClickable(ClickCalender)).Click();
            wait.Until(ExpectedConditions.ElementToBeClickable(selectDate)).Click();
        }

        public void ClickSearchPlan()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(ExpectedConditions.ElementToBeClickable(SearchPlans)).Click();
        }

        public void SelectPlan()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(ExpectedConditions.ElementToBeClickable(ClickSelectPlan)).Click();
        }

        public void ClickConfirmPlan()
        {
            Thread.Sleep(TimeSpan.FromSeconds(5));
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(ExpectedConditions.ElementToBeClickable(ConfirmPlan)).Click();
        }
    }
}
