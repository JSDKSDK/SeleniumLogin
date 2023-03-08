using AppSelenium.Handler;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSelenium.PageObject
{
    //Clase base del login
    public class LoginPage
    {
        protected IWebDriver Driver;

        protected By UserInput = By.Id("usuario");
        protected By PassInput = By.Id("contrasena");
        protected By ButtonSubmit = By.ClassName("login__submit");
        protected By Buttonswal2 = By.ClassName("swal2-actions");

        public LoginPage(IWebDriver driver) {
            Driver = driver;

            if (!Driver.Title.Equals("Solicitud Exclusion")) {
                throw new Exception("Esta no es la pagina del login");
            }

        }
        public void TypeUserName(string User)
        {
            Driver.FindElement(UserInput).SendKeys(User);
        }
        public void TypePassword(string Password)
        {
            Driver.FindElement(PassInput).SendKeys(Password);
        }
        public void ClickLogin()
        {
            Driver.FindElement(ButtonSubmit).Click();

        }
        public void clickAlert()
        {
            if (WaitHandler.ElemntIsPresent(Driver,Buttonswal2))
            {
            Driver.FindElement(Buttonswal2).Click();
                
            }
        }

        public DashboardPage LoginAS(string user, string password)
        {
            TypeUserName(user);
            TypePassword(password);
            ClickLogin();
            clickAlert();
            return new DashboardPage(Driver);
        }

    }
}
