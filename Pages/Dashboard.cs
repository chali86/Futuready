using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Futuready_Automation.Pages
{
    public class Dashboard
    {
        private IWebDriver driver;

        By SelectCovi19 = By.XPath("//div[@class='dashboard']/main/section[2]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]");
        By MotorBTN = By.XPath("//div[@class='dashboard']/main/section[2]/div[1]/div[2]/div[1]/div[1]/div[1]");
        By TravelBTN = By.XPath("//div[@class='dashboard']/main/section[2]/div[1]/div[2]/div[1]/div[1]/div[5]");
        

        public Dashboard(IWebDriver driver)
        {
            this.driver = driver;
            
        }

        public void ClickCovid19()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            wait.Until(ExpectedConditions.ElementToBeClickable(SelectCovi19)).Click();
        }

        public void ClickMotor()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            wait.Until(ExpectedConditions.ElementToBeClickable(MotorBTN)).Click();
        }

        public void ClickTravel()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            wait.Until(ExpectedConditions.ElementToBeClickable(TravelBTN)).Click();
        }
    }
}
