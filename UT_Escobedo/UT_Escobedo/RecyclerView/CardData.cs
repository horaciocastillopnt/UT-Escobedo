using CalendarCardView.RecyclerView;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace CalendarCardView
{
    public class CardData : List<Card>
    {
        public CardData()
        {
        }

        public List<Card> Enero()
        {
            List<Card> enero = new List<Card>();

            return enero;
        }

        public List<Card> Febrero()
        {
            List<Card> febrero = new List<Card>();

            return febrero;
        }

        public List<Card> Marzo()
        {

            List<Card> Marzo = new List<Card>();

            #region Marzo

            Marzo.Add(new Card()
            {
                Status = CardStatus.DiaFestivo,
                DueDate = new DateTime(2019, 03, 18),
                StatusMessage = DifDias(new DateTime(2019, 03, 18), DateTime.Now),
                StatusMessageFileSource = StyleKit.Icons.Alert,
                Description = "Dia Festivo",
                Title = new FormattedString()
                {
                    Spans = {
                        new Span()
                        {
                            Text = "Día de la Expropiación Petrolera"
                        },
                        new Span()
                        {
                            Text = "",
                            FontAttributes = FontAttributes.Bold
                        }
                    }
                }
            });

            Marzo.Add(new Card()
            {
                Status = CardStatus.SemanaTecnologica,
                DueDate = new DateTime(2019, 03, 26),
                StatusMessage = DifDias(new DateTime(2019, 03, 26), DateTime.Now),
                StatusMessageFileSource = StyleKit.Icons.Alert,
                Description = "Inicio",
                Title = new FormattedString()
                {
                    Spans = {
                        new Span()
                        {
                            Text = "Semana Tecnologica"
                        },
                        new Span()
                        {
                            Text = "",
                            FontAttributes = FontAttributes.Bold
                        }
                    }
                }
            });

            Marzo.Add(new Card()
            {
                Status = CardStatus.SemanaTecnologica,
                DueDate = new DateTime(2019, 03, 29),
                StatusMessage = DifDias(new DateTime(2019, 03, 29), DateTime.Now),
                StatusMessageFileSource = StyleKit.Icons.Alert,
                Description = "Fin",
                Title = new FormattedString()
                {
                    Spans = {
                        new Span()
                        {
                            Text = "Semana Tecnologica"
                        },
                        new Span()
                        {
                            Text = "",
                            FontAttributes = FontAttributes.Bold
                        }
                    }
                }
            });

            #endregion

            return Marzo;
        }

        public List<Card> Abril()
        {

            //new DateTime(YYY, MM, DD)

            List<Card> Abril = new List<Card>();

            Abril.Add(new Card()
            {
                Status = CardStatus.SemanaEvaluacionFinal,
                DueDate = new DateTime(2019, 04, 01),
                StatusMessage = DifDias(new DateTime(2019, 04, 01), DateTime.Now),
                StatusMessageFileSource = StyleKit.Icons.Alert,
                Description = "Inicio",
                Title = new FormattedString()
                {
                    Spans = {
                        new Span()
                        {
                            Text = "Evaluaciones Finales"
                        },
                        new Span()
                        {
                            Text = "",
                            FontAttributes = FontAttributes.Bold
                        }
                    }
                }
            });

            Abril.Add(new Card()
            {
                Status = CardStatus.SemanaEvaluacionFinal,
                DueDate = new DateTime(2019, 04, 03),
                StatusMessage = DifDias(new DateTime(2019, 04, 03), DateTime.Now),
                StatusMessageFileSource = StyleKit.Icons.Alert,
                Description = "Fin",
                Title = new FormattedString()
                {
                    Spans = {
                        new Span()
                        {
                            Text = "Evaluaciones Finales"
                        },
                        new Span()
                        {
                            Text = "",
                            FontAttributes = FontAttributes.Bold
                        }
                    }
                }
            });

            Abril.Add(new Card()
            {
                Status = CardStatus.Bajas,
                DueDate = new DateTime(2019, 04, 04),
                StatusMessage = DifDias(new DateTime(2019, 04, 04), DateTime.Now),
                StatusMessageFileSource = StyleKit.Icons.Alert,
                Description = "Inicio",
                Title = new FormattedString()
                {
                    Spans = {
                        new Span()
                        {
                            Text = "Captura de examenes finales y entrega de bajas"
                        },
                        new Span()
                        {
                            Text = "",
                            FontAttributes = FontAttributes.Bold
                        }
                    }
                }
            });

            Abril.Add(new Card()
            {
                Status = CardStatus.Bajas,
                DueDate = new DateTime(2019, 04, 05),
                StatusMessage = DifDias(new DateTime(2019, 04, 05), DateTime.Now),
                StatusMessageFileSource = StyleKit.Icons.Alert,
                Description = "Fin",
                Title = new FormattedString()
                {
                    Spans = {
                        new Span()
                        {
                            Text = "Captura de examenes finales y entrega de bajas"
                        },
                        new Span()
                        {
                            Text = "",
                            FontAttributes = FontAttributes.Bold
                        }
                    }
                }
            });

            Abril.Add(new Card()
            {
                Status = CardStatus.PeriodoDeRevaloracion,
                DueDate = new DateTime(2019, 04, 08),
                StatusMessage = DifDias(new DateTime(2019, 04, 08), DateTime.Now),
                StatusMessageFileSource = StyleKit.Icons.Alert,
                Description = "Inicio",
                Title = new FormattedString()
                {
                    Spans = {
                        new Span()
                        {
                            Text = "Revaloracion Final"
                        },
                        new Span()
                        {
                            Text = "",
                            FontAttributes = FontAttributes.Bold
                        }
                    }
                }
            });

            Abril.Add(new Card()
            {
                Status = CardStatus.PeriodoDeRevaloracion,
                DueDate = new DateTime(2019, 04, 10),
                StatusMessage = DifDias(new DateTime(2019, 04, 10), DateTime.Now),
                StatusMessageFileSource = StyleKit.Icons.Alert,
                Description = "Fin",
                Title = new FormattedString()
                {
                    Spans = {
                        new Span()
                        {
                            Text = "Revaloracion Final"
                        },
                        new Span()
                        {
                            Text = "",
                            FontAttributes = FontAttributes.Bold
                        }
                    }
                }
            });

            Abril.Add(new Card()
            {
                Status = CardStatus.CapturaDeCalificaciones,
                DueDate = new DateTime(2019, 04, 11),
                StatusMessage = DifDias(new DateTime(2019, 04, 11), DateTime.Now),
                StatusMessageFileSource = StyleKit.Icons.Alert,
                Description = "Inicio",
                Title = new FormattedString()
                {
                    Spans = {
                        new Span()
                        {
                            Text = "Captura de revaloraciones"
                        },
                        new Span()
                        {
                            Text = "",
                            FontAttributes = FontAttributes.Bold
                        }
                    }
                }
            });

            Abril.Add(new Card()
            {
                Status = CardStatus.CapturaDeCalificaciones,
                DueDate = new DateTime(2019, 04, 12),
                StatusMessage = DifDias(new DateTime(2019, 04, 12), DateTime.Now),
                StatusMessageFileSource = StyleKit.Icons.Alert,
                Description = "Fin",
                Title = new FormattedString()
                {
                    Spans = {
                        new Span()
                        {
                            Text = "Captura de revaloraciones"
                        },
                        new Span()
                        {
                            Text = "",
                            FontAttributes = FontAttributes.Bold
                        }
                    }
                }
            });

            Abril.Add(new Card()
            {
                Status = CardStatus.InicioYFinDeTramiteDeEstadia,
                DueDate = new DateTime(2019, 04, 12),
                StatusMessage = DifDias(new DateTime(2019, 04, 12), DateTime.Now),
                StatusMessageFileSource = StyleKit.Icons.Alert,
                Description = "Fin",
                Title = new FormattedString()
                {
                    Spans = {
                        new Span()
                        {
                            Text = "Tramite de estadias"
                        },
                        new Span()
                        {
                            Text = "",
                            FontAttributes = FontAttributes.Bold
                        }
                    }
                }
            });

            Abril.Add(new Card()
            {
                Status = CardStatus.FinDeCuatrimestre,
                DueDate = new DateTime(2019, 04, 12),
                StatusMessage = DifDias(new DateTime(2019, 04, 12), DateTime.Now),
                StatusMessageFileSource = StyleKit.Icons.Alert,
                Description = "Fin",
                Title = new FormattedString()
                {
                    Spans = {
                        new Span()
                        {
                            Text = "Cuatrimestre"
                        },
                        new Span()
                        {
                            Text = "",
                            FontAttributes = FontAttributes.Bold
                        }
                    }
                }
            });

            Abril.Add(new Card()
            {
                Status = CardStatus.PeriodoVacacional,
                DueDate = new DateTime(2019, 04, 15),
                StatusMessage = DifDias(new DateTime(2019, 04, 15), DateTime.Now),
                StatusMessageFileSource = StyleKit.Icons.Alert,
                Description = "Inicio",
                Title = new FormattedString()
                {
                    Spans = {
                        new Span()
                        {
                            Text = "Periodo Vacacional"
                        },
                        new Span()
                        {
                            Text = "",
                            FontAttributes = FontAttributes.Bold
                        }
                    }
                }
            });

            Abril.Add(new Card()
            {
                Status = CardStatus.PeriodoVacacional,
                DueDate = new DateTime(2019, 04, 26),
                StatusMessage = DifDias(new DateTime(2019, 04, 26), DateTime.Now),
                StatusMessageFileSource = StyleKit.Icons.Alert,
                Description = "Fin",
                Title = new FormattedString()
                {
                    Spans = {
                        new Span()
                        {
                            Text = "Periodo Vacacional"
                        },
                        new Span()
                        {
                            Text = "",
                            FontAttributes = FontAttributes.Bold
                        }
                    }
                }
            });

            Abril.Add(new Card()
            {
                Status = CardStatus.InscripcionYResincripcion,
                DueDate = new DateTime(2019, 04, 29),
                StatusMessage = DifDias(new DateTime(2019, 04, 29), DateTime.Now),
                StatusMessageFileSource = StyleKit.Icons.Alert,
                Description = "Inicio",
                Title = new FormattedString()
                {
                    Spans = {
                        new Span()
                        {
                            Text = "Incripciones y Reinscripciones"
                        },
                        new Span()
                        {
                            Text = "",
                            FontAttributes = FontAttributes.Bold
                        }
                    }
                }
            });

            Abril.Add(new Card()
            {
                Status = CardStatus.InscripcionYResincripcion,
                DueDate = new DateTime(2019, 04, 30),
                StatusMessage = DifDias(new DateTime(2019, 04, 30), DateTime.Now),
                StatusMessageFileSource = StyleKit.Icons.Alert,
                Description = "Fin",
                Title = new FormattedString()
                {
                    Spans = {
                        new Span()
                        {
                            Text = "Inscripciones y Reinscripciones"
                        },
                        new Span()
                        {
                            Text = "",
                            FontAttributes = FontAttributes.Bold
                        }
                    }
                }
            });

            return Abril;

        }

        public List<Card> Mayo()
        {

            List<Card> Mayo = new List<Card>();

            Mayo.Add(new Card()
            {
                Status = CardStatus.DiaFestivo,
                DueDate = new DateTime(2019, 05, 01),
                StatusMessage = DifDias(new DateTime(2019, 05, 01), DateTime.Now),
                StatusMessageFileSource = StyleKit.Icons.Alert,
                Description = "Dia Festivo",
                Title = new FormattedString()
                {
                    Spans = {
                        new Span()
                        {
                            Text = "Día del Trabajo"
                        },
                        new Span()
                        {
                            Text = "",
                            FontAttributes = FontAttributes.Bold
                        }
                    }
                }
            });

            Mayo.Add(new Card()
            {
                Status = CardStatus.InscripcionYResincripcion,
                DueDate = new DateTime(2019, 05, 02),
                StatusMessage = DifDias(new DateTime(2019, 05, 02), DateTime.Now),
                StatusMessageFileSource = StyleKit.Icons.Alert,
                Description = "Inicio",
                Title = new FormattedString()
                {
                    Spans = {
                        new Span()
                        {
                            Text = "Inscripciones y Reinscripciones"
                        },
                        new Span()
                        {
                            Text = "",
                            FontAttributes = FontAttributes.Bold
                        }
                    }
                }
            });

            Mayo.Add(new Card()
            {
                Status = CardStatus.InscripcionYResincripcion,
                DueDate = new DateTime(2019, 05, 02),
                StatusMessage = DifDias(new DateTime(2019, 05, 02), DateTime.Now),
                StatusMessageFileSource = StyleKit.Icons.Alert,
                Description = "Fin",
                Title = new FormattedString()
                {
                    Spans = {
                        new Span()
                        {
                            Text = "Inscripcion y Reinscripcion"
                        },
                        new Span()
                        {
                            Text = "",
                            FontAttributes = FontAttributes.Bold
                        }
                    }
                }
            });

            Mayo.Add(new Card()
            {
                Status = CardStatus.InicioCuatrimestre,
                DueDate = new DateTime(2019, 05, 06),
                StatusMessage = DifDias(new DateTime(2019, 05, 06), DateTime.Now),
                StatusMessageFileSource = StyleKit.Icons.Alert,
                Description = "Inicio",
                Title = new FormattedString()
                {
                    Spans = {
                        new Span()
                        {
                            Text = "Cuatrimestre"
                        },
                        new Span()
                        {
                            Text = "",
                            FontAttributes = FontAttributes.Bold
                        }
                    }
                }
            });

            Mayo.Add(new Card()
            {
                Status = CardStatus.InicioYFinDeTramiteDeEstadia,
                DueDate = new DateTime(2019, 05, 07),
                StatusMessage = DifDias(new DateTime(2019, 05, 07), DateTime.Now),
                StatusMessageFileSource = StyleKit.Icons.Alert,
                Description = "Inicio",
                Title = new FormattedString()
                {
                    Spans = {
                        new Span()
                        {
                            Text = "Tramite de estadias"
                        },
                        new Span()
                        {
                            Text = "",
                            FontAttributes = FontAttributes.Bold
                        }
                    }
                }
            });

            Mayo.Add(new Card()
            {
                Status = CardStatus.DiaFestivo,
                DueDate = new DateTime(2019, 05, 15),
                StatusMessage = DifDias(new DateTime(2019, 05, 15), DateTime.Now),
                StatusMessageFileSource = StyleKit.Icons.Alert,
                Description = "Dia Festivo",
                Title = new FormattedString()
                {
                    Spans = {
                        new Span()
                        {
                            Text = "Día del Maestro"
                        },
                        new Span()
                        {
                            Text = "",
                            FontAttributes = FontAttributes.Bold
                        }
                    }
                }
            });

            return Mayo;

        }

        public List<Card> Junio()
        {

            List<Card> Junio = new List<Card>();


            return Junio;

        }

        public List<Card> Julio()
        {

            List<Card> Julio = new List<Card>();

            Julio.Add(new Card()
            {
                Status = CardStatus.PeriodoVacacional,
                DueDate = new DateTime(2019, 07, 29),
                StatusMessage = DifDias(new DateTime(2019, 07, 29), DateTime.Now),
                StatusMessageFileSource = StyleKit.Icons.Alert,
                Description = "Inicio",
                Title = new FormattedString()
                {
                    Spans = {
                        new Span()
                        {
                            Text = "Periodo Vacacional"
                        },
                        new Span()
                        {
                            Text = "",
                            FontAttributes = FontAttributes.Bold
                        }
                    }
                }
            });

            return Julio;


        }

        public List<Card> Agosto()
        {

            List<Card> Agosto = new List<Card>();

            Agosto.Add(new Card()
            {
                Status = CardStatus.PeriodoVacacional,
                DueDate = new DateTime(2019, 08, 02),
                StatusMessage = DifDias(new DateTime(2019, 08, 02), DateTime.Now),
                StatusMessageFileSource = StyleKit.Icons.Alert,
                Description = "Fin",
                Title = new FormattedString()
                {
                    Spans = {
                        new Span()
                        {
                            Text = "Periodo Vacacional"
                        },
                        new Span()
                        {
                            Text = "",
                            FontAttributes = FontAttributes.Bold
                        }
                    }
                }

            });

            Agosto.Add(new Card()
            {
                Status = CardStatus.SemanaEvaluacionFinal,
                DueDate = new DateTime(2019, 08, 12),
                StatusMessage = DifDias(new DateTime(2019, 08, 12), DateTime.Now),
                StatusMessageFileSource = StyleKit.Icons.Alert,
                Description = "Inicio",
                Title = new FormattedString()
                {
                    Spans = {
                        new Span()
                        {
                            Text = "Examenes Finales"
                        },
                        new Span()
                        {
                            Text = "",
                            FontAttributes = FontAttributes.Bold
                        }
                    }
                }

            });

            Agosto.Add(new Card()
            {
                Status = CardStatus.SemanaEvaluacionFinal,
                DueDate = new DateTime(2019, 08, 14),
                StatusMessage = DifDias(new DateTime(2019, 08, 14), DateTime.Now),
                StatusMessageFileSource = StyleKit.Icons.Alert,
                Description = "Fin",
                Title = new FormattedString()
                {
                    Spans = {
                        new Span()
                        {
                            Text = "Examenes Finales"
                        },
                        new Span()
                        {
                            Text = "",
                            FontAttributes = FontAttributes.Bold
                        }
                    }
                }

            });

            Agosto.Add(new Card()
            {
                Status = CardStatus.Bajas,
                DueDate = new DateTime(2019, 08, 15),
                StatusMessage = DifDias(new DateTime(2019, 08, 15), DateTime.Now),
                StatusMessageFileSource = StyleKit.Icons.Alert,
                Description = "Inicio",
                Title = new FormattedString()
                {
                    Spans = {
                        new Span()
                        {
                            Text = "Capturas de examenes finales y entrega de bajas"
                        },
                        new Span()
                        {
                            Text = "",
                            FontAttributes = FontAttributes.Bold
                        }
                    }
                }

            });

            Agosto.Add(new Card()
            {
                Status = CardStatus.Bajas,
                DueDate = new DateTime(2019, 08, 16),
                StatusMessage = DifDias(new DateTime(2019, 08, 16), DateTime.Now),
                StatusMessageFileSource = StyleKit.Icons.Alert,
                Description = "Fin",
                Title = new FormattedString()
                {
                    Spans = {
                        new Span()
                        {
                            Text = "Captura de examenes finales y entrega de bajas"
                        },
                        new Span()
                        {
                            Text = "",
                            FontAttributes = FontAttributes.Bold
                        }
                    }
                }

            });

            Agosto.Add(new Card()
            {
                Status = CardStatus.PeriodoDeRevaloracion,
                DueDate = new DateTime(2019, 08, 19),
                StatusMessage = DifDias(new DateTime(2019, 08, 19), DateTime.Now),
                StatusMessageFileSource = StyleKit.Icons.Alert,
                Description = "Inicio",
                Title = new FormattedString()
                {
                    Spans = {
                        new Span()
                        {
                            Text = "Revaloraciones Finales"
                        },
                        new Span()
                        {
                            Text = "",
                            FontAttributes = FontAttributes.Bold
                        }
                    }
                }

            });

            Agosto.Add(new Card()
            {
                Status = CardStatus.PeriodoDeRevaloracion,
                DueDate = new DateTime(2019, 08, 21),
                StatusMessage = DifDias(new DateTime(2019, 08, 21), DateTime.Now),
                StatusMessageFileSource = StyleKit.Icons.Alert,
                Description = "Fin",
                Title = new FormattedString()
                {
                    Spans = {
                        new Span()
                        {
                            Text = "Revaloraciones Finales"
                        },
                        new Span()
                        {
                            Text = "",
                            FontAttributes = FontAttributes.Bold
                        }
                    }
                }

            });

            Agosto.Add(new Card()
            {
                Status = CardStatus.CapturaDeCalificaciones,
                DueDate = new DateTime(2019, 08, 22),
                StatusMessage = DifDias(new DateTime(2019, 08, 22), DateTime.Now),
                StatusMessageFileSource = StyleKit.Icons.Alert,
                Description = "Inicio",
                Title = new FormattedString()
                {
                    Spans = {
                        new Span()
                        {
                            Text = "Captura de revaloraciones"
                        },
                        new Span()
                        {
                            Text = "",
                            FontAttributes = FontAttributes.Bold
                        }
                    }
                }

            });

            Agosto.Add(new Card()
            {
                Status = CardStatus.CapturaDeCalificaciones,
                DueDate = new DateTime(2019, 08, 23),
                StatusMessage = DifDias(new DateTime(2019, 08, 23), DateTime.Now),
                StatusMessageFileSource = StyleKit.Icons.Alert,
                Description = "Fin",
                Title = new FormattedString()
                {
                    Spans = {
                        new Span()
                        {
                            Text = "Captura de revaloraciones"
                        },
                        new Span()
                        {
                            Text = "",
                            FontAttributes = FontAttributes.Bold
                        }
                    }
                }

            });

            Agosto.Add(new Card()
            {
                Status = CardStatus.InicioYFinDeTramiteDeEstadia,
                DueDate = new DateTime(2019, 08, 23),
                StatusMessage = DifDias(new DateTime(2019, 08, 23), DateTime.Now),
                StatusMessageFileSource = StyleKit.Icons.Alert,
                Description = "Fin",
                Title = new FormattedString()
                {
                    Spans = {
                        new Span()
                        {
                            Text = "Tramite de estadias"
                        },
                        new Span()
                        {
                            Text = "",
                            FontAttributes = FontAttributes.Bold
                        }
                    }
                }

            });

            Agosto.Add(new Card()
            {
                Status = CardStatus.FinDeCuatrimestre,
                DueDate = new DateTime(2019, 08, 02),
                StatusMessage = DifDias(new DateTime(2019, 08, 02), DateTime.Now),
                StatusMessageFileSource = StyleKit.Icons.Alert,
                Description = "Fin",
                Title = new FormattedString()
                {
                    Spans = {
                        new Span()
                        {
                            Text = "Cuatrimestre"
                        },
                        new Span()
                        {
                            Text = "",
                            FontAttributes = FontAttributes.Bold
                        }
                    }
                }

            });

            Agosto.Add(new Card()
            {
                Status = CardStatus.InscripcionYResincripcion,
                DueDate = new DateTime(2019, 08, 26),
                StatusMessage = DifDias(new DateTime(2019, 08, 26), DateTime.Now),
                StatusMessageFileSource = StyleKit.Icons.Alert,
                Description = "Inicio",
                Title = new FormattedString()
                {
                    Spans = {
                        new Span()
                        {
                            Text = "Inscripciones y Reinscripciones"
                        },
                        new Span()
                        {
                            Text = "",
                            FontAttributes = FontAttributes.Bold
                        }
                    }
                }

            });

            Agosto.Add(new Card()
            {
                Status = CardStatus.InscripcionYResincripcion,
                DueDate = new DateTime(2019, 08, 30),
                StatusMessage = DifDias(new DateTime(2019, 08, 30), DateTime.Now),
                StatusMessageFileSource = StyleKit.Icons.Alert,
                Description = "Fin",
                Title = new FormattedString()
                {
                    Spans = {
                        new Span()
                        {
                            Text = "Incripciones y Reinscripciones"
                        },
                        new Span()
                        {
                            Text = "",
                            FontAttributes = FontAttributes.Bold
                        }
                    }
                }

            });

            return Agosto;

        }

        public List<Card> Septiembre()
        {

            List<Card> Septiembre = new List<Card>();

            Septiembre.Add(new Card()
            {
                Status = CardStatus.InicioCuatrimestre,
                DueDate = new DateTime(2019, 09, 02),
                StatusMessage = DifDias(new DateTime(2019, 09, 02), DateTime.Now),
                StatusMessageFileSource = StyleKit.Icons.Alert,
                Description = "Inicio",
                Title = new FormattedString()
                {
                    Spans = {
                        new Span()
                        {
                            Text = "Cuatrimestre"
                        },
                        new Span()
                        {
                            Text = "",
                            FontAttributes = FontAttributes.Bold
                        }
                    }
                }
            });

            Septiembre.Add(new Card()
            {
                Status = CardStatus.InicioYFinDeTramiteDeEstadia,
                DueDate = new DateTime(2019, 09, 03),
                StatusMessage = DifDias(new DateTime(2019, 09, 03), DateTime.Now),
                StatusMessageFileSource = StyleKit.Icons.Alert,
                Description = "Inicio",
                Title = new FormattedString()
                {
                    Spans = {
                        new Span()
                        {
                            Text = "Tramite de estadias"
                        },
                        new Span()
                        {
                            Text = "",
                            FontAttributes = FontAttributes.Bold
                        }
                    }
                }
            });

            Septiembre.Add(new Card()
            {
                Status = CardStatus.DiaFestivo,
                DueDate = new DateTime(2019, 09, 09),
                StatusMessage = DifDias(new DateTime(2019, 09, 09), DateTime.Now),
                StatusMessageFileSource = StyleKit.Icons.Alert,
                Description = "Dia Festivo",
                Title = new FormattedString()
                {
                    Spans = {
                        new Span()
                        {
                            Text = "Dia de la Independencia Nacional"
                        },
                        new Span()
                        {
                            Text = "",
                            FontAttributes = FontAttributes.Bold
                        }
                    }
                }
            });

            Septiembre.Add(new Card()
            {
                Status = CardStatus.ExamenIngresoTSU,
                DueDate = new DateTime(2019, 09, 17),
                StatusMessage = DifDias(new DateTime(2019, 09, 17), DateTime.Now),
                StatusMessageFileSource = StyleKit.Icons.Alert,
                Description = "Inicio",
                Title = new FormattedString()
                {
                    Spans = {
                        new Span()
                        {
                            Text = "Examen Alumnos de Nuevo Ingreso"
                        },
                        new Span()
                        {
                            Text = "",
                            FontAttributes = FontAttributes.Bold
                        }
                    }
                }
            });

            Septiembre.Add(new Card()
            {
                Status = CardStatus.ExamenIngresoTSU,
                DueDate = new DateTime(2019, 09, 20),
                StatusMessage = DifDias(new DateTime(2019, 09, 20), DateTime.Now),
                StatusMessageFileSource = StyleKit.Icons.Alert,
                Description = "Fin",
                Title = new FormattedString()
                {
                    Spans = {
                        new Span()
                        {
                            Text = "Examen Alumnos de Nuevo Ingreso"
                        },
                        new Span()
                        {
                            Text = "",
                            FontAttributes = FontAttributes.Bold
                        }
                    }
                }
            });

            return Septiembre;

        }

        public List<Card> Octubre()
        {

            List<Card> Octubre = new List<Card>();

            Octubre.Add(new Card()
            {
                Status = CardStatus.SemanaEquidadDeGenero,
                DueDate = new DateTime(2019, 10, 08),
                StatusMessage = DifDias(new DateTime(2019, 10, 08), DateTime.Now),
                StatusMessageFileSource = StyleKit.Icons.Alert,
                Description = "Inicio",
                Title = new FormattedString()
                {
                    Spans = {
                        new Span()
                        {
                            Text = "Semana de Equidad de Genero"
                        },
                        new Span()
                        {
                            Text = "",
                            FontAttributes = FontAttributes.Bold
                        }
                    }
                }
            });

            Octubre.Add(new Card()
            {
                Status = CardStatus.SemanaEquidadDeGenero,
                DueDate = new DateTime(2019, 10, 11),
                StatusMessage = DifDias(new DateTime(2019, 10, 11), DateTime.Now),
                StatusMessageFileSource = StyleKit.Icons.Alert,
                Description = "Fin",
                Title = new FormattedString()
                {
                    Spans = {
                        new Span()
                        {
                            Text = "Semana de Equidad de Genero"
                        },
                        new Span()
                        {
                            Text = "",
                            FontAttributes = FontAttributes.Bold
                        }
                    }
                }
            });

            return Octubre;

        }

        public List<Card> Noviembre()
        {

            List<Card> Noviembre = new List<Card>();

            Noviembre.Add(new Card()
            {
                Status = CardStatus.ForoDeInclusion,
                DueDate = new DateTime(2019, 11, 14),
                StatusMessage = DifDias(new DateTime(2019, 11, 14), DateTime.Now),
                StatusMessageFileSource = StyleKit.Icons.Alert,
                Description = "Inicio",
                Title = new FormattedString()
                {
                    Spans = {
                        new Span()
                        {
                            Text = "Foro de Inclusion"
                        },
                        new Span()
                        {
                            Text = "",
                            FontAttributes = FontAttributes.Bold
                        }
                    }
                }
            });

            Noviembre.Add(new Card()
            {
                Status = CardStatus.ForoDeInclusion,
                DueDate = new DateTime(2019, 11, 15),
                StatusMessage = DifDias(new DateTime(2019, 11, 15), DateTime.Now),
                StatusMessageFileSource = StyleKit.Icons.Alert,
                Description = "Fin",
                Title = new FormattedString()
                {
                    Spans = {
                        new Span()
                        {
                            Text = "Foro de Inclusion"
                        },
                        new Span()
                        {
                            Text = "",
                            FontAttributes = FontAttributes.Bold
                        }
                    }
                }
            });

            Noviembre.Add(new Card()
            {
                Status = CardStatus.DiaFestivo,
                DueDate = new DateTime(2019, 11, 18),
                StatusMessage = DifDias(new DateTime(2019, 11, 18), DateTime.Now),
                StatusMessageFileSource = StyleKit.Icons.Alert,
                Description = "Dia festivo",
                Title = new FormattedString()
                {
                    Spans = {
                        new Span()
                        {
                            Text = "Aniversario de la Revolucion Mexicana"
                        },
                        new Span()
                        {
                            Text = "",
                            FontAttributes = FontAttributes.Bold
                        }
                    }
                }
            });

            return Noviembre;

        }

        public List<Card> Diciembre()
        {

            List<Card> Diciembre = new List<Card>();

            Diciembre.Add(new Card()
            {
                Status = CardStatus.SemanaEvaluacionFinal,
                DueDate = new DateTime(2019, 12, 02),
                StatusMessage = DifDias(new DateTime(2019, 12, 02), DateTime.Now),
                StatusMessageFileSource = StyleKit.Icons.Alert,
                Description = "Inicio",
                Title = new FormattedString()
                {
                    Spans = {
                        new Span()
                        {
                            Text = "Evaluaciones Finales"
                        },
                        new Span()
                        {
                            Text = "",
                            FontAttributes = FontAttributes.Bold
                        }
                    }
                }
            });

            Diciembre.Add(new Card()
            {
                Status = CardStatus.SemanaEvaluacionFinal,
                DueDate = new DateTime(2019, 12, 04),
                StatusMessage = DifDias(new DateTime(2019, 12, 04), DateTime.Now),
                StatusMessageFileSource = StyleKit.Icons.Alert,
                Description = "Fin",
                Title = new FormattedString()
                {
                    Spans = {
                        new Span()
                        {
                            Text = "Evaluaciones Finales"
                        },
                        new Span()
                        {
                            Text = "",
                            FontAttributes = FontAttributes.Bold
                        }
                    }
                }
            });

            Diciembre.Add(new Card()
            {
                Status = CardStatus.Bajas,
                DueDate = new DateTime(2019, 12, 05),
                StatusMessage = DifDias(new DateTime(2019, 12, 05), DateTime.Now),
                StatusMessageFileSource = StyleKit.Icons.Alert,
                Description = "Inicio",
                Title = new FormattedString()
                {
                    Spans = {
                        new Span()
                        {
                            Text = "Captura de examenes finales y entrega de bajas"
                        },
                        new Span()
                        {
                            Text = "",
                            FontAttributes = FontAttributes.Bold
                        }
                    }
                }
            });

            Diciembre.Add(new Card()
            {
                Status = CardStatus.PeriodoDeRevaloracion,
                DueDate = new DateTime(2019, 12, 09),
                StatusMessage = DifDias(new DateTime(2019, 12, 09), DateTime.Now),
                StatusMessageFileSource = StyleKit.Icons.Alert,
                Description = "Inicio",
                Title = new FormattedString()
                {
                    Spans = {
                        new Span()
                        {
                            Text = "Revaloraciones Finales"
                        },
                        new Span()
                        {
                            Text = "",
                            FontAttributes = FontAttributes.Bold
                        }
                    }
                }
            });

            Diciembre.Add(new Card()
            {
                Status = CardStatus.PeriodoDeRevaloracion,
                DueDate = new DateTime(2019, 12, 11),
                StatusMessage = DifDias(new DateTime(2019, 12, 11), DateTime.Now),
                StatusMessageFileSource = StyleKit.Icons.Alert,
                Description = "Fin",
                Title = new FormattedString()
                {
                    Spans = {
                        new Span()
                        {
                            Text = "Revaloraciones Finales"
                        },
                        new Span()
                        {
                            Text = "",
                            FontAttributes = FontAttributes.Bold
                        }
                    }
                }
            });

            Diciembre.Add(new Card()
            {
                Status = CardStatus.Bajas,
                DueDate = new DateTime(2019, 12, 06),
                StatusMessage = DifDias(new DateTime(2019, 12, 06), DateTime.Now),
                StatusMessageFileSource = StyleKit.Icons.Alert,
                Description = "Fin",
                Title = new FormattedString()
                {
                    Spans = {
                        new Span()
                        {
                            Text = "Captura de examenes finales y entrega de bajas"
                        },
                        new Span()
                        {
                            Text = "",
                            FontAttributes = FontAttributes.Bold
                        }
                    }
                }
            });

            Diciembre.Add(new Card()
            {
                Status = CardStatus.InicioYFinDeTramiteDeEstadia,
                DueDate = new DateTime(2019, 12, 13),
                StatusMessage = DifDias(new DateTime(2019, 12, 13), DateTime.Now),
                StatusMessageFileSource = StyleKit.Icons.Alert,
                Description = "Fin",
                Title = new FormattedString()
                {
                    Spans = {
                        new Span()
                        {
                            Text = "Tramite de estadias"
                        },
                        new Span()
                        {
                            Text = "",
                            FontAttributes = FontAttributes.Bold
                        }
                    }
                }
            });

            Diciembre.Add(new Card()
            {
                Status = CardStatus.FinDeCuatrimestre,
                DueDate = new DateTime(2019, 12, 13),
                StatusMessage = DifDias(new DateTime(2019, 12, 13), DateTime.Now),
                StatusMessageFileSource = StyleKit.Icons.Alert,
                Description = "Fin",
                Title = new FormattedString()
                {
                    Spans = {
                        new Span()
                        {
                            Text = "Cuatrimestre"
                        },
                        new Span()
                        {
                            Text = "",
                            FontAttributes = FontAttributes.Bold
                        }
                    }
                }
            });

            Diciembre.Add(new Card()
            {
                Status = CardStatus.InscripcionYResincripcion,
                DueDate = new DateTime(2019, 12, 16),
                StatusMessage = DifDias(new DateTime(2019, 12, 16), DateTime.Now),
                StatusMessageFileSource = StyleKit.Icons.Alert,
                Description = "Inicio",
                Title = new FormattedString()
                {
                    Spans = {
                        new Span()
                        {
                            Text = "Incripciones y Reinscripciones"
                        },
                        new Span()
                        {
                            Text = "",
                            FontAttributes = FontAttributes.Bold
                        }
                    }
                }
            });

            Diciembre.Add(new Card()
            {
                Status = CardStatus.InscripcionYResincripcion,
                DueDate = new DateTime(2019, 12, 20),
                StatusMessage = DifDias(new DateTime(2019, 12, 20), DateTime.Now),
                StatusMessageFileSource = StyleKit.Icons.Alert,
                Description = "Fin",
                Title = new FormattedString()
                {
                    Spans = {
                        new Span()
                        {
                            Text = "Inscripciones y Reinscripciones"
                        },
                        new Span()
                        {
                            Text = "",
                            FontAttributes = FontAttributes.Bold
                        }
                    }
                }
            });

            Diciembre.Add(new Card()
            {
                Status = CardStatus.PeriodoVacacional,
                DueDate = new DateTime(2019, 12, 23),
                StatusMessage = DifDias(new DateTime(2019, 12, 23), DateTime.Now),
                StatusMessageFileSource = StyleKit.Icons.Alert,
                Description = "Inicio",
                Title = new FormattedString()
                {
                    Spans = {
                        new Span()
                        {
                            Text = "Periodo Vacacional"
                        },
                        new Span()
                        {
                            Text = "",
                            FontAttributes = FontAttributes.Bold
                        }
                    }
                }
            });

            Diciembre.Add(new Card()
            {
                Status = CardStatus.DiaFestivo,
                DueDate = new DateTime(2019, 12, 25),
                StatusMessage = DifDias(new DateTime(2019, 12, 25), DateTime.Now),
                StatusMessageFileSource = StyleKit.Icons.Alert,
                Description = "Dia Festivo",
                Title = new FormattedString()
                {
                    Spans = {
                        new Span()
                        {
                            Text = "Navidad"
                        },
                        new Span()
                        {
                            Text = "",
                            FontAttributes = FontAttributes.Bold
                        }
                    }
                }
            });

            return Diciembre;

        }

        public string DifDias(DateTime fechadelEvento, DateTime fechaToday)
        {
            TimeSpan difDias = fechadelEvento - fechaToday;

            string message = "Faltan " + difDias.Days + " Dias";

            return message;
        }
    }
}
