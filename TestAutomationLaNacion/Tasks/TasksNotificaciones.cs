using System;
namespace TestAutomationLaNacion.Tasks
{
    using OpenQA.Selenium;
    using System.Threading;
    using TestAutomationLaNacion.Action;
    using TestAutomationLaNacion.UItest;
    class TasksNotificaciones
    {
        public static void ClickNoNoti(IWebDriver driver)
        {
            Click.On(driver, UI.GetNoNoti());
            Thread.Sleep(Literales.TimemMed);
        }

    }
}
