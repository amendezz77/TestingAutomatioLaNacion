namespace TestAutomationLaNacion.Test
{
    using NUnit.Framework;
    using System.Threading;
    using TestAutomationLaNacion.Tasks;
    using TestAutomationLaNacion.UItest;
    class TestDolar : BaseTest
    {
        [SetUp]
        public void SetUp()
        {

            this.Driver.Url = "https://www.lanacion.com.ar/";
            Thread.Sleep(Literales.TimemMed);
        }

        [Test]
        [Description("ID: 12 Test Case: Dolar BNA")]
        public void TestDolarBNA()
        {
            TasksNotificaciones.ClickNoNoti(this.Driver);
            TasksDolar.ClickDolar(this.Driver,"$");
        }

        [Test]
        [Description("ID:13 Test Case: Dolar Blue")]
        public void TestDolarBlue()
        {
            TasksNotificaciones.ClickNoNoti(this.Driver);
            TasksDolar.ClickBlue(this.Driver, "$");
        }
    }
}
