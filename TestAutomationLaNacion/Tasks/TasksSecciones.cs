namespace TestAutomationLaNacion.Tasks
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using OpenQA.Selenium;
    using System.Threading;
    using TestAutomationLaNacion.Action;
    using TestAutomationLaNacion.UItest;

    class TasksSecciones
    {

        public static void ClickSeccionesUltimasNotisTransito(IWebDriver driver, string a)
        {
            Click.On(driver, UI.GetSeccion());
            Thread.Sleep(Literales.TimemMed);
            Moveto.MovetoElement(driver, UI.GetUltimasNoticias());
            Thread.Sleep(Literales.TimemMed);
            Click.On(driver, UI.GetTransito());
            Thread.Sleep(Literales.TimemMed);
            string b = driver.FindElement(UI.GetTrafi()).Text;
            Thread.Sleep(Literales.TimemMed);
            Assert.AreEqual(a,b);
        }

        public static void ClickSeccionesUltimasNotisClima(IWebDriver driver, string a)
        {
            Click.On(driver, UI.GetSeccion());
            Thread.Sleep(Literales.TimemMed);
            Moveto.MovetoElement(driver, UI.GetUltimasNoticias());
            Thread.Sleep(Literales.TimemMed);
            Click.On(driver, UI.GetClima());
            Thread.Sleep(Literales.TimemMed);
            SelectionElement.SelectOption(driver, UI.GetCombo(), a);
            Thread.Sleep(Literales.TimemMed);
            Click.On(driver, UI.GetbtnVerCiudad());
            Thread.Sleep(Literales.TimemMed);
            Assert.AreEqual(true, ElementVisible.ElementIsPresent(driver,UI.GetInfoClima()));
        }

        public static void ClickLNData(IWebDriver driver, string a)
        {
            Click.On(driver, UI.GetSeccion());
            Thread.Sleep(Literales.TimemMed);
            Moveto.MovetoElement(driver, UI.GetUltimasNoticias());
            Thread.Sleep(Literales.TimemMed);
            Click.On(driver, UI.GetLndata());
            Thread.Sleep(Literales.TimemMed);
            string b = driver.FindElement(UI.GetLaNaci()).Text;
            Thread.Sleep(Literales.TimemMed);
            Assert.AreEqual(a, b);
        }

        public static void ClickSeccionPolitica(IWebDriver driver, string a)
        {
            Click.On(driver, UI.GetSeccion());
            Thread.Sleep(Literales.TimemMed);
            Click.On(driver, UI.GetPolitica());
            Thread.Sleep(Literales.TimemMed);
            string b = driver.FindElement(UI.GetTextPoli()).Text;
            Thread.Sleep(Literales.TimemMed);
            Assert.AreEqual(a, b);
        }

        public static void ClickSeccionEcoDolarHoy(IWebDriver driver, string x, string y, string z)
        {
            Click.On(driver, UI.GetSeccion());
            Thread.Sleep(Literales.TimemMed);
            Moveto.MovetoElement(driver, UI.GetEconomia());
            Thread.Sleep(Literales.TimemMed);
            Click.On(driver, UI.GetDolarHoy());
            Thread.Sleep(Literales.TimemMed);
            string b = driver.FindElement(UI.GetDolarBanNacion()).Text;
            Thread.Sleep(Literales.TimemMed);
            Assert.AreEqual(x, b);
            Thread.Sleep(Literales.TimemMed);
            string c = driver.FindElement(UI.GetDolarBlue()).Text;
            Thread.Sleep(Literales.TimemMed);
            Assert.AreEqual(y, c);
            Thread.Sleep(Literales.TimemMed);
            string d = driver.FindElement(UI.GetDolarContadoLiqu()).Text;
            Thread.Sleep(Literales.TimemMed);
            Assert.AreEqual(z,d);
        }

        public static void ClickEcoCampo(IWebDriver driver, string a)
        {
            Click.On(driver, UI.GetSeccion());
            Thread.Sleep(Literales.TimemMed);
            Moveto.MovetoElement(driver, UI.GetEconomia());
            Thread.Sleep(Literales.TimemMed);
            Click.On(driver, UI.GetCampo());
            Thread.Sleep(Literales.TimemMed);
            string z = driver.FindElement(UI.GetTextCampo()).Text;
            Thread.Sleep(Literales.TimemMed);
            Assert.AreEqual(z, a);
         }

        public static void ClickEcoPro(IWebDriver driver)
        {
            Click.On(driver, UI.GetSeccion());
            Thread.Sleep(Literales.TimemMed);
            Moveto.MovetoElement(driver, UI.GetEconomia());
            Thread.Sleep(Literales.TimemMed);
            Click.On(driver, UI.GetPropiedades());
            Thread.Sleep(Literales.TimemMed);
        }

        public static void ClickComercioExte(IWebDriver driver, string a)
        {
            Click.On(driver, UI.GetSeccion());
            Thread.Sleep(Literales.TimemMed);
            Moveto.MovetoElement(driver, UI.GetEconomia());
            Thread.Sleep(Literales.TimemMed);
            Click.On(driver, UI.GetComercioExte());
            Thread.Sleep(Literales.TimemMed);
            string z = driver.FindElement(UI.GetTextComercioExte()).Text;
            Thread.Sleep(Literales.TimemMed);
            Assert.AreEqual(z, a);
        }

        public static void ClickAutos(IWebDriver driver, string a)
        {
            Click.On(driver, UI.GetSeccion());
            Thread.Sleep(Literales.TimemMed);
            Moveto.MovetoElement(driver, UI.GetEconomia());
            Thread.Sleep(Literales.TimemMed);
            Click.On(driver, UI.GetAuto());
            Thread.Sleep(Literales.TimemMed);
            string z = driver.FindElement(UI.GetTextAuto()).Text;
            Thread.Sleep(Literales.TimemMed);
            Assert.AreEqual(z, a);
        }

        public static void ClickIndices(IWebDriver driver, string a)
        {
            Click.On(driver, UI.GetSeccion());
            Thread.Sleep(Literales.TimemMed);
            Moveto.MovetoElement(driver, UI.GetEconomia());
            Thread.Sleep(Literales.TimemMed);
            Click.On(driver, UI.GetIndices());
            Thread.Sleep(Literales.TimemMed);
            string z = driver.FindElement(UI.GetTextIndices()).Text;
            Thread.Sleep(Literales.TimemMed);
            Assert.AreEqual(z, a);
        }
    }
}
