using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;
using V11.Pages;

namespace V11.Pages
{
    internal class TM_Tests
    {

        static void Main(string[] args)
        {

            // open chrome browser
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            //login page object initialization
            LoginPage loginPageObj = new LoginPage();
            loginPageObj.LoginSteps(driver);

            //Home page object initialization and definition
            HomePage homePageObj = new HomePage();
            homePageObj.GoToTMPage(driver);

            //TM page object iitialization and definition
            TMPage tMPageObj = new TMPage();
            tMPageObj.CreateTM(driver);

            //Edit TM Object initialization and definition
            tMPageObj.Edit(driver);

            //Delete TM object initilization and definition
            tMPageObj.DeleteTM(driver);


        }
    }
}
