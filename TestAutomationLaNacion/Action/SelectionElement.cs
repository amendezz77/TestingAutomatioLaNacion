namespace TestAutomationLaNacion.Action
{
    using OpenQA.Selenium;
    using OpenQA.Selenium.Support.UI;
    using System;

    class SelectionElement
    {
        //Select
        //Value
        public static void SelectOption(IWebDriver driver, By by , string a)
        {
            SelectElement ss = new SelectElement(driver.FindElement(by));
            ss.SelectByText(a);
        }
    }
}
