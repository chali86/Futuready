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
    public class PaymentPage_IN
    {
        private IWebDriver driver;

        By SelectPayment = By.XPath("//div[@class='container']/div[2]/div[1]/span");
        By SelectBankTransferBCAPayment = By.XPath("//div[@class='container']/div[2]/div[2]/span");
        By SelectBankTransferPermartaPayment = By.XPath("//div[@class='container']/div[2]/div[3]/span");
        By SelectIndormaretPayment = By.XPath("//div[@class='container']/div[2]/div[4]/span");
        By SelectAlfamartPayment = By.XPath("//div[@class='container']/div[2]/div[5]/span");
        By EnterCardNo = By.Id("idCardNumber");
        By EnterCardName = By.Id("idFirstName");
        By EnterExpireYear = By.XPath("//div[@id='idMasaBerlaku']/div[2]/input");
        By EnterExpireMonth = By.XPath("//div[@id='idMasaBerlaku']/div[1]/input");
        By EnterCVVNo = By.Id("idKode");
        By EnterAddress = By.Id("idAddress");
        By EnterCity = By.Id("idKota");
        By EnterPostalCode = By.Id("idKodePos");
        By ContinueButton = By.CssSelector("div[class='friends-form'] button[class='friends-form-submit']");
        By EnterOTPNo = By.Id("PaRes");
        By OKButton = By.CssSelector("div[class='form-group'] button[type='submit']");
        By ClickConfirmPayment = By.CssSelector("section[class='section'] button[class='button is-primary']");

        public PaymentPage_IN(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void ClickPaymentMethod()
        {
            Thread.Sleep(TimeSpan.FromSeconds(15));
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(ExpectedConditions.ElementToBeClickable(SelectPayment)).Click();
        }

        public void ClickBankTransferBCAPaymentMethod()
        {
            Thread.Sleep(TimeSpan.FromSeconds(15));
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(ExpectedConditions.ElementToBeClickable(SelectBankTransferBCAPayment)).Click();
        }

        public void ClickBankTransferPermartaPaymentMethod()
        {
            Thread.Sleep(TimeSpan.FromSeconds(15));
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(ExpectedConditions.ElementToBeClickable(SelectBankTransferPermartaPayment)).Click();
        }
        public void ClickIndomaretPaymentMethod()
        {
            Thread.Sleep(TimeSpan.FromSeconds(15));
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(ExpectedConditions.ElementToBeClickable(SelectIndormaretPayment)).Click();
        }
        public void ClickAlfamartPaymentMethod()
        {
            Thread.Sleep(TimeSpan.FromSeconds(15));
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(ExpectedConditions.ElementToBeClickable(SelectAlfamartPayment)).Click();
        }

        public void FillCardDetails()
        {
            Thread.Sleep(TimeSpan.FromSeconds(15));
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(ExpectedConditions.ElementToBeClickable(EnterCardNo)).SendKeys("4811 1111 1111 1114");
            wait.Until(ExpectedConditions.ElementToBeClickable(EnterExpireMonth)).SendKeys("01");
            wait.Until(ExpectedConditions.ElementToBeClickable(EnterExpireYear)).SendKeys("25");
            wait.Until(ExpectedConditions.ElementToBeClickable(EnterCVVNo)).SendKeys("123");
            Extension.ScrollToEnd(driver);
            wait.Until(ExpectedConditions.ElementToBeClickable(EnterCardName)).SendKeys("Test Card");
            wait.Until(ExpectedConditions.ElementToBeClickable(EnterAddress)).SendKeys("123 Test Address");
            wait.Until(ExpectedConditions.ElementToBeClickable(EnterCity)).SendKeys("jakarta");
            wait.Until(ExpectedConditions.ElementToBeClickable(EnterPostalCode)).SendKeys("10160");
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
            wait.Until(ExpectedConditions.ElementToBeClickable(OKButton)).Click();
        }

        public void ClickConfirm()
        {
            Thread.Sleep(TimeSpan.FromSeconds(10));
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(ExpectedConditions.ElementToBeClickable(ClickConfirmPayment)).Click();
        }

    }
}
