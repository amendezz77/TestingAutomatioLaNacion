namespace TestAutomationLaNacion.UItest
{
    using OpenQA.Selenium;

    class UI
    {
        private static By noNoti = By.CssSelector("button[id='notificacion-no']");
        private static By seccion = By.CssSelector("header.header div.onoff-dropdown");
        private static By ultimasNoticias = By.LinkText("Últimas Noticias");
        private static By politica = By.LinkText("Política");
        private static By clima = By.LinkText("Clima");
        private static By transito = By.LinkText("Tránsito");
        private static By lnData = By.LinkText("LN DATA");
        private static By trafi = By.LinkText("Tránsito y transporte");
        private static By comboClima = By.Id("cboCiudades");
        private static By dolarBna = By.Id("precioCompraDolar");
        private static By dolarBlueban = By.Id("precioCompraBlue");
        private static By btnVerCiudad = By.CssSelector("input[type='button']");
        private static By infoClima = By.Id("informacion");
        private static By LANaciion = By.LinkText("LA NACION Data");
        private static By textPoli = By.LinkText("Política");
        private static By economia = By.LinkText("Economía");
        private static By dolarhoy = By.CssSelector("a[title='Dólar hoy']");
        private static By dolarBanNacion = By.XPath("//h2[text()='Dólar Banco Nación']");
        private static By dolarBlue = By.XPath("//h2[text()='Dólar Blue']");
        private static By dolarContadoLiqui = By.XPath("//h2[text()='Dólar Contado con Liqui']");
        private static By campo = By.LinkText("Campo");
        private static By textcampo = By.CssSelector("a[title='Campo']");
        private static By propiedades = By.LinkText("Propiedades");
        private static By comercioExte = By.LinkText("Comercio exterior");
        private static By textcomercioExte = By.CssSelector("a[title='Comercio Exterior']");
        private static By auto = By.LinkText("Autos");
        private static By textAuto = By.CssSelector("a[title='Autos']");
        private static By indices = By.LinkText("Índices");
        private static By textIndices = By.CssSelector(".encabezado h1");
        private static By calcuGanancias = By.LinkText("Calculadora de ganancias");
        private static By inputSueldoBruto = By.XPath("//input[@id='sueldoBruto']");
        private static By conyuge = By.XPath("//label[text()='Conyuge a Cargo']");
        private static By buscar = By.CssSelector("i.com-button.--tertiary");
        private static By inputBuscar = By.XPath("//input[@id='queryly_query']");
        private static By clickBusquedaAvanzada = By.XPath("//a[@id='advanced_searchbutton']");
        private static By textCoronavirus = By.CssSelector("#resultdata b");

        public static By GetTextCoronavirus()
        {
            return textCoronavirus;
        }

        public static By GetClickBusAvanzada()
        {
            return clickBusquedaAvanzada;
        }

        public static By GetInputBuscar()
        {
            return inputBuscar;
        }

        public static By GetBuscar()
        {
            return buscar;
        }


        public static By GetDolarBlueBan()
        {
            return dolarBlueban;
        }

        public static By GetConyuge()
        {
            return conyuge;
        }
        public static By GetInputSueldoBruto()
        {
            return inputSueldoBruto;
        }

        public static By GetCalcuGanancias()
        {
            return calcuGanancias;
        }
        public static By GetIndices()
        {
            return indices;
        }

        public static By GetTextIndices()
        {
            return textIndices;
        }

        public static By GetAuto()
        {
            return auto;
        }

        public static By GetTextAuto()
        {
            return textAuto;
        }

        public static By GetComercioExte()
        {
            return comercioExte;
        }
        public static By GetTextComercioExte()
        {
            return textcomercioExte;
        }


        public static By GetPropiedades()
        {
            return propiedades;
        }

        public static By GetTextCampo()
        {
            return textcampo;
        }


        public static By GetCampo()
        {
            return campo;
        }


        public static By GetDolarContadoLiqu()
        {
            return dolarContadoLiqui;
        }

        public static By GetDolarBlue()
        {
            return dolarBlue;
        }

        public static By GetDolarBanNacion()
        {
            return dolarBanNacion;
        }

        public static By GetDolarHoy()
        {
            return dolarhoy;
        }

        public static By GetEconomia()
        {
            return economia;
        }

        public static By GetTextPoli()
        {
            return textPoli;
        }

        public static By GetPolitica()
        {
            return politica;
        }

        public static By GetLaNaci()
        {
            return LANaciion;
        }

        public static By GetInfoClima()
        {
            return infoClima;
        }

        public static By GetbtnVerCiudad()
        {
            return btnVerCiudad;
        }

        public static By GetCombo()
        {
            return comboClima;
        }

        public static By GetDolarBna()
        {
            return dolarBna;
        }
        public static By GetTrafi()
        {
            return trafi;
        }
        public static By GetNoNoti()
        {
            return noNoti;
        }

        public static By GetSeccion()
        {
            return seccion;
        }

        public static By GetClima()
        {
            return clima;
        }

        public static By GetUltimasNoticias()
        {
            return ultimasNoticias;
        }

        public static By GetTransito()
        {
            return transito;
        }
        public static By GetLndata()
        {
            return lnData;
        }
    }
}
