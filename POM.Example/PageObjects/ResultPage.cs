using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace POM.Example.PageObjects
{
    public class ResultPage
    {
        private IWebDriver driver;

        public ResultPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = "#posts-container>article:nth-child(1)")]
        private IWebElement firstArticle;
        
        public void clickOnFirstArticle()
        {
            firstArticle.Click();
        }
    }
}