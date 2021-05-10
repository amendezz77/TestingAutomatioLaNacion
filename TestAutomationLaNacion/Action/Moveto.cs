namespace TestAutomationLaNacion.Action
{
    using OpenQA.Selenium;
    using OpenQA.Selenium.Interactions;
    class Moveto
    {
        public static void MovetoElement(IWebDriver driver, By csSelector)
        {

            IWebElement Selector = driver.FindElement(csSelector);
            Actions actions = new Actions(driver);
            actions.MoveToElement(Selector).Build().Perform();

        }
        public static void MovertoElement(IWebDriver driver, By selector)
        {
            var element = driver.FindElement(selector);
            Actions actions = new Actions(driver);
            actions.MoveToElement(element);
            actions.Perform();
        }
    }
}
