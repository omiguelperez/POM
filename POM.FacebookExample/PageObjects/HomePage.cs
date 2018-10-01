using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;

namespace POM.FacebookExample.PageObjects
{
    public class HomePage
    {
        private IWebDriver driver;

        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }


        [FindsBy(How = How.CssSelector, Using = ".fusion-main-menu a[href*='about']")]
        private IWebElement about;
 
        [FindsBy(How = How.ClassName, Using = "fusion-main-menu-icon")]
        private IWebElement searchIcon;
 
        public void goToPage()
        {
            driver.Navigate().GoToUrl("https://www.swtestacademy.com");
        }
 
        public AboutPage goToAboutPage()
        {
            about.Click();
            return new AboutPage(driver);
        }   
    }
}
