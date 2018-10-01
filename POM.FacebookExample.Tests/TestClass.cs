using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using POM.FacebookExample.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace POM.FacebookExample.Tests
{
    public class TestClass
    {
        private IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            System.setProperty("webdriver.chrome.driver", @"./chromedriver");
            ChromeOptions chromeOptions = new ChromeOptions();
            chromeOptions.addArguments("--whitelisted-ips=''");
            driver = new ChromeDriver(chromeOptions);
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