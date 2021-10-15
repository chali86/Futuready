using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Futuready_Automation.Utils;

namespace Futuready_Automation.Pages
{
   public class Onboarding_Travel_IN
   {
        private IWebDriver driver;

        By EnterPassportNo = By.CssSelector("div[class='control is-clearfix'] input[name='passport_number']");
        By EnterPlaceOfBirth = By.CssSelector("div[class='field column is-full'] input[name='birth_place']");
        By EnterKTP = By.CssSelector("div[class='field column is-6'] input[name='national_id']");
        By EnterStatus = By.XPath("//option[@value='single'] //ancestor::span");
        By ClickProfession = By.XPath("//option[@value='Accounting Manager'] //ancestor::span");
        By EnterAddress = By.CssSelector("div[class='field column is-full'] textarea[placeholder='Masukkan alamat sesuai KTP']");
        By EnterProvince = By.XPath("//option[@value='DKI JAKARTA'] //ancestor::span");
        By EnterCity = By.XPath("//option[@value='Kabupaten Administrasi Kepulauan Seribu'] //ancestor::span");
        By EnterPostalCodeTXT = By.CssSelector("div[class='field column is-full'] input[name='postal_code']");
        By ClickCalender = By.XPath("//div[@class='field column is-full']/div[1]/div[1]/div[1]/div[1]/input");
        By PickDate = By.XPath("//div[@class='field column is-full']/div[1]/div[1]/div[3]/div[1]/div[1]/div[1]/div[1]/section/div[1]/div[2]/a[4]");
        By ClickNextButton = By.XPath("//div[@class='columns is-mobile is-centered']/div[1]/div[1]/div[1]/button");
        By FirstInsuredPersonNameTXTBOX = By.CssSelector("div[class='field column column is-full'] input[name='insured_person_first_name_0']");
        By FirstInsuredPersonGenderCHKBOX = By.XPath("//div[@class='container']/div[1]/div[1]/div[2]/form/div[3]/div[1]/label[1]/span[1]");
        By FirstInsuredPersonDOB = By.XPath("//div[@class='container']/div[1]/div[1]/div[2]/form/div[4]/div[1]/div[1]/div[1]/div[1]/input");
        By FirstInsuredPersonDOBPckDate = By.XPath("//div[@class='container']/div[1]/div[1]/div[2]/form/div[4]/div[1]/div[1]/div[3]/div[1]/div[1]/div[1]/div[1]/section/div[1]/div[2]/a[4]");
        By FirstInsuredPersonRelationshipDropDWN = By.XPath("//div[@class='container']/div[1]/div[1]/div[2]/form/div[5]/div[1]/span");
        By SecondInsuredPersonNameTXTBOX = By.CssSelector("div[class='field column column is-full'] input[name='insured_person_first_name_1']");
        By SecondInsuredPersonGenderCHKBOX = By.XPath("//div[@class='container']/div[1]/div[1]/div[2]/form/div[8]/div[1]/label[1]/span[1]");
        By SecondInsuredPersonDOB = By.XPath("//div[@class='container']/div[1]/div[1]/div[2]/form/div[9]/div[1]/div[1]/div[1]/div[1]/input");
        By SecondInsuredPersonDOBPckDate = By.XPath("//div[@class='container']/div[1]/div[1]/div[2]/form/div[9]/div[1]/div[1]/div[3]/div[1]/div[1]/div[1]/div[1]/section/div[1]/div[2]/a[4]");
        By SecondInsuredPersonRelationshipDropDWN = By.XPath("//div[@class='container']/div[1]/div[1]/div[2]/form/div[10]/div[1]/span");
        By ClickSecondNextButton = By.XPath("//div[@class='container']/div[1]/div[1]/div[2]/div[1]/button");

        public Onboarding_Travel_IN(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void FillOnboardingForm()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            Thread.Sleep(TimeSpan.FromSeconds(3));
            Extension.ScrollDown(driver);
            wait.Until(ExpectedConditions.ElementToBeClickable(EnterKTP)).SendKeys("123456789");
            Extension.ScrollDown(driver);
            wait.Until(ExpectedConditions.ElementToBeClickable(ClickCalender)).Click();
            wait.Until(ExpectedConditions.ElementToBeClickable(PickDate)).Click();
            wait.Until(ExpectedConditions.ElementToBeClickable(EnterPlaceOfBirth)).SendKeys("Jakarta");
        }

