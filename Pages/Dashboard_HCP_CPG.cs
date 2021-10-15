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
    public class Dashboard_HCP_CPG
    {
        private IWebDriver driver;

        By NameTXT = By.CssSelector("div[class='box-border'] input[name='name']");
        By InsuranceFor = By.XPath("//div[@class='box-border']/form/div[2]/div[1]/span");
        By GenderChkBox= By.XPath("//div[@class='box-border']/form/div[4]/div[1]/label[1]/span[1]");
        By IDNoTXT = By.CssSelector("div[class='box-border'] input[name='national_id']");
        By MobileNoTXT = By.CssSelector("div[class='box-border'] input[name='phone']");
        By ProffessionDropDown = By.XPath("//div[@class='box-border']/form/div[7]/div[1]/span");
        By ProvinceDropDown = By.XPath("//div[@class='box-border']/form/div[11]/div[1]/span");
        By CityDropDown = By.XPath("//div[@class='box-border']/form/div[12]/div[1]/span");
        By HomeTownTXT = By.CssSelector("div[class='box-border'] input[name='pob']");
        By DOB = By.CssSelector("div[class='box-border'] input[placeholder='Tanggal Lahir']");
        By AddressTXT = By.CssSelector("div[class='box-border'] textarea[placeholder='Alamat Sesuai KTP']");
        By EmailTXT = By.CssSelector("div[class='box-border'] input[name='email']");
        By PostalCodeTXT = By.CssSelector("div[class='box-border'] input[name='postal_code']");
        By CertifyChkBox = By.XPath("//div[@class='box-border']/div[1]/label/span[1]");
        By AgreeChkBox = By.XPath("//div[@class='box-border']/div[2]/label/span[1]");
        By NextBTN = By.XPath("//div[@class='box-border']/button[1]");
        By PayBTN = By.XPath("//div[@class='container details-covid']/div[2]/div[1]/div[2]/button");

        public Dashboard_HCP_CPG(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void FillDetails()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            wait.Until(ExpectedConditions.ElementToBeClickable(NameTXT)).SendKeys("Test Automation");
            wait.Until(ExpectedConditions.ElementToBeClickable(EmailTXT)).SendKeys("Test@gmail.com");
            wait.Until(ExpectedConditions.ElementToBeClickable(MobileNoTXT)).SendKeys("08123456789");
            wait.Until(ExpectedConditions.ElementToBeClickable(IDNoTXT)).SendKeys("1111111111151");
            wait.Until(ExpectedConditions.ElementToBeClickable(HomeTownTXT)).SendKeys("Test");
            wait.Until(ExpectedConditions.ElementToBeClickable(AddressTXT)).SendKeys("Test Address");
            wait.Until(ExpectedConditions.ElementToBeClickable(PostalCodeTXT)).SendKeys("10160");
            wait.Until(ExpectedConditions.ElementToBeClickable(GenderChkBox)).Click();
        }

        public void ClickAgree()
        {
            Thread.Sleep(TimeSpan.FromSeconds(2));
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            wait.Until(ExpectedConditions.ElementToBeClickable(CertifyChkBox)).Click();
            wait.Until(ExpectedConditions.ElementToBeClickable(AgreeChkBox)).Click();
        }

        public void SelectDOB()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            wait.Until(ExpectedConditions.ElementToBeClickable(DOB)).Click();
            wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//div[@class='dropdown-menu']/div[1]/div[1]/div[1]/div[1]/section/div[1]/div[2]/a[4]"))).Click();
        }

        public void SelectInsurance(string Insurance)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            Thread.Sleep(TimeSpan.FromSeconds(2));
            wait.Until(ExpectedConditions.ElementToBeClickable(InsuranceFor)).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));

            IList<IWebElement> Insurancelist = driver.FindElements(By.XPath("//div[@class='box-border']/form/div[2]/div[1]/span/select/option"));


            foreach (IWebElement Insurances in Insurancelist)
            {
                if (Insurances.Text.Equals(Insurance))
                {
                    Insurances.Click();
                }
            }
        }

        public void SelectProffession(string Proffession)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            Thread.Sleep(TimeSpan.FromSeconds(2));
            wait.Until(ExpectedConditions.ElementToBeClickable(ProffessionDropDown)).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));

            IList<IWebElement> Proffessionlist = driver.FindElements(By.XPath("//div[@class='box-border']/form/div[7]/div[1]/span/select/option"));


            foreach (IWebElement Proffessions in Proffessionlist)
            {
                if (Proffessions.Text.Equals(Proffession))
                {
                    Proffessions.Click();
                }
            }
        }

        public void SelectProvince(string Province)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            Thread.Sleep(TimeSpan.FromSeconds(2));
            wait.Until(ExpectedConditions.ElementToBeClickable(ProvinceDropDown)).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));

            IList<IWebElement> Provincelist = driver.FindElements(By.XPath("//div[@class='box-border']/form/div[11]/div[1]/span/select/option"));


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
            wait.Until(ExpectedConditions.ElementToBeClickable(CityDropDown)).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));

            IList<IWebElement> Citylist = driver.FindElements(By.XPath("//div[@class='box-border']/form/div[12]/div[1]/span/select/option"));


            foreach (IWebElement Citys in Citylist)
            {
                if (Citys.Text.Equals(City))
                {
                    Citys.Click();
                }
            }
        }

        public void ClickNextButton()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            wait.Until(ExpectedConditions.ElementToBeClickable(NextBTN)).Click();
        }

        public void ClickPayButton()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            wait.Until(ExpectedConditions.ElementToBeClickable(PayBTN)).Click();
        }
    }
}

