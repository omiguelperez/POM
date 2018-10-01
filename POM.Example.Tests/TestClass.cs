using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using POM.Example.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace POM.Example.Tests
{
    public class TestClass
    {
        private IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            string chromeDriverPath =  @".";
            driver = new ChromeDriver(chromeDriverPath);
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void SearchTextFromAboutPage()
        {
            HomePage home = new HomePage(driver);
            home.goToPage();
            AboutPage about = home.goToAboutPage();
            ResultPage result = about.search("selenium c#");
            result.clickOnFirstArticle();
        }
    }
}