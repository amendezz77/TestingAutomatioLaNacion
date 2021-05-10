namespace TestAutomationLaNacion.Tasks
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using OpenQA.Selenium;
    using System;
    using System.Threading;
    using TestAutomationLaNacion.Action;
    using TestAutomationLaNacion.UItest;

    class TasksLaNacionBuscar
    {

        public static void ClickLaNaciBuscar(IWebDriver driver, string a)
        {
            Click.On(driver, UI.GetBuscar());
            Thread.Sleep(Literales.TimemMed);
            Enter.Text(driver, UI.GetInputBuscar(), a);
            Thread.Sleep(Literales.TimemMed);
            Click.On(driver, UI.GetClickBusAvanzada());
            Thread.Sleep(Literales.TimemMed);
            Assert.AreEqual(true, ElementVisible.ElementIsPresent(driver, UI.GetTextCoronavirus()));
        }
    }
}
