using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UT_Escobedo.Model.OfertaEducativaModelo.Cuatrimestres;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UT_Escobedo.Views.Oferta_Educativa
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Ing_Page : ContentPage
    {

        public List<Primero> primeros { get; set; }
        public List<Segundo> Segundos { get; set; }
        public List<Tercero> Terceros { get; set; }
        public List<Cuarto> Cuartos { get; set; }
        public List<Quinto> Quintos { get; set; }

        public Ing_Page()
        {
            InitializeComponent();

            int IdIng = Ing.IdIng;

            switch (IdIng)
            {

                #region Case 1

                case 1:

                    //ING. Tecnologia de la informacion

                    #region Septimo Cuatrimestre

                    primeros = new List<Primero>();

                    var IngPrimeroTiM1 = new Primero() { Id = 1, PMateria = "INGENIERIA ECONOMICA" };
                    primeros.Add(IngPrimeroTiM1);

                    var IngPrimeroTiM2 = new Primero() { Id = 2, PMateria = "PROCESOS DE DESARROLLO DE SOFTWARE" };
                    primeros.Add(IngPrimeroTiM2);

                    var IngPrimeroTiM3 = new Primero() { Id = 3, PMateria = "INGLÉS VI" };
                    primeros.Add(IngPrimeroTiM3);

                    var IngPrimeroTiM4 = new Primero() { Id = 4, PMateria = "ADMINISTRACIÓN DEL TIEMPO" };
                    primeros.Add(IngPrimeroTiM4);

                    var IngPrimeroTiM5 = new Primero() { Id = 5, PMateria = "PROGRAMACIÓN DE APLICACIONES" };
                    primeros.Add(IngPrimeroTiM5);

                    var IngPrimeroTiM6 = new Primero() { Id = 6, PMateria = "MODELADO DE PROCESOS DE NEGOCIOS" };
                    primeros.Add(IngPrimeroTiM6);

                    var IngPrimeroTiM7 = new Primero() { Id = 7, PMateria = "MATEMÁTICAS PARA TI" };
                    primeros.Add(IngPrimeroTiM7);

                    PrimeraLista.Text = "Septima Cuatrimestre";

                    ListPrimero.ItemsSource = primeros;

                    #endregion

                    #region Octavo Cuatrimestre

                    Segundos = new List<Segundo>();

                    var IngSegundoTiM1 = new Segundo() { Id = 1, SMateria = "ADMINISTRACION DE PROYECTOS DE TI I" };
                    Segundos.Add(IngSegundoTiM1);

                    var IngSegundoTiM2 = new Segundo() { Id = 2, SMateria = "BASE DE DATOS PARA APLICACIONES" };
                    Segundos.Add(IngSegundoTiM2);

                    var IngSegundoTiM3 = new Segundo() { Id = 3, SMateria = "REDES CONVERGENTES" };
                    Segundos.Add(IngSegundoTiM3);

                    var IngSegundoTiM4 = new Segundo() { Id = 4, SMateria = "SISTEMAS DE CALIDAD DE TI" };
                    Segundos.Add(IngSegundoTiM4);

                    var IngSegundoTiM5 = new Segundo() { Id = 5, SMateria = "INGLÉS VII" };
                    Segundos.Add(IngSegundoTiM5);

                    var IngSegundoTiM6 = new Segundo() { Id = 6, SMateria = "PLANEACIÓN Y ORGANIZACIÓN DEL TRABAJO" };
                    Segundos.Add(IngSegundoTiM6);

                    SegundaLista.Text = "Octavo Cuatrimestre";

                    ListSegundo.ItemsSource = Segundos;

                    #endregion

                    #region Noveno Cuatrimestre

                    Terceros = new List<Tercero>();

                    var IngTercerosTiM1 = new Tercero() { Id = 1, TMateria = "ADMINISTRACION DE PROYECTOS DE TI II" };
                    Terceros.Add(IngTercerosTiM1);

                    var IngTercerosTiM2 = new Tercero() { Id = 2, TMateria = "DESARROLLO DE APLICACIONES WEB" };
                    Terceros.Add(IngTercerosTiM2);

                    var IngTercerosTiM3 = new Tercero() { Id = 3, TMateria = "APLICACIÓN DE LAS TELECOMUNICACIONES" };
                    Terceros.Add(IngTercerosTiM3);

                    var IngTercerosTiM4 = new Tercero() { Id = 4, TMateria = "INTEGRADORA I" };
                    Terceros.Add(IngTercerosTiM4);

                    var IngTercerosTiM5 = new Tercero() { Id = 5, TMateria = "INGLÉS VIII" };
                    Terceros.Add(IngTercerosTiM5);

                    var IngTercerosTiM6 = new Tercero() { Id = 6, TMateria = "DIRECCIÓN DE EQUIPOS DE ALTO RENDIMIENTO" };
                    Terceros.Add(IngTercerosTiM6);

                    var IngTercerosTiM7 = new Tercero() { Id = 7, TMateria = "SISTEMAS INFORMÁTICOS" };
                    Terceros.Add(IngTercerosTiM7);

                    TerceraLista.Text = "Noveno Cuatrimestre";

                    ListTercero.ItemsSource = Terceros;

                    #endregion

                    #region Decimo Cuatrimestre

                    Cuartos = new List<Cuarto>();

                    var IngCuartoTiM1 = new Cuarto() { Id = 1, CMateria = "ESTADISTICA APLICADA" };
                    Cuartos.Add(IngCuartoTiM1);

                    var IngCuartoTiM2 = new Cuarto() { Id = 2, CMateria = "AUDITORIA DE SISTEMAS DE TI" };
                    Cuartos.Add(IngCuartoTiM2);

                    var IngCuartoTiM3 = new Cuarto() { Id = 3, CMateria = "SEGURIDAD DE LA INFORMACIÓN" };
                    Cuartos.Add(IngCuartoTiM3);

                    var IngCuartoTiM4 = new Cuarto() { Id = 4, CMateria = "TÓPICOS SELECTOS DE TI" };
                    Cuartos.Add(IngCuartoTiM4);

                    var IngCuartoTiM5 = new Cuarto() { Id = 5, CMateria = "INTEGRADORA II" };
                    Cuartos.Add(IngCuartoTiM5);

                    var IngCuartoTiM6 = new Cuarto() { Id = 6, CMateria = "INGLES IX" };
                    Cuartos.Add(IngCuartoTiM6);

                    var IngCuartoTiM7 = new Cuarto() { Id = 7, CMateria = "NEGOCIACIÓN EMPRESARIAL" };
                    Cuartos.Add(IngCuartoTiM7);

                    CuartaLista.Text = "Decimo Cuatrimestre";

                    ListCuarto.ItemsSource = Cuartos;

                    #endregion

                    #region Onceavo Cuatrimestre

                    Quintos = new List<Quinto>();

                    var IngQuintoTiM1 = new Quinto() { Id = 1, QMateria = "ESTADIA" };
                    Quintos.Add(IngQuintoTiM1);

                    QuintaLista.Text = "Onceavo Cuatrimestre";

                    ListQuinto.ItemsSource = Quintos;

                    #endregion

                    break;

                #endregion

                #region Case 2

                case 2:

                    //Mecatronica

                    #region Septimo cuatrimestre

                    primeros = new List<Primero>();

                    var IngPrimeroMECAM1 = new Primero() { Id = 1, PMateria = "MATEMÁTICAS PARA INGENIERÍA I" };
                    primeros.Add(IngPrimeroMECAM1);

                    var IngPrimeroMECAM2 = new Primero() { Id = 2, PMateria = "FÍSICA PARA INGENIERÍA" };
                    primeros.Add(IngPrimeroMECAM2);

                    var IngPrimeroMECAM3 = new Primero() { Id = 3, PMateria = "INSTRUMENTACIÓN VIRTUAL" };
                    primeros.Add(IngPrimeroMECAM3);

                    var IngPrimeroMECAM4 = new Primero() { Id = 4, PMateria = "ELECTRICIDAD INDUSTRIAL" };
                    primeros.Add(IngPrimeroMECAM4);

                    var IngPrimeroMECAM5 = new Primero() { Id = 5, PMateria = "INGLÉS VI" };
                    primeros.Add(IngPrimeroMECAM5);

                    var IngPrimeroMECAM6 = new Primero() { Id = 6, PMateria = "ADMINISTRACIÓN DEL TIEMPO" };
                    primeros.Add(IngPrimeroMECAM6);

                    PrimeraLista.Text = "Septimo Cuatrimestre";

                    ListPrimero.ItemsSource = primeros;

                    #endregion

                    #region Octavo Cuatrimestre

                    Segundos = new List<Segundo>();

                    var IngSegundoMECAM1 = new Segundo() { Id = 1, SMateria = "MATEMÁTICAS PARA INGENIERÍA II" };
                    Segundos.Add(IngSegundoMECAM1);

                    var IngSegundoMECAM2 = new Segundo() { Id = 2, SMateria = "MECÁNICA PARA LA AUTOMATIZACIÓN" };
                    Segundos.Add(IngSegundoMECAM2);

                    var IngSegundoMECAM3 = new Segundo() { Id = 3, SMateria = "CONTROL DE MOTORES II" };
                    Segundos.Add(IngSegundoMECAM3);

                    var IngSegundoMECAM4 = new Segundo() { Id = 4, SMateria = "DISEÑO ASISTIDO POR COMPUTADORA" };
                    Segundos.Add(IngSegundoMECAM4);

                    var IngSegundoMECAM5 = new Segundo() { Id = 5, SMateria = "INGLÉS VII" };
                    Segundos.Add(IngSegundoMECAM5);

                    var IngSegundoMECAM6 = new Segundo() { Id = 6, SMateria = "PLANEACIÓN Y ORGANIZACIÓN DE TRABAJO" };
                    Segundos.Add(IngSegundoMECAM6);

                    SegundaLista.Text = "Octavo Cuatrimestre";

                    ListSegundo.ItemsSource = Segundos;

                    #endregion

                    #region Noveno Cuatrimestre

                    Terceros = new List<Tercero>();

                    var IngTercerosMECAM1 = new Tercero() { Id = 1, TMateria = "CONTROL AUTOMÁTICO" };
                    Terceros.Add(IngTercerosMECAM1);

                    var IngTercerosMECAM2 = new Tercero() { Id = 2, TMateria = "INGENIERÍA DE PROYECTOS" };
                    Terceros.Add(IngTercerosMECAM2);

                    var IngTercerosMECAM3 = new Tercero() { Id = 3, TMateria = "SISTEMAS MECÁNICOS II" };
                    Terceros.Add(IngTercerosMECAM3);

                    var IngTercerosMECAM4 = new Tercero() { Id = 4, TMateria = "ROBÓTICA INDUSTRIAL" };
                    Terceros.Add(IngTercerosMECAM4);

                    var IngTercerosMECAM5 = new Tercero() { Id = 5, TMateria = "NGLÉS VIII" };
                    Terceros.Add(IngTercerosMECAM5);

                    var IngTercerosMECAM6 = new Tercero() { Id = 6, TMateria = "DIRECCIÓN DE EQUIPOS DE ALTO RENDIMIENTO" };
                    Terceros.Add(IngTercerosMECAM6);

                    TerceraLista.Text = "Noveno Cuatrimestre";

                    ListTercero.ItemsSource = Terceros;

                    #endregion

                    #region Decimo cuatrimestre

                    Cuartos = new List<Cuarto>();

                    var IngCuartoMECAM1 = new Cuarto() { Id = 1, CMateria = "SISTEMAS DE MANUFACTURA FLEXIBLE" };
                    Cuartos.Add(IngCuartoMECAM1);

                    var IngCuartoMECAM2 = new Cuarto() { Id = 2, CMateria = "CONTROL LÓGICO AVANZADO" };
                    Cuartos.Add(IngCuartoMECAM2);

                    var IngCuartoMECAM3 = new Cuarto() { Id = 3, CMateria = "DISPOSITIVOS DIGITALES PROGRAMABLES" };
                    Cuartos.Add(IngCuartoMECAM3);

                    var IngCuartoMECAM4 = new Cuarto() { Id = 4, CMateria = "INTEGRADORA III" };
                    Cuartos.Add(IngCuartoMECAM4);

                    var IngCuartoMECAM5 = new Cuarto() { Id = 5, CMateria = "INGLÉS IX" };
                    Cuartos.Add(IngCuartoMECAM5);

                    var IngCuartoMECAM6 = new Cuarto() { Id = 6, CMateria = "NEGOCIACIÓN EMPRESARIA" };
                    Cuartos.Add(IngCuartoMECAM6);

                    CuartaLista.Text = "Decimo Cuatrimestre";

                    ListCuarto.ItemsSource = Cuartos;

                    #endregion

                    #region Onceavo Cuatrimestre

                    Quintos = new List<Quinto>();

                    var IngQuintoMECAM1 = new Quinto() { Id = 1, QMateria = "ESTADIA" };
                    Quintos.Add(IngQuintoMECAM1);

                    QuintaLista.Text = "Onceavo Cuatrimestre";

                    ListQuinto.ItemsSource = Quintos;

                    #endregion

                    break;

                #endregion

                #region Case 3

                case 3:

                    //Mantenimiento Industrial

                    #region Septimo cuatrimestre

                    primeros = new List<Primero>();

                    var IngPrimeroMIM1 = new Primero() { Id = 1, PMateria = "MATEMÁTICAS PARA INGENIERÍA I" };
                    primeros.Add(IngPrimeroMIM1);

                    var IngPrimeroMIM2 = new Primero() { Id = 2, PMateria = "FÍSICA PARA INGENIERÍA" };
                    primeros.Add(IngPrimeroMIM2);

                    var IngPrimeroMIM3 = new Primero() { Id = 3, PMateria = "PROTOCOLOS DE OPERACIÓN Y MANTENIMIENTO" };
                    primeros.Add(IngPrimeroMIM3);

                    var IngPrimeroMIM4 = new Primero() { Id = 4, PMateria = "TRIBOLOGÍA" };
                    primeros.Add(IngPrimeroMIM4);

                    var IngPrimeroMIM5 = new Primero() { Id = 5, PMateria = "INGLÉS VI" };
                    primeros.Add(IngPrimeroMIM5);

                    var IngPrimeroMIM6 = new Primero() { Id = 6, PMateria = "PLANEACIÓN Y ORGANIZACIÓN DEL TRABAJO" };
                    primeros.Add(IngPrimeroMIM6);

                    var IngPrimeroMIM7 = new Primero() { Id = 7, PMateria = "ADMINISTRACIÓN DEL TIEMPO" };
                    primeros.Add(IngPrimeroMIM7);

                    PrimeraLista.Text = "Septimo Cuatrimestre";

                    ListPrimero.ItemsSource = primeros;

                    #endregion

                    #region Octavo Cuatrimestre

                    Segundos = new List<Segundo>();

                    var IngSegundoMIM1 = new Segundo() { Id = 1, SMateria = "MATEMÁTICAS PARA INGENIERÍA II" };
                    Segundos.Add(IngSegundoMIM1);

                    var IngSegundoMIM2 = new Segundo() { Id = 2, SMateria = "TÉCNICAS TPM Y RCM" };
                    Segundos.Add(IngSegundoMIM2);

                    var IngSegundoMIM3 = new Segundo() { Id = 3, SMateria = "ENSAYOS DESTRUCTIVOS" };
                    Segundos.Add(IngSegundoMIM3);

                    var IngSegundoMIM4 = new Segundo() { Id = 4, SMateria = "INTEGRADORA I" };
                    Segundos.Add(IngSegundoMIM4);

                    var IngSegundoMIM5 = new Segundo() { Id = 5, SMateria = "GESTIÓN AMBIENTAL" };
                    Segundos.Add(IngSegundoMIM5);

                    var IngSegundoMIM6 = new Segundo() { Id = 6, SMateria = "INGLÉS VII" };
                    Segundos.Add(IngSegundoMIM6);

                    SegundaLista.Text = "Octavo Cuatrimestre";

                    ListSegundo.ItemsSource = Segundos;

                    #endregion

                    #region Noveno Cuatrimestre

                    Terceros = new List<Tercero>();

                    var IngTercerosMIM1 = new Tercero() { Id = 1, TMateria = "ADMINISTRACIÓN ESTRATÉGICA PARA MANTENIMIENTO" };
                    Terceros.Add(IngTercerosMIM1);

                    var IngTercerosMIM2 = new Tercero() { Id = 2, TMateria = "MANTENIMIENTO PREDICTIVO MECÁNICO" };
                    Terceros.Add(IngTercerosMIM2);

                    var IngTercerosMIM3 = new Tercero() { Id = 3, TMateria = "SISTEMAS AUTOMATIZADOS Y REDES INDUSTRIALES" };
                    Terceros.Add(IngTercerosMIM3);

                    var IngTercerosMIM4 = new Tercero() { Id = 4, TMateria = "INGLÉS VIII" };
                    Terceros.Add(IngTercerosMIM4);

                    var IngTercerosMIM5 = new Tercero() { Id = 5, TMateria = "DIRECCIÓN DE EQUIPOS DE ALTO RENDIMIENTO" };
                    Terceros.Add(IngTercerosMIM5);

                    TerceraLista.Text = "Noveno Cuatrimestre";

                    ListTercero.ItemsSource = Terceros;

                    #endregion

                    #region Decimo Cuatrimestre

                    Cuartos = new List<Cuarto>();

                    var IngCuartoMIM1 = new Cuarto() { Id = 1, CMateria = "ENSAYOS NO DESTRUCTIVOS" };
                    Cuartos.Add(IngCuartoMIM1);

                    var IngCuartoMIM2 = new Cuarto() { Id = 2, CMateria = "VISUALIZACIÓN Y CONTROL DE PROCESOS" };
                    Cuartos.Add(IngCuartoMIM2);

                    var IngCuartoMIM3 = new Cuarto() { Id = 3, CMateria = "INTEGRADORA II" };
                    Cuartos.Add(IngCuartoMIM3);

                    var IngCuartoMIM4 = new Cuarto() { Id = 4, CMateria = "PROYECTOS TECNOLÓGICOS Y DE SERVICIOS" };
                    Cuartos.Add(IngCuartoMIM4);

                    var IngCuartoMIM5 = new Cuarto() { Id = 5, CMateria = "INGLÉS IX" };
                    Cuartos.Add(IngCuartoMIM5);

                    var IngCuartoMIM6 = new Cuarto() { Id = 6, CMateria = "NEGOCIACION EMPRESARIAL" };
                    Cuartos.Add(IngCuartoMIM6);

                    CuartaLista.Text = "Decimo Cuatrimestre";

                    ListCuarto.ItemsSource = Cuartos;

                    #endregion

                    #region Onceavo Cuatrimestre

                    Quintos = new List<Quinto>();

                    var IngQuintoMIM1 = new Quinto() { Id = 1, QMateria = "ESTADIA" };
                    Quintos.Add(IngQuintoMIM1);

                    QuintaLista.Text = "Onceavo Cuatrimestre";

                    ListQuinto.ItemsSource = Quintos;

                    #endregion

                    break;

                #endregion

                #region Case 4

                case 4:

                    #region Septimo DNI 

                    primeros = new List<Primero>();

                    var IngPrimeroDIEM1 = new Primero() { Id = 1, PMateria = "ESTADÍSTICA PARA NEGOCIOS" };
                    primeros.Add(IngPrimeroDIEM1);

                    var IngPrimeroDIEM2 = new Primero() { Id = 2, PMateria = "ECONOMÍA PARA LOS NEGOCIOS" };
                    primeros.Add(IngPrimeroDIEM2);

                    var IngPrimeroDIEM3 = new Primero() { Id = 3, PMateria = "GESTIÓN DE COMPRAS" };
                    primeros.Add(IngPrimeroDIEM3);

                    var IngPrimeroDIEM4 = new Primero() { Id = 4, PMateria = "DERECHO CORPORATIVO" };
                    primeros.Add(IngPrimeroDIEM4);

                    var IngPrimeroDIEM5 = new Primero() { Id = 5, PMateria = "INGLÉS VI" };
                    primeros.Add(IngPrimeroDIEM5);

                    var IngPrimeroDIEM6 = new Primero() { Id = 6, PMateria = "ADMINISTRACIÓN DEL TIEMPO" };
                    primeros.Add(IngPrimeroDIEM6);

                    PrimeraLista.Text = "Septimo Cuatrimestre";

                    ListPrimero.ItemsSource = primeros;

                    #endregion

                    #region Octavo Cuatrimestre

                    Segundos = new List<Segundo>();

                    var IngSegundoDIEM1 = new Segundo() { Id = 1, SMateria = "ADMINISTRACIÓN FINANCIERA" };
                    Segundos.Add(IngSegundoDIEM1);

                    var IngSegundoDIEM2 = new Segundo() { Id = 2, SMateria = "ESTRATEGIAS PARA NUEVOS NEGOCIOS" };
                    Segundos.Add(IngSegundoDIEM2);

                    var IngSegundoDIEM3 = new Segundo() { Id = 3, SMateria = "DIRECCIÓN DE CAPITAL HUMANO I" };
                    Segundos.Add(IngSegundoDIEM3);

                    var IngSegundoDIEM4 = new Segundo() { Id = 4, SMateria = "CREATIVIDAD EMPRESARIAL" };
                    Segundos.Add(IngSegundoDIEM4);

                    var IngSegundoDIEM5 = new Segundo() { Id = 5, SMateria = "INGLÉS VII" };
                    Segundos.Add(IngSegundoDIEM5);

                    var IngSegundoDIEM6 = new Segundo() { Id = 6, SMateria = "PLANEACIÓN Y ORGANIZACIÓN DE TRABAJO" };
                    Segundos.Add(IngSegundoDIEM6);

                    SegundaLista.Text = "Octavo Cuatrimestre";

                    ListSegundo.ItemsSource = Segundos;

                    #endregion

                    #region Noveno Cuatrimestre

                    Terceros = new List<Tercero>();

                    var IngTercerosDIEM1 = new Tercero() { Id = 1, TMateria = "TÉCNICAS PARA LA INNOVACIÓN" };
                    Terceros.Add(IngTercerosDIEM1);

                    var IngTercerosDIEM2 = new Tercero() { Id = 2, TMateria = "SISTEMAS DE CONTROL ADMINISTRATIVO" };
                    Terceros.Add(IngTercerosDIEM2);

                    var IngTercerosDIEM3 = new Tercero() { Id = 3, TMateria = "ESTRATEGIAS CORPORATIVAS DE VENTAS" };
                    Terceros.Add(IngTercerosDIEM3);

                    var IngTercerosDIEM4 = new Tercero() { Id = 4, TMateria = "INTEGRADORA I" };
                    Terceros.Add(IngTercerosDIEM4);

                    var IngTercerosDIEM5 = new Tercero() { Id = 5, TMateria = "ADMINISTRACIÓN GLOBAL" };
                    Terceros.Add(IngTercerosDIEM5);

                    var IngTercerosDIEM6 = new Tercero() { Id = 6, TMateria = "INGLÉS VIII" };
                    Terceros.Add(IngTercerosDIEM6);

                    var IngTercerosDIEM7 = new Tercero() { Id = 7, TMateria = "DIRECCIÓN DE EQUIPOS DE ALTO RENDIMIENTO" };
                    Terceros.Add(IngTercerosDIEM7);

                    TerceraLista.Text = "Noveno Cuatrimestre";

                    ListTercero.ItemsSource = Terceros;

                    #endregion

                    #region Decimo Cuatrimestre

                    Cuartos = new List<Cuarto>();

                    var IngCuartoDIEM1 = new Cuarto() { Id = 1, CMateria = "INGENIERÍA FINANCIERA" };
                    Cuartos.Add(IngCuartoDIEM1);

                    var IngCuartoDIEM2 = new Cuarto() { Id = 2, CMateria = "DESARROLLO EMPRESARIAL" };
                    Cuartos.Add(IngCuartoDIEM2);

                    var IngCuartoDIEM3 = new Cuarto() { Id = 3, CMateria = "DIRECCIÓN DE CAPITAL HUMANO II" };
                    Cuartos.Add(IngCuartoDIEM3);

                    var IngCuartoDIEM4 = new Cuarto() { Id = 4, CMateria = "REINGENIERÍA ORGANIZACIONAL" };
                    Cuartos.Add(IngCuartoDIEM4);

                    var IngCuartoDIEM5 = new Cuarto() { Id = 5, CMateria = "INTEGRADORA II" };
                    Cuartos.Add(IngCuartoDIEM5);

                    var IngCuartoDIEM6 = new Cuarto() { Id = 6, CMateria = "INGLÉS IX" };
                    Cuartos.Add(IngCuartoDIEM6);

                    var IngCuartoDIEM7 = new Cuarto() { Id = 7, CMateria = "NEGOCIACIÓN EMPRESARIA" };
                    Cuartos.Add(IngCuartoDIEM7);

                    CuartaLista.Text = "Decimo Cuatrimestre";

                    ListCuarto.ItemsSource = Cuartos;

                    #endregion

                    #region Onceavo Cuatrimestre

                    Quintos = new List<Quinto>();

                    var IngQuintoDIEM1 = new Quinto() { Id = 1, QMateria = "ESTADIA" };
                    Quintos.Add(IngQuintoDIEM1);

                    QuintaLista.Text = "Onceavo Cuatrimestre";

                    ListQuinto.ItemsSource = Quintos;

                    #endregion

                    break;

                #endregion

                #region Case 5

                //Tecnologia Ambiental

                case 5:

                    #region Septimo Cuatrimestre 

                    primeros = new List<Primero>();

                    var IngPrimeroTAM1 = new Primero() { Id = 1, PMateria = "MATEMÁTICAS PARA INGENIERÍA I" };
                    primeros.Add(IngPrimeroTAM1);

                    var IngPrimeroTAM2 = new Primero() { Id = 2, PMateria = "QUÍMICA AMBIENTAL I" };
                    primeros.Add(IngPrimeroTAM2);

                    var IngPrimeroTAM3 = new Primero() { Id = 3, PMateria = "PLANEACIÓN Y ORGANIZACIÓN DEL TRABAJO" };
                    primeros.Add(IngPrimeroTAM3);

                    var IngPrimeroTAM4 = new Primero() { Id = 4, PMateria = "EVALUACIÓN DE RIESGO" };
                    primeros.Add(IngPrimeroTAM4);

                    var IngPrimeroTAM5 = new Primero() { Id = 5, PMateria = "INGLÉS VI" };
                    primeros.Add(IngPrimeroTAM5);

                    var IngPrimeroTAM6 = new Primero() { Id = 6, PMateria = "ADMINISTRACIÓN DEL TIEMPO" };
                    primeros.Add(IngPrimeroTAM6);

                    PrimeraLista.Text = "Septimo Cuatrimestre";

                    ListPrimero.ItemsSource = primeros;

                    #endregion

                    #region Octavo Cuatrimestre

                    Segundos = new List<Segundo>();

                    var IngSegundoTAM1 = new Segundo() { Id = 1, SMateria = "MATEMÁTICAS PARA INGENIERÍA II" };
                    Segundos.Add(IngSegundoTAM1);

                    var IngSegundoTAM2 = new Segundo() { Id = 2, SMateria = "QUÍMICA AMBIENTAL II" };
                    Segundos.Add(IngSegundoTAM2);

                    var IngSegundoTAM3 = new Segundo() { Id = 3, SMateria = "PRODUCCIÓN SUSTENTABLE" };
                    Segundos.Add(IngSegundoTAM3);

                    var IngSegundoTAM4 = new Segundo() { Id = 4, SMateria = "EVALUACIÓN DEL IMPACTO AMBIENTAL" };
                    Segundos.Add(IngSegundoTAM4);

                    var IngSegundoTAM5 = new Segundo() { Id = 5, SMateria = "INGLÉS VII" };
                    Segundos.Add(IngSegundoTAM5);

                    var IngSegundoTAM6 = new Segundo() { Id = 6, SMateria = "DISEÑO DE EXPERIMENTOS" };
                    Segundos.Add(IngSegundoTAM6);

                    SegundaLista.Text = "Octavo Cuatrimestre";

                    ListSegundo.ItemsSource = Segundos;

                    #endregion

                    #region Noveno Cuatrimestre

                    Terceros = new List<Tercero>();

                    var IngTercerosTAM1 = new Tercero() { Id = 1, TMateria = "OPERACIONES UNITARIAS I" };
                    Terceros.Add(IngTercerosTAM1);

                    var IngTercerosTAM2 = new Tercero() { Id = 2, TMateria = "BIOTECNOLOGÍA AMBIENTAL" };
                    Terceros.Add(IngTercerosTAM2);

                    var IngTercerosTAM3 = new Tercero() { Id = 3, TMateria = "INGENIERÍA ECONÓMICA" };
                    Terceros.Add(IngTercerosTAM3);

                    var IngTercerosTAM4 = new Tercero() { Id = 4, TMateria = "AUDITOR INTERNO ISO 14000" };
                    Terceros.Add(IngTercerosTAM4);

                    var IngTercerosTAM5 = new Tercero() { Id = 5, TMateria = "INGLÉS VIII" };
                    Terceros.Add(IngTercerosTAM5);

                    var IngTercerosTAM6 = new Tercero() { Id = 6, TMateria = "	DIRECCIÓN DE EQUIPOS DE ALTO RENDIMIENTO" };
                    Terceros.Add(IngTercerosTAM6);

                    TerceraLista.Text = "Noveno Cuatrimestre";

                    ListTercero.ItemsSource = Terceros;

                    #endregion

                    #region Decimo Cuatrimestre

                    Cuartos = new List<Cuarto>();

                    var IngCuartoTAM1 = new Cuarto() { Id = 1, CMateria = "OPERACIONES UNITARIAS II" };
                    Cuartos.Add(IngCuartoTAM1);

                    var IngCuartoTAM2 = new Cuarto() { Id = 1, CMateria = "SISTEMAS DE GESTIÓN" };
                    Cuartos.Add(IngCuartoTAM2);

                    var IngCuartoTAM3 = new Cuarto() { Id = 3, CMateria = "TECNOLOGÍAS AMBIENTALES" };
                    Cuartos.Add(IngCuartoTAM3);

                    var IngCuartoTAM4 = new Cuarto() { Id = 4, CMateria = "INTEGRADORA III" };
                    Cuartos.Add(IngCuartoTAM4);

                    var IngCuartoTAM5 = new Cuarto() { Id = 5, CMateria = "INGLÉS IX" };
                    Cuartos.Add(IngCuartoTAM5);

                    var IngCuartoTAM6 = new Cuarto() { Id = 6, CMateria = "NEGOCIACIÓN EMPRESARIAL" };
                    Cuartos.Add(IngCuartoTAM6);

                    CuartaLista.Text = "Decimo Cuatrimestre";

                    ListCuarto.ItemsSource = Cuartos;

                    #endregion

                    #region Onceavo Cuatrimestre

                    Quintos = new List<Quinto>();

                    var IngQuintoTAM1 = new Quinto() { Id = 1, QMateria = "ESTADIA" };
                    Quintos.Add(IngQuintoTAM1);

                    QuintaLista.Text = "Onceavo Cuatrimestre";

                    ListQuinto.ItemsSource = Quintos;

                    #endregion

                    break;
                #endregion

                #region Case 6

                //Gestion Educativa
                case 6:

                    #region Septimo Cuatrimestre

                    primeros = new List<Primero>();

                    var IngPrimeroGEM1 = new Primero() { Id = 1, PMateria = "HISTORIA DE LA EDUCACIÓN" };
                    primeros.Add(IngPrimeroGEM1);

                    var IngPrimeroGEM2 = new Primero() { Id = 2, PMateria = "POLÍTICA EDUCATIVA" };
                    primeros.Add(IngPrimeroGEM2);

                    var IngPrimeroGEM3 = new Primero() { Id = 3, PMateria = "GESTIÓN EDUCATIVA I" };
                    primeros.Add(IngPrimeroGEM3);

                    var IngPrimeroGEM4 = new Primero() { Id = 4, PMateria = "PSICOLINGUISTICA" };
                    primeros.Add(IngPrimeroGEM4);

                    var IngPrimeroGEM5 = new Primero() { Id = 5, PMateria = "INGLÉS VI" };
                    primeros.Add(IngPrimeroGEM5);

                    var IngPrimeroGEM6 = new Primero() { Id = 6, PMateria = "ADMINISTRACIÓN DEL TIEMPO" };
                    primeros.Add(IngPrimeroGEM6);

                    PrimeraLista.Text = "Septimo Cuatrimestre";

                    ListPrimero.ItemsSource = primeros;

                    #endregion

                    #region Octavo Cuatrimestre

                    Segundos = new List<Segundo>();

                    var IngSegundoGEM1 = new Segundo() { Id = 1, SMateria = "TEORÍAS DEL APRENDIZAJE" };
                    Segundos.Add(IngSegundoGEM1);

                    var IngSegundoGEM2 = new Segundo() { Id = 2, SMateria = "FUNDAMENTOS DE CONTABILIDAD" };
                    Segundos.Add(IngSegundoGEM2);

                    var IngSegundoGEM3 = new Segundo() { Id = 3, SMateria = "GESTIÓN EDUCATIVA II" };
                    Segundos.Add(IngSegundoGEM3);

                    var IngSegundoGEM4 = new Segundo() { Id = 4, SMateria = "CALIDAD EN LA EDUCACIÓN" };
                    Segundos.Add(IngSegundoGEM4);

                    var IngSegundoGEM5 = new Segundo() { Id = 5, SMateria = "INGLÉS VII" };
                    Segundos.Add(IngSegundoGEM5);

                    var IngSegundoGEM6 = new Segundo() { Id = 6, SMateria = "PLANEACIÓN Y ORGANIZACIÓN DEL TRABAJO" };
                    Segundos.Add(IngSegundoGEM6);

                    SegundaLista.Text = "Octavo Cuatrimestre";

                    ListSegundo.ItemsSource = Segundos;

                    #endregion

                    #region Noveno Cuatrimestre

                    Terceros = new List<Tercero>();

                    var IngTercerosGEM1 = new Tercero() { Id = 1, TMateria = "INVESTIGACIÓN EDUCATIVA" };
                    Terceros.Add(IngTercerosGEM1);

                    var IngTercerosGEM2 = new Tercero() { Id = 2, TMateria = "ADMINISTRACIÓN EDUCATIVA" };
                    Terceros.Add(IngTercerosGEM2);

                    var IngTercerosGEM3 = new Tercero() { Id = 3, TMateria = "TEORÍA CURRICULAR" };
                    Terceros.Add(IngTercerosGEM3);

                    var IngTercerosGEM4 = new Tercero() { Id = 4, TMateria = "PSICOPEDAGOGÍA" };
                    Terceros.Add(IngTercerosGEM4);

                    var IngTercerosGEM5 = new Tercero() { Id = 5, TMateria = "INGLES VIII" };
                    Terceros.Add(IngTercerosGEM5);

                    var IngTercerosGEM6 = new Tercero() { Id = 6, TMateria = "DIRECCIÓN DE EQUIPOS DE ALTO RENDIMIENTO" };
                    Terceros.Add(IngTercerosGEM6);

                    TerceraLista.Text = "Noveno Cuatrimestre";

                    ListTercero.ItemsSource = Terceros;

                    #endregion

                    #region Decimo Cuatrimestre

                    Cuartos = new List<Cuarto>();

                    var IngCuartoGEM1 = new Cuarto() { Id = 1, CMateria = "EVALUACIÓN  EDUCATIVA" };
                    Cuartos.Add(IngCuartoGEM1);

                    var IngCuartoGEM2 = new Cuarto() { Id = 2, CMateria = "ADMINISTRACIÓN ESCOLAR" };
                    Cuartos.Add(IngCuartoGEM2);

                    var IngCuartoGEM3 = new Cuarto() { Id = 3, CMateria = "DISEÑO CURRICULAR" };
                    Cuartos.Add(IngCuartoGEM3);

                    var IngCuartoGEM4 = new Cuarto() { Id = 4, CMateria = "COMUNICACIÓN Y TECNOLOGÍA EDUCATIVA" };
                    Cuartos.Add(IngCuartoGEM4);

                    var IngCuartoGEM5 = new Cuarto() { Id = 5, CMateria = "INTEGRADORA" };
                    Cuartos.Add(IngCuartoGEM5);

                    var IngCuartoGEM6 = new Cuarto() { Id = 6, CMateria = "INGLES IX" };
                    Cuartos.Add(IngCuartoGEM6);

                    var IngCuartoGEM7 = new Cuarto() { Id = 7, CMateria = "NEGOCIACIÓN EMPRESARIAL" };
                    Cuartos.Add(IngCuartoGEM7);

                    CuartaLista.Text = "Decimo Cuatrimestre";

                    ListCuarto.ItemsSource = Cuartos;

                    #endregion

                    #region Onceavo Cuatrimestre

                    Quintos = new List<Quinto>();

                    var IngQuintoGEM1 = new Quinto() { Id = 1, QMateria = "ESTADIA" };
                    Quintos.Add(IngQuintoGEM1);

                    QuintaLista.Text = "Onceavo Cuatrimestre";

                    ListQuinto.ItemsSource = Quintos;

                    #endregion

                    break;

                #endregion

                #region Case 7

                //Nanotecnologia

                case 7:

                    #region Septimo Cuatrimestre

                    primeros = new List<Primero>();

                    var IngPrimeroNTM1 = new Primero() { Id = 1, PMateria = "MATEMÁTICAS PARA INGENIERÍA I" };
                    primeros.Add(IngPrimeroNTM1);

                    var IngPrimeroNTM2 = new Primero() { Id = 2, PMateria = "CARACTERIZACIÓN DE NANOESTRUCTURAS" };
                    primeros.Add(IngPrimeroNTM2);

                    var IngPrimeroNTM3 = new Primero() { Id = 3, PMateria = "DIBUJO E INSTALACIONES INDUSTRIALES" };
                    primeros.Add(IngPrimeroNTM3);

                    var IngPrimeroNTM4 = new Primero() { Id = 4, PMateria = "INGLÉS VI" };
                    primeros.Add(IngPrimeroNTM4);

                    var IngPrimeroNTM5 = new Primero() { Id = 5, PMateria = "ADMINISTRACIÓN DEL TIEMPO" };
                    primeros.Add(IngPrimeroNTM5);

                    var IngPrimeroNTM6 = new Primero() { Id = 6, PMateria = "FÍSICA PARA INGENIERÍA" };
                    primeros.Add(IngPrimeroNTM6);

                    PrimeraLista.Text = "Septima Cuatrimestre";

                    ListPrimero.ItemsSource = primeros;

                    #endregion

                    #region Octavo Cuatrimestre

                    Segundos = new List<Segundo>();

                    var IngSegundoNTM1 = new Segundo() { Id = 1, SMateria = "MATEMÁTICAS PARA INGENIERÍA II" };
                    Segundos.Add(IngSegundoNTM1);

                    var IngSegundoNTM2 = new Segundo() { Id = 2, SMateria = "FÍSICA CUÁNTICA" };
                    Segundos.Add(IngSegundoNTM2);

                    var IngSegundoNTM3 = new Segundo() { Id = 3, SMateria = "OPERACIONES UNITARIAS" };
                    Segundos.Add(IngSegundoNTM3);

                    var IngSegundoNTM4 = new Segundo() { Id = 4, SMateria = "MATERIALES COMPUESTOS" };
                    Segundos.Add(IngSegundoNTM4);

                    var IngSegundoNTM5 = new Segundo() { Id = 5, SMateria = "INGLÉS VII" };
                    Segundos.Add(IngSegundoNTM5);

                    var IngSegundoNTM6 = new Segundo() { Id = 6, SMateria = "PLANEACIÓN Y ORGANIZACIÓN DEL TRABAJO" };
                    Segundos.Add(IngSegundoNTM6);

                    TerceraLista.Text = "Octavo Cuatrimestre";

                    ListSegundo.ItemsSource = Segundos;

                    #endregion

                    #region Noveno Cuatrimestre

                    Terceros = new List<Tercero>();

                    var IngTercerosNTM1 = new Tercero() { Id = 1, TMateria = "ESCALAMIENTO DE LA PRODUCCIÓN" };
                    Terceros.Add(IngTercerosNTM1);

                    var IngTercerosNTM2 = new Tercero() { Id = 2, TMateria = "PROCESOS UNITARIOS" };
                    Terceros.Add(IngTercerosNTM2);

                    var IngTercerosNTM3 = new Tercero() { Id = 3, TMateria = "INGENIERÍA ECONÓMICA" };
                    Terceros.Add(IngTercerosNTM3);

                    var IngTercerosNTM4 = new Tercero() { Id = 4, TMateria = "MATERIALES METÁLICOS" };
                    Terceros.Add(IngTercerosNTM4);

                    var IngTercerosNTM5 = new Tercero() { Id = 5, TMateria = "INGLÉS VIII" };
                    Terceros.Add(IngTercerosNTM5);

                    var IngTercerosNTM6 = new Tercero() { Id = 6, TMateria = "DIRECCIÓN DE EQUIPOS DE ALTO RENDIMIENTO" };
                    Terceros.Add(IngTercerosNTM6);

                    TerceraLista.Text = "Noveno Cuatrimestre";

                    ListTercero.ItemsSource = Terceros;

                    #endregion

                    #region Decimo Cuatrimestre

                    Cuartos = new List<Cuarto>();

                    var IngCuartoNTM1 = new Cuarto() { Id = 1, CMateria = "METODOLOGÍA DE LA INVESTIGACIÓN" };
                    Cuartos.Add(IngCuartoNTM1);

                    var IngCuartoNTM2 = new Cuarto() { Id = 2, CMateria = "INGENIERÍA INDUSTRIAL" };
                    Cuartos.Add(IngCuartoNTM2);

                    var IngCuartoNTM3 = new Cuarto() { Id = 3, CMateria = "ADMINISTRACIÓN DE PROYECTOS" };
                    Cuartos.Add(IngCuartoNTM3);

                    var IngCuartoNTM4 = new Cuarto() { Id = 4, CMateria = "SEGURIDAD Y MEDIO AMBIENTE" };
                    Cuartos.Add(IngCuartoNTM4);

                    var IngCuartoNTM5 = new Cuarto() { Id = 5, CMateria = "INTEGRADORA" };
                    Cuartos.Add(IngCuartoNTM5);

                    var IngCuartoNTM6 = new Cuarto() { Id = 6, CMateria = "INGLES IX" };
                    Cuartos.Add(IngCuartoNTM6);

                    var IngCuartoNTM7 = new Cuarto() { Id = 7, CMateria = "NEGOCIACIÓN EMPRESARIAL" };
                    Cuartos.Add(IngCuartoNTM7);

                    CuartaLista.Text = "Decimo Cuatrimestre";

                    ListCuarto.ItemsSource = Cuartos;

                    #endregion

                    #region Onceavo Cuatrimestre

                    Quintos = new List<Quinto>();

                    var IngQuintoNTM1 = new Quinto() { Id = 1, QMateria = "ESTADIA" };
                    Quintos.Add(IngQuintoNTM1);

                    QuintaLista.Text = "Onceavo Cuatrimestre";

                    ListQuinto.ItemsSource = Quintos;

                    #endregion

                    break;

                    #endregion

            }

        }
    }
}