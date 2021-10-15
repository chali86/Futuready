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
    public class Plan_IN
    {
        private IWebDriver driver;

        By ClickSelectPlan = By.XPath("//div[@class='columns is-mobile']/div[2]/div[2]/div[1]/div[1]/div[1]/div[4]/div[1]/button");
        By ConfirmPlan = By.CssSelector("div[class='price-button'] button[class='button is-secondary is-fullwidth']");
        By ClickJiwaBerjangkaPlan = By.XPath("//div[@class='column']/div[2]/div[1]/div[1]/div[1]/div[4]/div/button");

        public Plan_IN(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void SelectPlan()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            wait.Until(ExpectedConditions.ElementToBeClickable(ClickSelectPlan)).Click();
        }

        public void ClickConfirmPlan()
        {
            Thread.Sleep(TimeSpan.FromSeconds(5));
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            wait.Until(ExpectedConditions.ElementToBeClickable(ConfirmPlan)).Click();
        }

        public void SelectJiwaBerjangkaPlan()
        {
            Thread.Sleep(TimeSpan.FromSeconds(5));
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            wait.Until(ExpectedConditions.ElementToBeClickable(ClickJiwaBerjangkaPlan)).Click();
        }
    }
}
