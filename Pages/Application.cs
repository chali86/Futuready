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
    public class Application
    {
        private IWebDriver driver;

        By ClickTitle = By.XPath("//div[@class='control title-style']/span/select/option[2]");
        By SelectTitle = By.XPath("//div[@class='control title-style']/span/select/option[2]");
        By SelectCountry = By.XPath("//div[@class='control nationality-style']/span/select//option[2]");
        By NationalIDTXT = By.XPath("//input[@name='national_id']");
        By WeightTXT = By.XPath("//input[@name='weight']");
        By HeightTXT = By.XPath("//input[@name='height']");
        By AddressTXT = By.XPath("//input[@name='address']");
        By RoadTXT = By.XPath("//input[@name='road']");
        By SelectProvince = By.XPath("//div[@class='control province-style']/span/select/option[4]");
        By SelectDistrict = By.XPath("//div[@class='control district-style']/span/select/option[3]");
        By SelectSubDistrict = By.XPath("//div[@class='control sub_district-style']/span/select/option[3]");
        By SelectOccupation = By.XPath("//div[@class='control occupation-style']/span/select/option[12]");
        By SelectRelationship = By.XPath("//div[@class='control beneficiary_relation-style']/span/select/option[7]");
        By SelectRelationshipTitle = By.XPath("//div[@class='control beneficiary_title-style']/span/select/option[3]");
        By SelectRelationshipFName = By.XPath("//input[@name='beneficiary_first_name']");
        By SelectRelationshipLName = By.XPath("//input[@name='beneficiary_last_name']");
        By ClickNextButton = By.XPath("//div[@class='btn-nav']/button[2]");
        By ClickConfirmButton = By.XPath("//div[@class='has-text-centered mt-4']/button");
        By OTPTxt1 = By.XPath("//div[@class='container']/div[2]/div[1]/div[1]/span/div[1]/input");
        By OTPTxt2 = By.XPath("//div[@class='container']/div[2]/div[1]/div[1]/span/div[2]/input");
        By OTPTxt3 = By.XPath("//div[@class='container']/div[2]/div[1]/div[1]/span/div[3]/input");
        By OTPTxt4 = By.XPath("//div[@class='container']/div[2]/div[1]/div[1]/span/div[4]/input");
        By OTPTxt5 = By.XPath("//div[@class='container']/div[2]/div[1]/div[1]/span/div[5]/input");
        By OTPTxt6 = By.XPath("//div[@class='container']/div[2]/div[1]/div[1]/span/div[6]/input");
        By ClickSubmit = By.CssSelector("div[class='field mt-5'] button");

        public Application(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void FillApplication()
        {
            Thread.Sleep(TimeSpan.FromSeconds(3));
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(ExpectedConditions.ElementToBeClickable(ClickTitle)).Click();
            wait.Until(ExpectedConditions.ElementToBeClickable(SelectTitle)).Click();
            wait.Until(ExpectedConditions.ElementToBeClickable(SelectCountry)).Click();
            wait.Until(ExpectedConditions.ElementToBeClickable(NationalIDTXT)).SendKeys("1111111111151");
            wait.Until(ExpectedConditions.ElementToBeClickable(WeightTXT)).SendKeys("55");
            wait.Until(ExpectedConditions.ElementToBeClickable(HeightTXT)).SendKeys("6");
            Extension.ScrollDown(driver);
            wait.Until(ExpectedConditions.ElementToBeClickable(AddressTXT)).SendKeys("364 Test Address");
            wait.Until(ExpectedConditions.ElementToBeClickable(RoadTXT)).SendKeys("Test Road");
            wait.Until(ExpectedConditions.ElementToBeClickable(SelectProvince)).Click();
            wait.Until(ExpectedConditions.ElementToBeClickable(SelectDistrict)).Click();
            wait.Until(ExpectedConditions.ElementToBeClickable(SelectSubDistrict)).Click();
            Extension.ScrollDown(driver);
            wait.Until(ExpectedConditions.ElementToBeClickable(SelectOccupation)).Click();
            wait.Until(ExpectedConditions.ElementToBeClickable(SelectRelationship)).Click();
            wait.Until(ExpectedConditions.ElementToBeClickable(SelectRelationshipTitle)).Click();
            wait.Until(ExpectedConditions.ElementToBeClickable(SelectRelationshipFName)).SendKeys("ABC");
            wait.Until(ExpectedConditions.ElementToBeClickable(SelectRelationshipLName)).SendKeys("Test");
            Extension.ScrollDown(driver);
            Thread.Sleep(TimeSpan.FromSeconds(2));
            
        }

        public void ClickNextandConfirm()
        {
            Thread.Sleep(TimeSpan.FromSeconds(3));
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(ExpectedConditions.ElementToBeClickable(ClickNextButton)).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            wait.Until(ExpectedConditions.ElementToBeClickable(ClickConfirmButton)).Click();
        }


            public void CompleteOTPNo(string OTP)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(ExpectedConditions.ElementToBeClickable(OTPTxt1)).SendKeys(OTP[0].ToString());
            wait.Until(ExpectedConditions.ElementToBeClickable(OTPTxt2)).SendKeys(OTP[1].ToString());
            wait.Until(ExpectedConditions.ElementToBeClickable(OTPTxt3)).SendKeys(OTP[2].ToString());
            wait.Until(ExpectedConditions.ElementToBeClickable(OTPTxt4)).SendKeys(OTP[3].ToString());
            wait.Until(ExpectedConditions.ElementToBeClickable(OTPTxt5)).SendKeys(OTP[4].ToString());
            wait.Until(ExpectedConditions.ElementToBeClickable(OTPTxt6)).SendKeys(OTP[5].ToString());
        }

        public void ClickSubmitButton()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(ExpectedConditions.ElementToBeClickable(ClickSubmit)).Click();
        }
    }
}
