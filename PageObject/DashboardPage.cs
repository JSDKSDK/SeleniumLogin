using AppSelenium.Handler;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSelenium.PageObject
{
    public  class DashboardPage
    {
        protected IWebDriver Driver;

        ////Localizadores
        protected By Menu = By.ClassName("left-sidebar");

        public DashboardPage(IWebDriver driver)
        {
            Driver = driver;
            if (!Driver.Url.Equals("http://localhost:4200/dashboard"))
            {
                throw new Exception("La pagina de Dashboard no se ha cargado");
            }
        }

        public bool Nabvar()
        {
           return WaitHandler.ElemntIsPresent(Driver,Menu);

        }

    }
}
