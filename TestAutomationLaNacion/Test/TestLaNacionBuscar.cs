namespace TestAutomationLaNacion.Test
{
    using NUnit.Framework;
    using System.Threading;
    using TestAutomationLaNacion.Tasks;
    using TestAutomationLaNacion.UItest;
    class TestLaNacionBuscar : BaseTest
    {
        [SetUp]
        public void SetUp()
        {

            this.Driver.Url = "https://www.lanacion.com.ar/";
            Thread.Sleep(Literales.TimemMed);
        }

        [Test]
        [Description("ID: 11 Test Case: Boton Buscar")]
        public void TestBotonBuscar()
        {
            TasksNotificaciones.ClickNoNoti(this.Driver);
            TasksLaNacionBuscar.ClickLaNaciBuscar(this.Driver, "Coronavirus");
        }
    }
}
