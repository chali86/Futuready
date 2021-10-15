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
    public class DetailedPage_IN
    {
        private IWebDriver driver;

        By NameText = By.CssSelector("div[class='field'] input[name='name']");
        By MobileNO = By.CssSelector("div[class='field'] input[name='phone']");
        By Email = By.CssSelector("div[class='field'] input[type='email']");
        By ClickButton = By.CssSelector("div[class='price-button'] button[class='button is-secondary is-fullwidth']");
        By HealthDecleration = By.XPath("//div[@class='container']/div[2]/label[1]");

        public DetailedPage_IN(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void AddDetails()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            Thread.Sleep(TimeSpan.FromSeconds(5));
            wait.Until(ExpectedConditions.ElementToBeClickable(NameText)).SendKeys("Test Automation");
            wait.Until(ExpectedConditions.ElementToBeClickable(MobileNO)).SendKeys("123456789");
            wait.Until(ExpectedConditions.ElementToBeClickable(Email)).SendKeys("Test@gmail.com");
            Thread.Sleep(TimeSpan.FromSeconds(3));
            
        }

        public void ClickHealthDecleration()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(ExpectedConditions.ElementToBeClickable(HealthDecleration)).Click();
        }

        public void ClickNextButton()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(ExpectedConditions.ElementToBeClickable(ClickButton)).Click();
        }

    }
}
