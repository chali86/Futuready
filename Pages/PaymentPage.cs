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
    public class PaymentPage
    {

        private IWebDriver driver;

        By SelectPayment = By.XPath("//div[@class='container']/div[2]/div[1]/span");
        By EnterCardNo = By.Id("tel-cardNumber");
        By EnterCardName = By.Id("name");
        By EnterExpireDate = By.Id("expyear");
        By EnterCVVNo = By.Id("number-cvv");
        By ContinueButton = By.XPath("//div[@class='select-category']/div[1]/form[2]/div[8]/button[2]");
        By EnterOTPNo = By.Id("otp");
        By Proceed = By.Id("continue");

        public PaymentPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void ClickPaymentMethod()
        {
            Thread.Sleep(TimeSpan.FromSeconds(15));
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(ExpectedConditions.ElementToBeClickable(SelectPayment)).Click();
        }

        public void FillCardDetails()
        {
            Thread.Sleep(TimeSpan.FromSeconds(15));
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(ExpectedConditions.ElementToBeClickable(EnterCardNo)).SendKeys("4111111111111111");
            wait.Until(ExpectedConditions.ElementToBeClickable(EnterExpireDate)).SendKeys("1225");
            wait.Until(ExpectedConditions.ElementToBeClickable(EnterCVVNo)).SendKeys("123");
            wait.Until(ExpectedConditions.ElementToBeClickable(EnterCardName)).SendKeys("Test Card");

        }

        public void ClickContinuePayment()
        {
            Thread.Sleep(TimeSpan.FromSeconds(3));
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(ExpectedConditions.ElementToBeClickable(ContinueButton)).Click();
        }

        public void EnterOTPNumber(string OTP)
        {
            Thread.Sleep(TimeSpan.FromSeconds(3));
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(ExpectedConditions.ElementToBeClickable(EnterOTPNo)).SendKeys(OTP);
        }

        public void ClickProceed()
        {
            Thread.Sleep(TimeSpan.FromSeconds(3));
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(ExpectedConditions.ElementToBeClickable(Proceed)).Click();
        }
    }
}
