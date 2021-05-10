namespace TestAutomationLaNacion.Action
{
    using OpenQA.Selenium;
    using OpenQA.Selenium.Interactions;

    class Enter
    {
        public static void Text(IWebDriver driver, By locator, string text)
        {
        //    Actions builder = new Actions(driver);
        //    builder.SendKeys( Keys.Enter);
           driver.FindElement(locator).SendKeys(text);
        }
    }
}
