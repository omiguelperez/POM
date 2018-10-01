using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using SeleniumExtras.WaitHelpers;
using System;

namespace POM.Example.PageObjects
{
    public class LoginPage
    {
        private IWebDriver driver;
        private OpenQA.Selenium.Support.UI.WebDriverWait wait;

        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
            wait = new OpenQA.Selenium.Support.UI.WebDriverWait(driver, TimeSpan.FromSeconds(10));
            PageFactory.InitElements(driver, this);
        }


        [FindsBy(How = How.CssSelector, Using = ".responsive-img.log")]
        private IWebElement loginImage;

        [FindsBy(How = How.CssSelector, Using = "#username")]
        private IWebElement usernameField;

        [FindsBy(How = How.CssSelector, Using = "#password")]
        private IWebElement passwordField;

        [FindsBy(How = How.CssSelector, Using = "#identityCard")]
        private IWebElement identityCardField;
 
        public void goToPage()
        {
            driver.Navigate().GoToUrl("http://test.site.com");
        }
 
        public void openForm()
        {
            loginImage.Click();
        }

        public void typeUserCredentials(string username, string password, string identityCard)
        {
            wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("#username"))).SendKeys(username);
            passwordField.SendKeys(password);
            identityCardField.SendKeys(identityCard);
        }

        public void signin()
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("#signin-btn"))).Click();
        }
    }
}
