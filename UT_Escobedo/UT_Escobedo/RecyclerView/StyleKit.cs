using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace CalendarCardView.RecyclerView
{
    public static class StyleKit
    {
        public static Color MediumGray = Color.FromHex("9F9F9F");
        public static Color CardBorderColor = Color.FromHex("E3E3E3");
        public static Color LightTextColor = Color.FromHex("383838");
        public static Color BarBackgroundColor = Color.FromHex("375587");
        public static Color CardFooterBackgroundColor = Color.FromHex("F6F6F6");

        public static class Status
        {
            ///Aqui si poner el color de los tipos de fechas
            public static Color InicioCuatrimestre = Color.FromHex("#4DCE11");
            public static Color FinDeCuatrimestre = Color.FromHex("#3ADF7C");
            public static Color InicioYFinDeTramiteDeEstadia = Color.FromHex("#E1414F");
            public static Color SemanaEvaluacionFinal = Color.FromHex("#E3DDE3");
            public static Color PeriodoDeRevaloracion = Color.FromHex("#36D1EC");
            public static Color CapaticationDocente = Color.FromHex("#FC8C25");
            public static Color ExamenIngresoTSU = Color.FromHex("#2789AA");
            public static Color SemanaEquidadDeGenero = Color.FromHex("#70C4E0");
            public static Color InscripcionYResincripcion = Color.FromHex("#FEE1AB");
            public static Color CapturaDeCalificaciones = Color.FromHex("#FFF236");
            public static Color SemanaTecnologica = Color.FromHex("#2A72E6");
            public static Color ForoDeInclusion = Color.FromHex("#48E32D");
            public static Color DiaFestivo = Color.FromHex("#A638CF");
            public static Color PeriodoVacacional = Color.FromHex("#FF5233");
            public static Color AnDptoInclusionYEquidadGenero = Color.FromHex("#12B7BC");
            public static Color DiaInternacionalDeLaMujer = Color.FromHex("#FC58B5");
            public static Color Bajas = Color.FromHex("#FFFF00");




            public static Color CompletedColor = Color.FromHex("00A2D3");
            public static Color AlertColor = Color.FromHex("E74C3C");
            public static Color UnresolvedColor = Color.FromHex("C5C5C5");
        }

        public class Icons
        {
            public static FileImageSource Alert = new FileImageSource() { File = "Alert.png" };
            public static FileImageSource Resume = new FileImageSource() { File = "Resume.png" };
            public static FileImageSource Completed = new FileImageSource() { File = "Completed.png" };
            public static FileImageSource Report = new FileImageSource() { File = "Report.png" };
            public static FileImageSource Unresolved = new FileImageSource() { File = "Unresolved.png" };
            public static FileImageSource Cog = new FileImageSource() { File = "Config.png" };
            public static FileImageSource SmallCalendar = new FileImageSource() { File = "Calendarmini.png" };
            public static FileImageSource SmallClock = new FileImageSource() { File = "Clockmini.png" };
            public static FileImageSource Shadow0240 = new FileImageSource() { File = "Shadow-0-2-4-0.png" };
        }
    }
}
