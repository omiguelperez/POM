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
    [TestFixture("foo", "bar", "###")]
    public class TestClass
    {
        private IWebDriver driver;

        public string Username { get; set; }  
        public string Password { get; set; }
        public string IdentityCard { get; set; }

        public TestClass(string username, string password, string identityCard)
        {
            Username = username;
            Password = password;
            IdentityCard = identityCard;
        }

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
            LoginPage login = new LoginPage(driver);
            login.goToPage();
            login.openForm();
            login.typeUserCredentials(Username, Password, IdentityCard);
            login.signin();
        }

        [TearDown]
        public void TearDown()
        {
            driver.Close();
        }
    }
}