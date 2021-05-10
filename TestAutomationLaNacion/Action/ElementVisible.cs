

namespace TestAutomationLaNacion.Action
{
    using OpenQA.Selenium;
    class ElementVisible
    {
        public static bool ElementIsPresent(IWebDriver driver, By by)
        {
            try
            {
                return driver.FindElement(by).Displayed;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }
    }
}
