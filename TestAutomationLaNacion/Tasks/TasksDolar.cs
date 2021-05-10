namespace TestAutomationLaNacion.Tasks
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using OpenQA.Selenium;
    using System;
    using System.Threading;
    using TestAutomationLaNacion.Action;
    using TestAutomationLaNacion.UItest;

    class TasksDolar
    {
        public static void ClickDolar(IWebDriver driver, string a)
        {
            Thread.Sleep(Literales.TimemMed);
            string b = driver.FindElement(UI.GetDolarBna()).Text;
            string result = b.Substring(0,1);
            Assert.AreEqual(a, result);
        }

        public static void ClickBlue(IWebDriver driver, string a)
        {
            Thread.Sleep(Literales.TimemMed);
            string b = driver.FindElement(UI.GetDolarBlueBan()).Text;
            string result = b.Substring(0, 1);
            Assert.AreEqual(a, result);
        }
    }
}
