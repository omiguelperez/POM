using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using SeleniumExtras.WaitHelpers;
using System;

namespace POM.Example.PageObjects
{
    public class AboutPage 
    {
        private IWebDriver driver;
        private OpenQA.Selenium.Support.UI.WebDriverWait wait;

        public AboutPage(IWebDriver driver)
        {
            this.driver = driver;
            wait = new OpenQA.Selenium.Support.UI.WebDriverWait(driver, TimeSpan.FromSeconds(10));
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = "#menu-main input[class='s']")]
        private IWebElement searchText;
 
        public ResultPage search(string text)
        {
            searchText.SendKeys(text);
            wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("#menu-main .searchsubmit"))).Click();
            return new ResultPage(driver);
        }
    }
}