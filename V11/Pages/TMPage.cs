using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using V11.Utilities;

namespace V11.Pages
{
    internal class TMPage
    {
        public void CreateTM(IWebDriver driver)
        {
            // Click on create new button
            IWebElement createNewButton = driver.FindElement(By.XPath("//*[@id='container']/p/a"));
            createNewButton.Click();

            // Select material from TypeCode dropdown
            IWebElement typeCodeDropdown = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]/span/span[2]/span"));
            typeCodeDropdown.Click();

            IWebElement materialOption = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]/span/span[1]"));
            materialOption.Click();
            Thread.Sleep(1000);


            // Identify the code textbox and input a code
            IWebElement codeTextbox = driver.FindElement(By.Id("Code"));
            codeTextbox.SendKeys("February2022");

            // Identify the description textbox and input a description
            IWebElement descriptionTextbox = driver.FindElement(By.Id("Description"));
            descriptionTextbox.SendKeys("February2022");

            // Identify the price textbox and input a price
            IWebElement priceTag = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]"));
            priceTag.Click();

            IWebElement priceTextbox = driver.FindElement(By.Id("Price"));
            priceTextbox.SendKeys("12");

            // Click on save button
            IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
            saveButton.Click();
            Thread.Sleep(1000);

            // Click on go to last page button
            IWebElement goToLastPageButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            goToLastPageButton.Click();
            Thread.Sleep(1000);

            // Check if record create is present in the table and has expected value
            IWebElement actualCode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));

            if (actualCode.Text == "February2022")
            {
                Console.WriteLine("Materail record created successfully, test passed.");
            }
            else
            {
                Console.WriteLine("Test failed.");
            }



        }

        public void Edit(IWebDriver driver)
        {
            //Edit the created TMoption
            //1. Click on edit of the created one
            IWebElement editButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[5]/a[1]"));
            editButton.Click();
            Thread.Sleep(1000);



            //2. Click on the time option
            IWebElement tDropdown = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]/span/span[2]"));
            tDropdown.Click();

            IWebElement timeOption = driver.FindElement(By.XPath(" //*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]/span/span[1]"));
            timeOption.Click();
            Wait.WaitToBeClickable(driver, "XPath", "//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]", 1);


            //3. Edit the price unit
            IWebElement epriceTag = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]"));
            epriceTag.Click();

            IWebElement editpriceTextbox = driver.FindElement(By.Id("Price"));
            editpriceTextbox.Click();
            editpriceTextbox.Clear();

            Thread.Sleep(1000);


            //4. click on save
            IWebElement esaveButton = driver.FindElement(By.Id("SaveButton"));
            esaveButton.Click();
            Thread.Sleep(1000);

        }

        public void DeleteTM(IWebDriver driver)
        {


        }
    }
}