        public void EnterPassport() 
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            wait.Until(ExpectedConditions.ElementToBeClickable(EnterPassportNo)).SendKeys("123456789");
        }

        public void EnterPostalCode()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            wait.Until(ExpectedConditions.ElementToBeClickable(EnterPostalCodeTXT)).SendKeys("10160");
            
        }

        public void SelectStatus(string Status)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            Thread.Sleep(TimeSpan.FromSeconds(2));
            wait.Until(ExpectedConditions.ElementToBeClickable(EnterStatus)).Click();

            IList<IWebElement> Statuslist = driver.FindElements(By.XPath("//option[@value='single'] //ancestor::span/select/option"));


            foreach (IWebElement stat in Statuslist)
            {
                if (stat.Text.Equals(Status))
                {
                    stat.Click();
                }
            }
        }

        public void SelectProffession(string Profession)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            Thread.Sleep(TimeSpan.FromSeconds(2));
            wait.Until(ExpectedConditions.ElementToBeClickable(ClickProfession)).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));

            IList<IWebElement> Professionlist = driver.FindElements(By.XPath("//option[@value='Accounting Manager'] //ancestor::span/select/option"));


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

            IList<IWebElement> Provincelist = driver.FindElements(By.XPath("//option[@value='DKI JAKARTA'] //ancestor::span/select/option"));


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

            IList<IWebElement> Citylist = driver.FindElements(By.XPath("//option[@value='Kabupaten Administrasi Kepulauan Seribu'] //ancestor::span/select/option"));


            foreach (IWebElement Citys in Citylist)
            {
                if (Citys.Text.Equals(City))
                {
                    Citys.Click();
                }
            }
        }

        

        public void ClickNext()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            wait.Until(ExpectedConditions.ElementToBeClickable(ClickNextButton)).Click();
        }

        public void FillFirstInsuredDetail()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            Thread.Sleep(TimeSpan.FromSeconds(3));
            Extension.ScrollDown(driver);
            wait.Until(ExpectedConditions.ElementToBeClickable(FirstInsuredPersonNameTXTBOX)).SendKeys("Test 1");
            wait.Until(ExpectedConditions.ElementToBeClickable(FirstInsuredPersonGenderCHKBOX)).Click();
            wait.Until(ExpectedConditions.ElementToBeClickable(FirstInsuredPersonDOB)).Click();
            wait.Until(ExpectedConditions.ElementToBeClickable(FirstInsuredPersonDOBPckDate)).Click();
        }

        public void SelectFirstInsuredPersonRelationship(string Relationship)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            Thread.Sleep(TimeSpan.FromSeconds(2));
            wait.Until(ExpectedConditions.ElementToBeClickable(FirstInsuredPersonRelationshipDropDWN)).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));

            IList<IWebElement> Relationshiplist = driver.FindElements(By.XPath("//div[@class='container']/div[1]/div[1]/div[2]/form/div[5]/div[1]/span/select/option"));


            foreach (IWebElement Relationships in Relationshiplist)
            {
                if (Relationships.Text.Equals(Relationship))
                {
                    Relationships.Click();
                }
            }
        }

        public void FillSecondInsuredDetail()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            Extension.ScrollToEnd(driver);
            wait.Until(ExpectedConditions.ElementToBeClickable(SecondInsuredPersonNameTXTBOX)).SendKeys("Test 2");
            wait.Until(ExpectedConditions.ElementToBeClickable(SecondInsuredPersonGenderCHKBOX)).Click();
            wait.Until(ExpectedConditions.ElementToBeClickable(SecondInsuredPersonDOB)).Click();
            wait.Until(ExpectedConditions.ElementToBeClickable(SecondInsuredPersonDOBPckDate)).Click();
        }

        public void SelectSecondInsuredPersonRelationship(string Relationship)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            Thread.Sleep(TimeSpan.FromSeconds(2));
            wait.Until(ExpectedConditions.ElementToBeClickable(SecondInsuredPersonRelationshipDropDWN)).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));

            IList<IWebElement> Relationshiplist = driver.FindElements(By.XPath("//div[@class='container']/div[1]/div[1]/div[2]/form/div[10]/div[1]/span/select/option"));


            foreach (IWebElement Relationships in Relationshiplist)
            {
                if (Relationships.Text.Equals(Relationship))
                {
                    Relationships.Click();
                }
            }
        }

        public void ClickSecondNext()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            wait.Until(ExpectedConditions.ElementToBeClickable(ClickSecondNextButton)).Click();
        }

    }
}
