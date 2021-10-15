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
    public class CustomerDetail_IN
    {
        private IWebDriver driver;

        By EnterFullName = By.CssSelector("form[class='fib-form-builder'] input[name='beneficiary_fullname']");
        By EnterPlaceofBirth = By.CssSelector("form[class='fib-form-builder'] input[name='beneficiary_pob']");
        By ClickCalender = By.CssSelector("form[class='fib-form-builder'] div[class='dropdown-trigger'] > div >input");
        By PickDate = By.XPath("//form[@class='fib-form-builder']/div[3]/div[1]/div[1]/div[3]/div[1]/div[1]/div[1]/div[1]/section/div[1]/div[2]/a[3]");
        By EnterRelationship = By.CssSelector("form[class='fib-form-builder'] input[name='beneficiary_relation']");
        By SelectMale = By.XPath("//form[@class='fib-form-builder']/div[5]/div/span/select/option[2]");
        By ClickGender = By.XPath("//form[@class='fib-form-builder']/div[5]/div/span");
        By EnterMobileNo = By.XPath("//form[@class='fib-form-builder']/div[6]/div/input");
        By CleckNextButton = By.XPath("//div[@class='container']/div[1]/div[1]/div[1]/div[1]/button");
        By EmergencyFullName = By.CssSelector("form[class='fib-form-builder'] input[name='emergency_fullname']");
        By EmergencyRelation = By.CssSelector("form[class='fib-form-builder'] input[name='emergency_relation']");
        By EmergencyContactNo = By.XPath("//form[@class='fib-form-builder']/div[3]/div[1]/input");
        By ContinueBTN = By.XPath("//div[@class='container']/div[1]/div[1]/div[2]/div[1]/button");

        public CustomerDetail_IN(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void FillCustomerForm()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            Thread.Sleep(TimeSpan.FromSeconds(3));
            wait.Until(ExpectedConditions.ElementToBeClickable(EnterFullName)).SendKeys("Test Automation");
            wait.Until(ExpectedConditions.ElementToBeClickable(EnterPlaceofBirth)).SendKeys("Jakarta");
            wait.Until(ExpectedConditions.ElementToBeClickable(EnterRelationship)).SendKeys("Single");
            wait.Until(ExpectedConditions.ElementToBeClickable(ClickGender)).Click();
            wait.Until(ExpectedConditions.ElementToBeClickable(SelectMale)).Click();
            wait.Until(ExpectedConditions.ElementToBeClickable(EnterMobileNo)).SendKeys("1");
        }

        public void SelectDateOfBirth()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(ExpectedConditions.ElementToBeClickable(ClickCalender)).Click();
            wait.Until(ExpectedConditions.ElementToBeClickable(PickDate)).Click();
        }

        public void ClickNext()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(ExpectedConditions.ElementToBeClickable(CleckNextButton)).Click();
        }
        public void FillEmergencyDetails()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            Thread.Sleep(TimeSpan.FromSeconds(3));
            wait.Until(ExpectedConditions.ElementToBeClickable(EmergencyFullName)).SendKeys("Test Automation");
            wait.Until(ExpectedConditions.ElementToBeClickable(EmergencyRelation)).SendKeys("Single");
            wait.Until(ExpectedConditions.ElementToBeClickable(EmergencyContactNo)).SendKeys("123456789");
            wait.Until(ExpectedConditions.ElementToBeClickable(ContinueBTN)).Click();
        }
    }
}
