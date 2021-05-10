namespace TestAutomationLaNacion.Action
{
    using OpenQA.Selenium;
    using System;
    class Click
    {
        public static void On(IWebDriver driver, By locator)
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(100);
            driver.FindElement(locator).Click();

        }

        
    }
}
