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
    public class ProposalForm_IN
    {
        private IWebDriver driver;

        By ClickCheckbox = By.CssSelector("div[class='field'] label[class='b-checkbox checkbox']");
        By ClickButton = By.CssSelector("div[class='price-button'] button[class='button is-secondary is-fullwidth']");

        public ProposalForm_IN(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void ConfirmProposal()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            Thread.Sleep(TimeSpan.FromSeconds(5));
            Extension.ScrollToEnd(driver);
            wait.Until(ExpectedConditions.ElementToBeClickable(ClickCheckbox)).Click();
            wait.Until(ExpectedConditions.ElementToBeClickable(ClickButton)).Click();
        }

    }
}
