using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace CalendarCardView.RecyclerView
{
    public class CardStatusView : ContentView
    {
        public CardStatusView(Card card)
        {
            var statusBoxView = new BoxView
            {
                VerticalOptions = LayoutOptions.Fill,
                HorizontalOptions = LayoutOptions.Fill
            };
            switch (card.Status)
            {
                case CardStatus.Alert:
                    statusBoxView.BackgroundColor = StyleKit.Status.AlertColor;
                    break;
                case CardStatus.Completed:
                    statusBoxView.BackgroundColor = StyleKit.Status.CompletedColor;
                    break;
                case CardStatus.Unresolved:
                    statusBoxView.BackgroundColor = StyleKit.Status.UnresolvedColor;
                    break;
                default:
                    statusBoxView.BackgroundColor = StyleKit.Status.UnresolvedColor;
                    break;

                //AQUI SE PONEN A DISPOCICION LOS COLORES DE LAS FECHAS
                case CardStatus.DiaFestivo:
                    statusBoxView.BackgroundColor = StyleKit.Status.DiaFestivo;
                    break;

                case CardStatus.InicioCuatrimestre:
                    statusBoxView.BackgroundColor = StyleKit.Status.InicioCuatrimestre;
                    break;

                case CardStatus.FinDeCuatrimestre:
                    statusBoxView.BackgroundColor = StyleKit.Status.FinDeCuatrimestre;
                    break;

                case CardStatus.InicioYFinDeTramiteDeEstadia:
                    statusBoxView.BackgroundColor = StyleKit.Status.InicioYFinDeTramiteDeEstadia;
                    break;

                case CardStatus.SemanaEvaluacionFinal:
                    statusBoxView.BackgroundColor = StyleKit.Status.SemanaEvaluacionFinal;
                    break;

                case CardStatus.PeriodoDeRevaloracion:
                    statusBoxView.BackgroundColor = StyleKit.Status.PeriodoDeRevaloracion;
                    break;

                case CardStatus.CapaticationDocente:
                    statusBoxView.BackgroundColor = StyleKit.Status.CapaticationDocente;
                    break;

                case CardStatus.ExamenIngresoTSU:
                    statusBoxView.BackgroundColor = StyleKit.Status.ExamenIngresoTSU;
                    break;

                case CardStatus.SemanaEquidadDeGenero:
                    statusBoxView.BackgroundColor = StyleKit.Status.SemanaEquidadDeGenero;
                    break;

                case CardStatus.InscripcionYResincripcion:
                    statusBoxView.BackgroundColor = StyleKit.Status.InscripcionYResincripcion;
                    break;

                case CardStatus.CapturaDeCalificaciones:
                    statusBoxView.BackgroundColor = StyleKit.Status.CapturaDeCalificaciones;
                    break;

                case CardStatus.SemanaTecnologica:
                    statusBoxView.BackgroundColor = StyleKit.Status.SemanaTecnologica;
                    break;

                case CardStatus.ForoDeInclusion:
                    statusBoxView.BackgroundColor = StyleKit.Status.ForoDeInclusion;
                    break;

                case CardStatus.PeriodoVacacional:
                    statusBoxView.BackgroundColor = StyleKit.Status.PeriodoVacacional;
                    break;

                case CardStatus.AnDptoInclusionYEquidadGenero:
                    statusBoxView.BackgroundColor = StyleKit.Status.AnDptoInclusionYEquidadGenero;
                    break;

                case CardStatus.DiaInternacionalDeLaMujer:
                    statusBoxView.BackgroundColor = StyleKit.Status.DiaInternacionalDeLaMujer;
                    break;

                case CardStatus.Bajas:
                    statusBoxView.BackgroundColor = StyleKit.Status.Bajas;
                    break;

            };
            Content = statusBoxView;
        }
    }
}
