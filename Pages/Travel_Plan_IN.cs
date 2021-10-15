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
    public class Travel_Plan_IN
    {
        private IWebDriver driver;

        By TravelTypeDropDWN = By.XPath("//div[@class='container']/div[1]/div[2]/div[1]/div[2]/div[1]/div[1]/span");
        By DestinationDropDown = By.CssSelector("div[class='field'] input[placeholder='Negara / Kota']");
        By IndiVidualCHKBox = By.XPath("//div[@class='container']/div[1]/div[2]/div[1]/div[3]/div[1]/label/span[1]");
        By TwoPersonCHKBox = By.XPath("//div[@class='container']/div[1]/div[2]/div[1]/div[3]/div[2]/label/span[1]");
        By FamilyCHKBox = By.XPath("//div[@class='container']/div[1]/div[2]/div[1]/div[3]/div[3]/label/span[1]");
        By CarryOnBTN = By.XPath("//div[@class='container']/div[1]/div[2]/div[1]/button");
        By InDateInput = By.XPath("//div[@class='column is-full-mobile is-three-fifths-tablet']/div[1]/div[4]/div[2]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/input");
        By PickInDate = By.XPath("//div[@config='[object Object]']/div[4]/div[2]/div[1]/div[1]/div[1]/div[1]/div[3]/div[1]/div[1]/div[1]/div[1]/section/div[1]/div[5]/a[1]");
        By OutDateInput = By.XPath("//div[@config='[object Object]']/div[4]/div[2]/div[2]/div[1]/div[1]/div[1]/div[1]/div[1]/input");
        By PickOutDate = By.XPath("//div[@config='[object Object]']/div[4]/div[2]/div[2]/div[1]/div[1]/div[1]/div[3]/div[1]/div[1]/div[1]/div[1]/section/div[1]/div[5]/a[2]");
        By PlanBTN = By.XPath("//div[@class='column']/div[2]/div[1]/div[1]/div[1]/div[4]/div[1]/button");
        By BuyInsuranceBTN = By.XPath("//div[@class='wrapper']/div[1]/div[1]/div[2]/div[2]/button");
        By PeopleCountTXTBox = By.XPath("//div[@class='mb-2']/div[1]/div[1]/div[1]/input");
        By ChildCountTXTBox = By.XPath("//div[@class='mb-2']/div[2]/div[1]/div[1]/input");


        public Travel_Plan_IN(IWebDriver driver)
        {
            this.driver = driver;

        }

        public void SelectTravelType(string Type)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            Thread.Sleep(TimeSpan.FromSeconds(3));
            wait.Until(ExpectedConditions.ElementToBeClickable(TravelTypeDropDWN)).Click();

            IList<IWebElement> TravelTypeList = driver.FindElements(By.XPath("//div[@class='container']/div[1]/div[2]/div[1]/div[2]/div[1]/div[1]/span/select/option"));
            Thread.Sleep(TimeSpan.FromSeconds(2));
            foreach (IWebElement TravelTypes in TravelTypeList)
            {
                if (TravelTypes.Text.Equals(Type))
                {
                    TravelTypes.Click();
                    break;
                }
            }
        }

        public void SelectDestination(string Destination)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            Thread.Sleep(TimeSpan.FromSeconds(3));
            wait.Until(ExpectedConditions.ElementToBeClickable(DestinationDropDown)).SendKeys("s");

            IList<IWebElement> DestinationList = driver.FindElements(By.XPath("//div[@class='container']/div[1]/div[2]/div[1]/div[2]/div[2]/div[1]/div[1]/div[1]/div[2]/div[1]/a"));
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

        public void SelectIndividual()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            wait.Until(ExpectedConditions.ElementToBeClickable(IndiVidualCHKBox)).Click();
        }

        public void SelectDuo()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            wait.Until(ExpectedConditions.ElementToBeClickable(TwoPersonCHKBox)).Click();
        }

        public void SelectFamily()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            wait.Until(ExpectedConditions.ElementToBeClickable(FamilyCHKBox)).Click();
        }

        public void ClickCarryOn()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            wait.Until(ExpectedConditions.ElementToBeClickable(CarryOnBTN)).Click();
        }

        public void SelectInDate()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            wait.Until(ExpectedConditions.ElementToBeClickable(InDateInput)).Click();
            wait.Until(ExpectedConditions.ElementToBeClickable(PickInDate)).Click();
        }

        public void SelectOutDate()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            wait.Until(ExpectedConditions.ElementToBeClickable(OutDateInput)).Click();
            wait.Until(ExpectedConditions.ElementToBeClickable(PickOutDate)).Click();
        }

        public void SelectPlan()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            wait.Until(ExpectedConditions.ElementToBeClickable(PlanBTN)).Click();
        }

        public void SelectBuyInsurence()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            wait.Until(ExpectedConditions.ElementToBeClickable(BuyInsuranceBTN)).Click();
        }
        public void EnterPeopleCount(string count)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            wait.Until(ExpectedConditions.ElementToBeClickable(PeopleCountTXTBox)).Click();
            wait.Until(ExpectedConditions.ElementToBeClickable(PeopleCountTXTBox)).SendKeys(Keys.Control + "a");
            wait.Until(ExpectedConditions.ElementToBeClickable(PeopleCountTXTBox)).SendKeys(count);
        }

        public void EnterChildCount(string count)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            wait.Until(ExpectedConditions.ElementToBeClickable(ChildCountTXTBox)).Click();
            wait.Until(ExpectedConditions.ElementToBeClickable(ChildCountTXTBox)).SendKeys(Keys.Control + "a");
            wait.Until(ExpectedConditions.ElementToBeClickable(ChildCountTXTBox)).SendKeys(count);
        }
    }
}
