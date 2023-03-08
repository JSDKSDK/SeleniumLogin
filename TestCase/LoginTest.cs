using AppSelenium.PageObject;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSelenium.TestCase
{
    [TestFixture]
    public class LoginTest
    {
        protected IWebDriver Driver;
        [SetUp]
        public void BeforeTest()
        {
            Driver = new ChromeDriver();
            Driver.Navigate().GoToUrl("http://localhost:4200");
        }
        [Test]
        public void SucessFulLoginTest()
        {
            LoginPage loginPage= new LoginPage(Driver);
            DashboardPage dashboardPage = loginPage.LoginAS("1082456","1082456");
            Assert.IsTrue(dashboardPage.Nabvar());
            Thread.Sleep(5000); // Pausa de 5 segundos
        }

        [TearDown]
        public void AfterTest()
        {
            if (Driver != null)
            {
                Driver.Quit();
            }

        }
    }
}
