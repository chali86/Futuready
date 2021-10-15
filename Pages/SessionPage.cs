using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Futuready_Automation.Pages
{
    public class SessionPage
    {
        private IWebDriver driver;

        By SessionIDTXTBox = By.CssSelector("div[class='login-form show'] input[name='password']");
        By SubmitBTN = By.CssSelector("div[class='login-form show'] button[type='submit']");
        By PlanBTN = By.XPath("//section[@id='content-heading']/section[1]/section/div[1]/form/button");

        public SessionPage(IWebDriver driver)
        {
            this.driver = driver;

        }

        public void EnterSessionID(string sessionid)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            wait.Until(ExpectedConditions.ElementToBeClickable(SessionIDTXTBox)).SendKeys(sessionid);
            wait.Until(ExpectedConditions.ElementToBeClickable(SubmitBTN)).Click();
        }

        public void SelectPlan()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            wait.Until(ExpectedConditions.ElementToBeClickable(PlanBTN)).Click();
        }

    }
}
