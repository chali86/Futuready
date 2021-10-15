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
    public class Health
    {
        private IWebDriver driver;

        By SelectNoFirstQuestion = By.XPath("//div[@class='is-text-caption']/ol/li[1]/div[1]/label[1]/span[@class='check']");
        By SelectNoSecondQuestion = By.XPath("//div[@class='is-text-caption']/ol/li[2]/div[1]/label[1]/span[@class='check']");
        By ClickNextButton = By.XPath("//div[@class='btn-nav']/button[2]");

        public Health(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void FillHealthQuestionnaire()
        {
            Thread.Sleep(TimeSpan.FromSeconds(10)); 
            Extension.ScrollDown(driver);
            Extension.ScrollDown(driver);
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(ExpectedConditions.ElementToBeClickable(SelectNoFirstQuestion)).Click();
            wait.Until(ExpectedConditions.ElementToBeClickable(SelectNoSecondQuestion)).Click();
            Extension.ScrollDown(driver);
        }

        public void ClickNextStep()
        {
            Thread.Sleep(TimeSpan.FromSeconds(3));
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(ExpectedConditions.ElementToBeClickable(ClickNextButton)).Click();
        }

    }

}
