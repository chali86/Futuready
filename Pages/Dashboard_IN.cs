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
    public class Dashboard_IN
    {
        private IWebDriver driver;

        By SelectToyota = By.XPath("//div[@class='container']/div[1]/div[2]/div[1]/div[2]/div[1]/div[1]/div[1]");
        By ClickYear = By.XPath("//div[@class='container']/div[1]/div[2]/div[1]/div[3]/div[1]/div[1]/div[1]/input");
        By ClickModel = By.XPath("//div[@class='container']/div[1]/div[2]/div[1]/div[4]/div[1]/div[1]/div[1]/input");
        By ClickTotalProtection = By.XPath("//div[@class='container']/div[1]/div[2]/div[1]/div[5]/div[2]/div[2]/div/label");
        By ClickCarAsurence = By.XPath("//div[@class='container']/div[1]/div[2]/div[1]/div[5]/button");
        By Clickcode = By.XPath("//div[@class='container']/div[1]/div[2]/div[1]/div[5]/div[1]/div[2]/div[1]/div[1]/input");
        By ClickJiwaBerjangka = By.XPath("//div[@class='columns is-multiline is-mobile mt-5']/div[9]/div[1]/a/div/button");
        By ClickNext = By.XPath("//div[@class='container']/div[1]/div[2]/div[1]/div[2]/button");
        By ClickDOB = By.XPath("//input[@id='dob']");
        By ClickYearDropDown = By.XPath("//div[@class='pagination-list']/div[1]/div[1]/div[1]/div[2]/span");
        By SelectBirthDate = By.XPath("//div[@class='datepicker-content']/section/div[1]/div[2]/a[3]");
        By ClickConfirmbutton = By.XPath("//div[@class='core-life-search']/form/div[3]/button");
        By TravelBTN= By.XPath("//div[@class='columns is-multiline is-mobile mt-5']/div[8]/div[1]/a/div/button");


        public Dashboard_IN(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void SelectBrand()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            Thread.Sleep(TimeSpan.FromSeconds(2));
            wait.Until(ExpectedConditions.ElementToBeClickable(SelectToyota)).Click();
        }

        public void SelectYear(string Year)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            Thread.Sleep(TimeSpan.FromSeconds(3));
            wait.Until(ExpectedConditions.ElementToBeClickable(ClickYear)).Click();

            IList<IWebElement> YearList = driver.FindElements(By.XPath("//div[@class='container']/div[1]/div[2]/div[1]/div[3]/div[1]/div[1]/div[2]/div[1]/a/span"));
            Thread.Sleep(TimeSpan.FromSeconds(2));
            foreach (IWebElement Years in YearList)
            {
                if (Years.Text.Equals(Year))
                {
                    Years.Click();
                    break;
                }
            }
        }

        public void SelectModel(string Model)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            Thread.Sleep(TimeSpan.FromSeconds(3));
            wait.Until(ExpectedConditions.ElementToBeClickable(ClickModel)).Click();

            IList<IWebElement> ModelList = driver.FindElements(By.XPath("//div[@class='container']/div[1]/div[2]/div[1]/div[4]/div[1]/div[1]/div[2]/div[1]/a/span"));


            foreach (IWebElement Models in ModelList)
            {
                if (Models.Text.Equals(Model))
                {
                    Models.Click();
                    break;
                }
            }
        }

        public void SelectCode(string Code)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            Thread.Sleep(TimeSpan.FromSeconds(3));
            wait.Until(ExpectedConditions.ElementToBeClickable(Clickcode)).Click();

            IList<IWebElement> CodelList = driver.FindElements(By.XPath("//div[@class='container']/div[1]/div[2]/div[1]/div[6]/div[2]/div[1]/section/div[1]/ul/li"));


            foreach (IWebElement Codes in CodelList)
            {
                if (Codes.Text.Equals(Code))
                {
                    Codes.Click();
                    break;
                }
            }
        }

        public void SelectProtection()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            Thread.Sleep(TimeSpan.FromSeconds(2));
            wait.Until(ExpectedConditions.ElementToBeClickable(ClickTotalProtection)).Click();
        }

        public void ClickCarAsurenceButton()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            Thread.Sleep(TimeSpan.FromSeconds(2));
            wait.Until(ExpectedConditions.ElementToBeClickable(ClickCarAsurence)).Click();
        }

        public void SelectJiwaBerjangka()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            Thread.Sleep(TimeSpan.FromSeconds(2));
            wait.Until(ExpectedConditions.ElementToBeClickable(ClickJiwaBerjangka)).Click();
       //     wait.Until(ExpectedConditions.ElementToBeClickable(ClickNext)).Click();
        }

        public void SelectDOBYear(string year)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            Thread.Sleep(TimeSpan.FromSeconds(2));
            wait.Until(ExpectedConditions.ElementToBeClickable(ClickDOB)).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            wait.Until(ExpectedConditions.ElementToBeClickable(ClickYearDropDown)).Click();

            IList<IWebElement> yearlist = driver.FindElements(By.XPath("//div[@class='pagination-list']/div[1]/div[1]/div[1]/div[2]/span/select/option"));


            foreach (IWebElement years in yearlist)
            {
                if (years.Text.Equals(year))
                {
                    years.Click();
                }
            }
        }

        public void SelectDOB()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            Thread.Sleep(TimeSpan.FromSeconds(2));
            wait.Until(ExpectedConditions.ElementToBeClickable(SelectBirthDate)).Click();
            wait.Until(ExpectedConditions.ElementToBeClickable(ClickConfirmbutton)).Click();
        }

        public void ClickTravel()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            Thread.Sleep(TimeSpan.FromSeconds(2));
            wait.Until(ExpectedConditions.ElementToBeClickable(TravelBTN)).Click();
        }
    }
}
