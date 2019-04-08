using System;
using System.Collections.Generic;
using Xamarin.Forms;
using System.Text;

namespace CalendarCardView.RecyclerView
{
    public class Card
    {
        public CardStatus Status { get; set; }

        public FileImageSource StatusMessageFileSource { get; set; }

        public string StatusMessage { get; set; }

        public FormattedString Title { get; set; }

        public string Description { get; set; }

        public ContentView MessageView { get; set; }

        public DateTime DueDate { get; set; }
    }

    public enum CardStatus
    {
        //Aqui se poner las alertas por color
        Alert,
        InicioCuatrimestre,
        FinDeCuatrimestre,
        InicioYFinDeTramiteDeEstadia,
        SemanaEvaluacionFinal,
        PeriodoDeRevaloracion,
        CapaticationDocente,
        ExamenIngresoTSU,
        SemanaEquidadDeGenero,
        InscripcionYResincripcion,
        CapturaDeCalificaciones,
        SemanaTecnologica,
        ForoDeInclusion,
        PeriodoVacacional,
        AnDptoInclusionYEquidadGenero,
        DiaInternacionalDeLaMujer,
        DiaFestivo,
        Completed,
        Unresolved,
        Bajas
    }
}
