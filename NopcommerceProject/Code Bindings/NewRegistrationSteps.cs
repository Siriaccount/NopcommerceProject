using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using NUnit.Framework;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.UI;

namespace NopcommerceProject
{
    [Binding]
    public class NewRegistrationSteps
    {
        IWebDriver driver = new FirefoxDriver();
        
        
    [Given(@"the user is on the Nopcommerce website")]
    public void GivenTheUserIsOnTheNopcommerceWebsite()
    {
        //IWebDriver driver = new FirefoxDriver();
        driver.Url = "https://www.nopcommerce.com/";
    }
        
        [Given(@"the user taps on the Register button")]
        public void GivenTheUserTapsOnTheRegisterButton()
        {
            //IWebDriver driver = new FirefoxDriver();
            //this.driver = driver;
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            driver.FindElement(By.LinkText("Register")).Click();

        }

        [When(@"the user fills in all the details on the page")]
        public void WhenTheUserFillsInAllTheDetailsOnThePage()
        {
            //IWebDriver driver = new FirefoxDriver();
            driver.FindElement(By.ClassName("textBox")).SendKeys("test");
            driver.FindElement(By.CssSelector("#ctl00_ctl00_cph1_cph1_ctrlCustomerRegister_CreateUserForm_CreateUserStepContainer_txtLastName")).SendKeys("user");
            driver.FindElement(By.CssSelector("#ctl00_ctl00_cph1_cph1_ctrlCustomerRegister_CreateUserForm_CreateUserStepContainer_Email")).SendKeys("sahaja@abc.com");
            driver.FindElement(By.CssSelector("#ctl00_ctl00_cph1_cph1_ctrlCustomerRegister_CreateUserForm_CreateUserStepContainer_UserName")).SendKeys("sahajaaccount");
               
            var selectElement = new SelectElement(driver.FindElement(By.CssSelector("#ctl00_ctl00_cph1_cph1_ctrlCustomerRegister_CreateUserForm_CreateUserStepContainer_ddlCountry")));
            selectElement.SelectByText("United Kingdom");
            var selectElement1 = new SelectElement(driver.FindElement(By.CssSelector("#ctl00_ctl00_cph1_cph1_ctrlCustomerRegister_CreateUserForm_CreateUserStepContainer_ddlRole")));
            selectElement1.SelectByText("Technical / developer");
            IWebElement chckbox1 = driver.FindElement(By.Id("ctl00_ctl00_cph1_cph1_ctrlCustomerRegister_CreateUserForm_CreateUserStepContainer_cbNewsletter"));
            bool value = false;
            value = chckbox1.Selected;
            if (value == true)
            { chckbox1.Click(); }
            driver.FindElement(By.Id("ctl00_ctl00_cph1_cph1_ctrlCustomerRegister_CreateUserForm_CreateUserStepContainer_Password")).SendKeys("password");
            driver.FindElement(By.Id("ctl00_ctl00_cph1_cph1_ctrlCustomerRegister_CreateUserForm_CreateUserStepContainer_ConfirmPassword")).SendKeys("password");
        }


        [When(@"taps on the Register button")]
        public void WhenTapsOnTheRegisterButton()
        {
            //IWebDriver driver = new FirefoxDriver();
            driver.FindElement(By.Id("ctl00_ctl00_cph1_cph1_ctrlCustomerRegister_CreateUserForm___CustomNav0_StepNextButton")).Click();


        }

        [Then(@"the user should be registered and see a Register success message")]
        public void ThenTheUserShouldBeRegisteredAndSeeARegisterSuccessMessage()
        {
            //IWebDriver driver = new FirefoxDriver();
            Assert.That(driver.FindElement(By.Id("ctl00_ctl00_cph1_cph1_ctrlCustomerRegister_CreateUserForm_CompleteStepContainer_lblCompleteStep")).Displayed);
        }
    }
}
