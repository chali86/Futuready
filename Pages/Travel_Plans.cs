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
    public class Travel_Plans
    {
        private IWebDriver driver;

        By DestinationDropDown = By.XPath("//div[@class='container']/div[1]/div[2]/div[1]/div[1]/div[1]/input");
        By SingleTripCHKBox = By.XPath("//div[@class='container']/div[1]/div[2]/div[2]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]");
        By MultiTripCHKBox = By.XPath("//div[@class='container']/div[1]/div[2]/div[2]/div[1]/div[1]/div[1]/div[1]/div[1]/div[2]");
        By CountTXTBox = By.XPath("//div[@class='container']/div[1]/div[2]/div[4]/div[1]/div[1]/div[1]/div[1]/input");
        By SearchPlanBTN = By.XPath("//div[@class='container']/div[1]/div[2]/div[4]/div[1]/div[2]/button");
        By SelectPlanBTN = By.XPath("//div[@class='column']/div[2]/div[1]/div[1]/div[1]/div[5]/div[1]/button");

        public Travel_Plans(IWebDriver driver)
        {
            this.driver = driver;

        }

        public void SelectDestination(string Destination)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            Thread.Sleep(TimeSpan.FromSeconds(3));
            wait.Until(ExpectedConditions.ElementToBeClickable(DestinationDropDown)).Click();

            IList<IWebElement> DestinationList = driver.FindElements(By.XPath("//div[@class='container']/div[1]/div[2]/div[1]/div[1]/div[2]/div[1]/a"));
            Thread.Sleep(TimeSpan.FromSeconds(2));
            foreach (IWebElement Destinations in DestinationList)
            {
                if (Destinations.Text.Equals(Destination))
                {
                    Destinations.Click();
                    break;
                }
            }
        }

        public void ClickMultiTrip()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            wait.Until(ExpectedConditions.ElementToBeClickable(MultiTripCHKBox)).Click();
        }

        public void PasengerCount(string count)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            wait.Until(ExpectedConditions.ElementToBeClickable(CountTXTBox)).SendKeys(Keys.Backspace);
            wait.Until(ExpectedConditions.ElementToBeClickable(CountTXTBox)).SendKeys(count);
        }

        public void ClickSearchPlan()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            wait.Until(ExpectedConditions.ElementToBeClickable(SearchPlanBTN)).Click();
        }

        public void SelectPlan()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(ExpectedConditions.ElementToBeClickable(SelectPlanBTN)).Click();
        }
    }
}
