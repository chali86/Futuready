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
    public class MI_Plans
    {
        private IWebDriver driver;

        By BrandButton = By.XPath("//div[@class='column']/form/div[1]/div[1]/div[1]");
        By ClickYear = By.XPath("//div[@class='container']/div[1]/div[2]/form/div[2]/div[1]/div[1]/div[1]/div[1]/div[1]/input");
        By ClickModel = By.XPath("//div[@class='container']/div[1]/div[2]/form/div[3]/div[1]/div[1]/div[1]/div[1]/div[1]/input");
        By ClickSubModel = By.XPath("//div[@class='container']/div[1]/div[2]/form/div[4]/div[1]/div[1]/div[1]/div[1]/div[1]/input");
        By SearchPlanBTN = By.XPath("//div[@class='container']/div[1]/div[2]/form/div[5]/div[2]/div[1]/button");
        By ClickSelectPlanBTN = By.XPath("//div[@class='fib-pagination']/div[2]/div[1]/div[1]/div[1]/div[5]/div[1]/button");
        By ClickProceedBTN = By.XPath("//div[@class='container']/div[1]/div[1]/div[1]/div[1]/div[4]/div[1]/button");
        By NamsengInsurenceCHKBox = By.XPath("//div[@class='search p-4']/div[1]/div[1]/div[1]/div[3]/div[1]/div[1]/label/span[1]");
        By ThaisriInsurenceCHKBox = By.XPath("//div[@class='search p-4']/div[1]/div[1]/div[1]/div[3]/div[2]/div[1]/label/span[1]");
        By ThanachartInsurenceCHKBox = By.XPath("//div[@class='search p-4']/div[1]/div[1]/div[1]/div[3]/div[3]/div[1]/label/span[1]");
        By ViriyahInsurenceCHKBox = By.XPath("//div[@class='search p-4']/div[1]/div[1]/div[1]/div[3]/div[4]/div[1]/label/span[1]");
        By ClickFilterBTN = By.CssSelector("div[class='field is-grouped mt-4'] button[class='button is-primary']");

        public MI_Plans(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void SelectBrand()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(ExpectedConditions.ElementToBeClickable(BrandButton)).Click();
        }

        public void SelectYear(string Year)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            Thread.Sleep(TimeSpan.FromSeconds(3));
            wait.Until(ExpectedConditions.ElementToBeClickable(ClickYear)).Click();

            IList<IWebElement> YearList = driver.FindElements(By.XPath("//div[@class='container']/div[1]/div[2]/form/div[2]/div[1]/div[1]/div[1]/div[1]/div[2]/div[1]/a"));
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

            IList<IWebElement> ModelList = driver.FindElements(By.XPath("//div[@class='container']/div[1]/div[2]/form/div[3]/div[1]/div[1]/div[1]/div[1]/div[2]/div[1]/a"));


            foreach (IWebElement Models in ModelList)
            {
                if (Models.Text.Equals(Model))
                {
                    Models.Click();
                    break;
                }
            }
        }

        public void SelectSubModel(string SubModel)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            Thread.Sleep(TimeSpan.FromSeconds(3));
            wait.Until(ExpectedConditions.ElementToBeClickable(ClickSubModel)).Click();

            IList<IWebElement> SubModelList = driver.FindElements(By.XPath("//div[@class='container']/div[1]/div[2]/form/div[4]/div[1]/div[1]/div[1]/div[1]/div[2]/div[1]/a"));


            foreach (IWebElement SubModels in SubModelList)
            {
                if (SubModels.Text.Equals(SubModel))
                {
                    SubModels.Click();
                    break;
                }
            }
        }

        public void ClickSearchPlan()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(ExpectedConditions.ElementToBeClickable(SearchPlanBTN)).Click();
        }

        public void ClickSelectPlan()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(ExpectedConditions.ElementToBeClickable(ClickSelectPlanBTN)).Click();
        }

        public void ClickProceed()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(ExpectedConditions.ElementToBeClickable(ClickProceedBTN)).Click();
        }

        public void DeSelectNamsengInsurence()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(ExpectedConditions.ElementToBeClickable(NamsengInsurenceCHKBox)).Click();
        }

        public void DeSelectThaisriInsurence()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(ExpectedConditions.ElementToBeClickable(ThaisriInsurenceCHKBox)).Click();
        }

        public void DeSelectThanachartInsurence()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(ExpectedConditions.ElementToBeClickable(ThanachartInsurenceCHKBox)).Click();
        }

        public void DeSelectViriyahInsurence()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(ExpectedConditions.ElementToBeClickable(ViriyahInsurenceCHKBox)).Click();
        }

        public void ClickFilter()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(ExpectedConditions.ElementToBeClickable(ClickFilterBTN)).Click();
        }
    }
}
