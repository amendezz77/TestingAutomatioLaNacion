namespace TestAutomationLaNacion.Test
{
    using NUnit.Framework;
    using System.Threading;
    using TestAutomationLaNacion.Tasks;
    using TestAutomationLaNacion.UItest;
    class TestSecciones : BaseTest
    {
        [SetUp]
        public void SetUp()
        {

            this.Driver.Url = "https://www.lanacion.com.ar/";
            Thread.Sleep(Literales.TimemMed);
        }


        [Test]
        [Description("ID: 1, Test Case : Ultimas Noticias - Transito")]
        public void TestSeccionesUltiNotiTransi()
        {
            TasksNotificaciones.ClickNoNoti(this.Driver);
            TasksSecciones.ClickSeccionesUltimasNotisTransito(this.Driver, "Tránsito y transporte");
        }


        [Test]
        [Description("ID: 2, Test Case : Ultimas Noticias -Clima")]
        public void TestSeccionesUltiNotiClima()
        {
            TasksNotificaciones.ClickNoNoti(this.Driver);
            TasksSecciones.ClickSeccionesUltimasNotisClima(this.Driver, "Capital Federal");
        }


        [Test]
        [Description("ID: 3, Test Case : Ultimas Noticias -LN DATA")]
        public void TestSeccionesUltiNotiLNData()
        {
            TasksNotificaciones.ClickNoNoti(this.Driver);
            TasksSecciones.ClickLNData(this.Driver, "LA NACION Data");
        }

        [Test]
        [Description("ID: 4, Test Case : Politica")]
        public void TestSeccionesPolitica()
        {
            TasksNotificaciones.ClickNoNoti(this.Driver);
            TasksSecciones.ClickSeccionPolitica(this.Driver, "Política");
        }

        [Test]
        [Description("ID: 5, Test Case : Economia- Dólar Hoy")]
        public void TestSeccionesEconDolarHoy()
        {
            TasksNotificaciones.ClickNoNoti(this.Driver);
            TasksSecciones.ClickSeccionEcoDolarHoy(this.Driver, "Dólar Banco Nación", "Dólar Blue", "Dólar Contado con Liqui");
        }

        [Test]
        [Description("ID: 6, Test Case : Economia Campo")]
        public void TestSeccionesEcoCampo()
        {
            TasksNotificaciones.ClickNoNoti(this.Driver);
            TasksSecciones.ClickEcoCampo(this.Driver, "Campo");
        }

        [Test]
        [Description("ID: 7, Test Case : Economia - Propiedades")]
        public void TestSeccionesEcoPropiedades()
        {
            TasksNotificaciones.ClickNoNoti(this.Driver);
            TasksSecciones.ClickEcoPro(this.Driver);
        }

        [Test]
        [Description("ID: 8, Test Case : Economia- Comercio Exterior")]
        public void TestSeccionesEcoComercioExterior()
        {
            TasksNotificaciones.ClickNoNoti(this.Driver);
            TasksSecciones.ClickComercioExte(this.Driver, "Comercio Exterior");
        }


        [Test]
        [Description("ID: 9, Test Case : Economia- Autos")]
        public void TestSeccionesEcoAuto()
        {
            TasksNotificaciones.ClickNoNoti(this.Driver);
            TasksSecciones.ClickAutos(this.Driver, "Autos");
        }

        [Test]
        [Description("ID: 10, Test Case : Economia- Indices")]
        public void TestSeccionesEcoIndices()
        {
            TasksNotificaciones.ClickNoNoti(this.Driver);
            TasksSecciones.ClickIndices(this.Driver, "Índices");
        }
    }
}
