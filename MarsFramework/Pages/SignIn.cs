using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;
using static MarsFramework.Global.GlobalDefinitions;

namespace MarsFramework

{
    class SignIn
    {
        public SignIn()
        {
            PageFactory.InitElements(Global.GlobalDefinitions.driver, this);
        }

        #region  Initialize Web Elements 
        //Finding the Sign Link
        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Sign')]")]
        private IWebElement SignIntab { get; set; }

        // Finding the Email Field
        [FindsBy(How = How.Name, Using = "email")]
        private IWebElement Email { get; set; }

        //Finding the Password Field
        [FindsBy(How = How.Name, Using = "password")]
        private IWebElement Password { get; set; }

        //Finding the Login Button
        [FindsBy(How = How.XPath, Using = "//button[contains(text(),'Login')]")]
        private IWebElement LoginBtn { get; set; }

        #endregion
        internal void LoginSteps()
        {
            // IWebDriver driver = new ChromeDriver();
            // driver.Navigate().GoToUrl("http://localhost:5000/Home");

            driver.Navigate().GoToUrl("http://localhost:5000/Home");

            SignIntab.Click();
            Email.SendKeys("mvpstudio.qa@gmail.com");
            Password.SendKeys("SydneyQa2018");
            LoginBtn.Click();
        }

       

    }
}