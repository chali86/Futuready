using Microsoft.VisualStudio.TestTools.UnitTesting;
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
    public class Onboarding_IN
    {
        private IWebDriver driver;

        By EnterPlaceOfBirth = By.CssSelector("div[class='field'] input[name='pob']");
        By EnterCitizen = By.XPath("//form[@class='fib-form-builder']/div[3]/div[1]/label[1]");
        By EnterKTP = By.CssSelector("div[class='field'] input[name='ktp']");
        By EnterStatus = By.XPath("//form[@class='fib-form-builder']/div[5]/div[1]/span");
        By SelectMale = By.XPath("//form[@class='fib-form-builder']/div[5]/div[1]/span/select/option[2]");
        By ClickProfession = By.XPath("//form[@class='fib-form-builder']/div[6]/div[1]/span");
        By EnterAddress = By.CssSelector("div[class='field'] textarea[placeholder='Alamat']");
        By EnterProvince = By.XPath("//form[@class='fib-form-builder']/div[8]/div[1]/span");
        By EnterCity = By.XPath("//form[@class='fib-form-builder']/div[9]/div[1]/span");
        By EnterRT = By.CssSelector("div[class='field'] input[placeholder='RT']");
        By EnterRW = By.CssSelector("div[class='field'] input[placeholder='RW']");
        By EntderPostalCode = By.CssSelector("div[class='field'] input[placeholder='Kode Pos']");
        By ClickCalender = By.XPath("//form[@class='fib-form-builder']/div[13]/div[1]/div[1]/div[1]");
        By PickDate = By.XPath("//div[@class='dropdown-menu' and @style='']/div[1]/div[1]/div[1]/div[1]/section/div[1]/div[2]/a[3]");
        By ClickNextButton = By.XPath("//div[@class='container']/div[1]/div[1]/div[1]/div[1]/button");

        public Onboarding_IN(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void FillOnboardingForm()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            Thread.Sleep(TimeSpan.FromSeconds(3));
            wait.Until(ExpectedConditions.ElementToBeClickable(EnterPlaceOfBirth)).SendKeys("Jakarta");
            wait.Until(ExpectedConditions.ElementToBeClickable(EnterCitizen)).Click();
            wait.Until(ExpectedConditions.ElementToBeClickable(EnterKTP)).SendKeys("123");
            wait.Until(ExpectedConditions.ElementToBeClickable(EnterStatus)).Click();
            wait.Until(ExpectedConditions.ElementToBeClickable(SelectMale)).Click();

        }

        public void SelectProffession(string Profession)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            Thread.Sleep(TimeSpan.FromSeconds(2));
            wait.Until(ExpectedConditions.ElementToBeClickable(ClickProfession)).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));

            IList<IWebElement> Professionlist = driver.FindElements(By.XPath("//form[@class='fib-form-builder']/div[6]/div[1]/span/select/option"));


            foreach (IWebElement Professions in Professionlist)
            {
                if (Professions.Text.Equals(Profession))
                {
                    Professions.Click();
                }
            }
        }

        public void FillAddress()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            wait.Until(ExpectedConditions.ElementToBeClickable(EnterAddress)).SendKeys("Test Address");
        }

        public void SelectProvince(string Province)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            Thread.Sleep(TimeSpan.FromSeconds(2));
            wait.Until(ExpectedConditions.ElementToBeClickable(EnterProvince)).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));

            IList<IWebElement> Provincelist = driver.FindElements(By.XPath("//form[@class='fib-form-builder']/div[8]/div[1]/span/select/option"));


            foreach (IWebElement Provinces in Provincelist)
            {
                if (Provinces.Text.Equals(Province))
                {
                    Provinces.Click();
                }
            }
        }

        public void SelectCity(string City)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            Thread.Sleep(TimeSpan.FromSeconds(2));
            wait.Until(ExpectedConditions.ElementToBeClickable(EnterCity)).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));

            IList<IWebElement> Citylist = driver.FindElements(By.XPath("//form[@class='fib-form-builder']/div[9]/div[1]/span/select/option"));


            foreach (IWebElement Citys in Citylist)
            {
                if (Citys.Text.Equals(City))
                {
                    Citys.Click();
                }
            }
        }

        public void EnterValues()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            wait.Until(ExpectedConditions.ElementToBeClickable(EnterRT)).SendKeys("1");
            wait.Until(ExpectedConditions.ElementToBeClickable(EnterRW)).SendKeys("1");
            wait.Until(ExpectedConditions.ElementToBeClickable(EntderPostalCode)).SendKeys("10160");
            wait.Until(ExpectedConditions.ElementToBeClickable(ClickCalender)).Click();
            wait.Until(ExpectedConditions.ElementToBeClickable(PickDate)).Click();
        }

        public void ClickNext()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            wait.Until(ExpectedConditions.ElementToBeClickable(ClickNextButton)).Click();
        }

        public bool VerifyValidation()
        {
            bool isDisplayed = false;
            string ExpectedMSG = "Wajib diisi";

            for (int i = 2; i < 15; i++)
            {
                IWebElement searchInput = driver.FindElement(By.XPath("//div[@class='container']/div[1]/div[1]/div[1]/form/div["+i+"]/p/div[1]"));

                if (searchInput.Text.Equals(ExpectedMSG))
                {
                    isDisplayed = true;
                }

            }

            return isDisplayed;
        }
    }
}
