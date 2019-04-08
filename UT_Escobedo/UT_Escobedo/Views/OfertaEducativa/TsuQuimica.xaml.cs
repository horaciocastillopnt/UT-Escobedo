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
    public partial class TsuQuimica 
    {

        public List<Primero> primeros { get; set; }
        public List<Segundo> Segundos { get; set; }
        public List<Tercero> Terceros { get; set; }
        public List<Cuarto> Cuartos { get; set; }
        public List<Quinto> Quintos { get; set; }
        public List<Sexto> Sextos { get; set; }


        public TsuQuimica()
        {

            InitializeComponent();

            int IdTsu = OfertaEducativaPage.Id;

            switch (IdTsu)
            {

                #region case 1

                case 1:

                    //Materias de Quimica Ambiental

                    #region Materias Primer Cuatrimestre

                    primeros = new List<Primero>();

                    var materia1 = new Primero() { Id = 1, PMateria = "ALGREBRA LINEAL" };
                    primeros.Add(materia1);

                    var materia2 = new Primero() { Id = 2, PMateria = "PROBABILIDAD Y ESTADÍSTICA" };
                    primeros.Add(materia2);

                    var materia3 = new Primero() { Id = 3, PMateria = "QUÍMICA BÁSICA" };
                    primeros.Add(materia3);

                    var materia4 = new Primero() { Id = 4, PMateria = "FÍSICA" };
                    primeros.Add(materia4);

                    var materia5 = new Primero() { Id = 5, PMateria = "EXPRESIÓN ORAL Y ESCRITA I " };
                    primeros.Add(materia5);

                    var materia6 = new Primero() { Id = 6, PMateria = "FORMACIÓN SOCIOCULTURA I" };
                    primeros.Add(materia6);

                    var materia7 = new Primero() { Id = 7, PMateria = "INGLÉS I" };
                    primeros.Add(materia7);

                    var materia8 = new Primero() { Id = 8, PMateria = "ADMINISTRACIÓN DE LABORATORIOS" };
                    primeros.Add(materia8);

                    ListPrimero.ItemsSource = primeros;

                    #endregion

                    #region Materias Segundo Cuatrimestre

                    Segundos = new List<Segundo>();

                    var Smateria1 = new Segundo() { Id = 1, SMateria = "FUNCONES MATEMÁTICAS" };
                    Segundos.Add(Smateria1);

                    var Smateria2 = new Segundo() { Id = 2, SMateria = "INFORMÁTICA I" };
                    Segundos.Add(Smateria2);

                    var Smateria3 = new Segundo() { Id = 3, SMateria = "TERMODINÁMICA" };
                    Segundos.Add(Smateria3);

                    var Smateria4 = new Segundo() { Id = 4, SMateria = "QUÍMICA ORGÁNICA" };
                    Segundos.Add(Smateria4);

                    var Smateria5 = new Segundo() { Id = 5, SMateria = "METODOLOGIA DE LA INVESTIGACIÓN" };
                    Segundos.Add(Smateria5);

                    var Smateria6 = new Segundo() { Id = 6, SMateria = "FORMACIÓN SOCIOCULTURAL II" };
                    Segundos.Add(Smateria6);

                    var Smateria7 = new Segundo() { Id = 7, SMateria = "INGLÉS II" };
                    Segundos.Add(Smateria7);

                    var Smateria8 = new Segundo() { Id = 8, SMateria = "QUIMICA INORGANICA" };
                    Segundos.Add(Smateria8);

                    ListSegundo.ItemsSource = Segundos;

                    #endregion

                    #region Materias Tercer Cuatrimestre

                    Terceros = new List<Tercero>();

                    var Tmateria1 = new Tercero() { Id = 1, TMateria = "CÁLCULO DIFERENCIAL" };
                    Terceros.Add(Tmateria1);

                    var Tmateria2 = new Tercero() { Id = 2, TMateria = "QUÍMICA ANALÍTICA" };
                    Terceros.Add(Tmateria2);

                    var Tmateria3 = new Tercero() { Id = 3, TMateria = "ELECTRICIDAD Y MAGNETISMO" };
                    Terceros.Add(Tmateria3);

                    var Tmateria4 = new Tercero() { Id = 4, TMateria = "INTEGRADORA I" };
                    Terceros.Add(Tmateria4);

                    var Tmateria5 = new Tercero() { Id = 5, TMateria = "CONTAMINACIÓN DEL SUELO" };
                    Terceros.Add(Tmateria5);

                    var Tmateria6 = new Tercero() { Id = 6, TMateria = "ADMINISTRACIÓN DE PROYECTOS" };
                    Terceros.Add(Tmateria6);

                    var Tmateria7 = new Tercero() { Id = 7, TMateria = "MICROBIOLOGIA AMBIENTAL" };
                    Terceros.Add(Tmateria7);

                    var Tmateria8 = new Tercero() { Id = 8, TMateria = "INGLÉS III" };
                    Terceros.Add(Tmateria8);

                    ListTercero.ItemsSource = Terceros;

                    #endregion

                    #region Materias Cuarto Cuatrimestre

                    Cuartos = new List<Cuarto>();

                    var Cmateria1 = new Cuarto() { Id = 1, CMateria = "CÁLCULO INTEGRAL" };
                    Cuartos.Add(Cmateria1);

                    var Cmateria2 = new Cuarto() { Id = 2, CMateria = "ANÁLISIS DE SISTEMAS AMBIENTALES" };
                    Cuartos.Add(Cmateria2);

                    var Cmateria3 = new Cuarto() { Id = 3, CMateria = "SEGURIDAD LABORAL I" };
                    Cuartos.Add(Cmateria3);

                    var Cmateria4 = new Cuarto() { Id = 4, CMateria = "MANEJO INTEGRAL DE RESIDUOS I" };
                    Cuartos.Add(Cmateria4);

                    var Cmateria5 = new Cuarto() { Id = 5, CMateria = "OPERACIONES UNITARIA I" };
                    Cuartos.Add(Cmateria5);

                    var Cmateria6 = new Cuarto() { Id = 6, CMateria = "TRATAMIENTO DE AGUA I" };
                    Cuartos.Add(Cmateria6);

                    var Cmateria7 = new Cuarto() { Id = 7, CMateria = "EXPRESIÓN ORAL Y ESCRITA II" };
                    Cuartos.Add(Cmateria7);

                    var Cmateria8 = new Cuarto() { Id = 8, CMateria = "FORMACION SOCIOCULTURAL III" };
                    Cuartos.Add(Cmateria8);

                    var Cmateria9 = new Cuarto() { Id = 9, CMateria = "INGLÉS IV" };
                    Cuartos.Add(Cmateria9);

                    ListCuarto.ItemsSource = Cuartos;

                    #endregion

                    #region Materia Quinto Cuatrimestre

                    Quintos = new List<Quinto>();

                    var Qmateria1 = new Quinto() { Id = 1, QMateria = "CONTAMINACIÓN DEL AIRE POR FUENTES FIJAS" };
                    Quintos.Add(Qmateria1);

                    var Qmateria2 = new Quinto() { Id = 2, QMateria = "SEGURIDAD LABORAL II" };
                    Quintos.Add(Qmateria2);

                    var Qmateria3 = new Quinto() { Id = 3, QMateria = "OPERACIONES UNITARIA II" };
                    Quintos.Add(Qmateria3);

                    var Qmateria4 = new Quinto() { Id = 4, QMateria = "MANEJO INTEGRAL DE RESIDUOS II" };
                    Quintos.Add(Qmateria4);

                    var Qmateria5 = new Quinto() { Id = 5, QMateria = "TRATAMIENTO DE AGUA II" };
                    Quintos.Add(Qmateria5);

                    var Qmateria6 = new Quinto() { Id = 6, QMateria = "SISTEMAS DE GESTION AMBIENTAL Y DE CALIDAD" };
                    Quintos.Add(Qmateria6);

                    var Qmateria7 = new Quinto() { Id = 7, QMateria = "INTEGRADORA II" };
                    Quintos.Add(Qmateria7);

                    var Qmateria8 = new Quinto() { Id = 8, QMateria = "INGLÉS V" };
                    Quintos.Add(Qmateria8);

                    ListQuinto.ItemsSource = Quintos;

                    #endregion

                    #region Materia Sexto Cuatrimestre

                    Sextos = new List<Sexto>();

                    var Sxmateria = new Sexto() { Id = 1, SxMateria = "ESTADÍA" };
                    Sextos.Add(Sxmateria);

                    ListSexto.ItemsSource = Sextos;

                    #endregion

                    break;

                #endregion

                #region Case 2

                case 2:

                    //Materias de LENGUA INGLESA

                    #region Materias Primer Cuatrimestre

                    primeros = new List<Primero>();

                    var lLenguaPmateria1 = new Primero() { Id = 1, PMateria = "MATEMÁTICAS" };
                    primeros.Add(lLenguaPmateria1);

                    var lLenguaPmateria2 = new Primero() { Id = 2, PMateria = "FUNDAMENTOS PEDAGÓGICOS DE LA EDUCACIÓN" };
                    primeros.Add(lLenguaPmateria2);

                    var lLenguaPmateria3 = new Primero() { Id = 3, PMateria = "INFOMÁTICA" };
                    primeros.Add(lLenguaPmateria3);

                    var LenguaPmateria4 = new Primero() { Id = 4, PMateria = "DESARROLLO HUMANO" };
                    primeros.Add(LenguaPmateria4);

                    var LenguaPmateria5 = new Primero() { Id = 5, PMateria = "INGLÉS I" };
                    primeros.Add(LenguaPmateria5);

                    var LenguaPmateria6 = new Primero() { Id = 6, PMateria = "EXPRESIÓN ORAL Y ESCRITA" };
                    primeros.Add(LenguaPmateria6);

                    var LenguaPmateria7 = new Primero() { Id = 7, PMateria = "FORMACIÓN SOCIOCULTURAL" };
                    primeros.Add(LenguaPmateria7);

                    ListPrimero.ItemsSource = primeros;

                    #endregion

                    #region Materias Segundo Cuatrimestre

                    Segundos = new List<Segundo>();

                    var SegundoLenguaMateria1 = new Segundo() { Id = 1, SMateria = "ESTADÍSTICA APLICADA A LA EDUCACIÓN" };
                    Segundos.Add(SegundoLenguaMateria1);

                    var SegundoLenguaMateria2 = new Segundo() { Id = 2, SMateria = "METODOLOGÍA DE LA INVESTIGACIÓN" };
                    Segundos.Add(SegundoLenguaMateria2);

                    var SegundoLenguaMateria3 = new Segundo() { Id = 3, SMateria = "DISEÑO DE MATERIAL DIDÁCTICO I" };
                    Segundos.Add(SegundoLenguaMateria3);

                    var SegundoLenguaMateria4 = new Segundo() { Id = 4, SMateria = "METODOLOGÍA DE LA DIDÁCTICA" };
                    Segundos.Add(SegundoLenguaMateria4);

                    var SegundoLenguaMateria5 = new Segundo() { Id = 5, SMateria = "INGLÉS II" };
                    Segundos.Add(SegundoLenguaMateria5);

                    var SegundoLenguaMateria6 = new Segundo() { Id = 7, SMateria = "FORMACIÓN SOCIOCULTURA II" };
                    Segundos.Add(SegundoLenguaMateria6);

                    ListSegundo.ItemsSource = Segundos;

                    #endregion

                    #region Materia Tercer Cuatrimestre

                    Terceros = new List<Tercero>();

                    var TerceroLenguaMateria1 = new Tercero() { Id = 1, TMateria = "LA EDUCACIÍN EN MÉXICO" };
                    Terceros.Add(TerceroLenguaMateria1);

                    var TerceroLenguaMateria2 = new Tercero() { Id = 2, TMateria = "DISEÑO DE MATERIAL DIDÁCTICO II" };
                    Terceros.Add(TerceroLenguaMateria2);

                    var TerceroLenguaMateria3 = new Tercero() { Id = 3, TMateria = "METODOLOGÍA  DE LA DIDÁCTICA II" };
                    Terceros.Add(TerceroLenguaMateria3);

                    var TerceroLenguaMateria4 = new Tercero() { Id = 4, TMateria = "PLANEACIÓN DOCENTE" };
                    Terceros.Add(TerceroLenguaMateria4);

                    var TerceroLenguaMateria5 = new Tercero() { Id = 5, TMateria = "EVALUACIÓN DEL PROCESO ENSEÑANZA Y APRENDIZAJE" };
                    Terceros.Add(TerceroLenguaMateria5);

                    var TerceroLenguaMateria6 = new Tercero() { Id = 6, TMateria = "INGLÉS III" };
                    Terceros.Add(TerceroLenguaMateria6);

                    var TerceroLenguaMateria7 = new Tercero() { Id = 7, TMateria = "FORMACIÓN SOCIOCULTURAL III" };
                    Terceros.Add(TerceroLenguaMateria7);

                    ListTercero.ItemsSource = Terceros;

                    #endregion

                    #region Materia Cuarto Cuatrimestre

                    Cuartos = new List<Cuarto>();

                    var CuartoLenguaMateria1 = new Cuarto() { Id = 1, CMateria = "ESTATEGIAS DE ENSEÑANZA EN LA LENGUA INGLESA I" };
                    Cuartos.Add(CuartoLenguaMateria1);

                    var CuartoLenguaMateria2 = new Cuarto() { Id = 2, CMateria = "DISEÑO DE SITUACIONES DE APRENDIZAJE" };
                    Cuartos.Add(CuartoLenguaMateria2);

                    var CuartoLenguaMateria3 = new Cuarto() { Id = 3, CMateria = "INSTRUMENTOS DE EVALUACIÓN" };
                    Cuartos.Add(CuartoLenguaMateria2);

                    var CuartoLenguaMateria4 = new Cuarto() { Id = 4, CMateria = "FONÉTICA" };
                    Cuartos.Add(CuartoLenguaMateria4);

                    var CuartoLenguaMateria5 = new Cuarto() { Id = 5, CMateria = "INGLÉS IV" };
                    Cuartos.Add(CuartoLenguaMateria5);

                    var CuartoLenguaMateria6 = new Cuarto() { Id = 6, CMateria = "INTEGRADORA I" };
                    Cuartos.Add(CuartoLenguaMateria6);

                    var CuartoLenguaMateria7 = new Cuarto() { Id = 7, CMateria = "FORMACIÓN SOCIOCULTURAL IV" };
                    Cuartos.Add(CuartoLenguaMateria7);

                    ListCuarto.ItemsSource = Cuartos;

                    #endregion

                    #region Quinto Cuatrimestre

                    Quintos = new List<Quinto>();

                    var QuintoLenguaMateria1 = new Quinto() { Id = 1, QMateria = "ESTRATEGIAS DE ENSEÑANZA  EN LA LENGUA INGLESA II" };
                    Quintos.Add(QuintoLenguaMateria1);

                    var QuintoLenguaMateria2 = new Quinto() { Id = 2, QMateria = "ESTRUCTURA GRAMATICAL" };
                    Quintos.Add(QuintoLenguaMateria2);

                    var QuintoLenguaMateria3 = new Quinto() { Id = 3, QMateria = "ENSEÑANZA DE HABILIDADES PRODUCTIVAS" };
                    Quintos.Add(QuintoLenguaMateria3);

                    var QuintoLenguaMateria4 = new Quinto() { Id = 4, QMateria = "INTEGRADORA II" };
                    Quintos.Add(QuintoLenguaMateria4);

                    var QuintoLenguaMateria5 = new Quinto() { Id = 5, QMateria = "INGLÉS V" };
                    Quintos.Add(QuintoLenguaMateria5);

                    var QuintoLenguaMateria6 = new Quinto() { Id = 6, QMateria = "EXPRESION ORAL Y ESCRITA II" };
                    Quintos.Add(QuintoLenguaMateria6);

                    ListQuinto.ItemsSource = Quintos;

                    #endregion

                    #region Sexto Cuatrimestre

                    Sextos = new List<Sexto>();

                    var SextoLenguaMateria1 = new Sexto() { Id = 1, SxMateria = "ESTADIA" };
                    Sextos.Add(SextoLenguaMateria1);

                    ListSexto.ItemsSource = Sextos;

                    #endregion

                    break;

                #endregion

                #region Case 3

                case 3:
                    // Carrreras de mantenimiento

                    #region Materias MTO 1C

                    primeros = new List<Primero>();

                    var primeroMTOM1 = new Primero() { Id = 1, PMateria = "ALGEBRA LINEAL" };
                    primeros.Add(primeroMTOM1);

                    var primeroMTOM2 = new Primero() { Id = 2, PMateria = "QUIMICA BASICA" };
                    primeros.Add(primeroMTOM2);

                    var primeroMTOM3 = new Primero() { Id = 3, PMateria = "INTRODUCCION AL MANTENIMIENTO" };
                    primeros.Add(primeroMTOM3);

                    var primeroMTOM4 = new Primero() { Id = 4, PMateria = "SEGURIDAD Y MEDIO AMBIENTE" };
                    primeros.Add(primeroMTOM4);

                    var primeroMTOM5 = new Primero() { Id = 5, PMateria = "TECNOLOGIAS PARA LA DIGITALIZACION" };
                    primeros.Add(primeroMTOM5);

                    var primeroMTOM6 = new Primero() { Id = 6, PMateria = "ADMINISTRACION DEL PERSONAL" };
                    primeros.Add(primeroMTOM6);

                    var primeroMTOM7 = new Primero() { Id = 7, PMateria = "INGLES I" };
                    primeros.Add(primeroMTOM7);

                    var primeroMTOM8 = new Primero() { Id = 8, PMateria = "EXPRESION ORAL Y ESCRITA I" };
                    primeros.Add(primeroMTOM8);

                    var primeroMTOM9 = new Primero() { Id = 9, PMateria = "FORMACION SOCIOCULTURAL I" };
                    primeros.Add(primeroMTOM9);

                    ListPrimero.ItemsSource = primeros;

                    #endregion

                    #region Materias MTO 2C

                    Segundos = new List<Segundo>();

                    var SegundoMTOM1 = new Segundo() { Id = 1, SMateria = "FUNCIONES MATEMATICAS" };
                    Segundos.Add(SegundoMTOM1);

                    var SegundoMTOM2 = new Segundo() { Id = 2, SMateria = "FISICA" };
                    Segundos.Add(SegundoMTOM2);

                    var SegundoMTOM3 = new Segundo() { Id = 3, SMateria = "ELECTRICIDAD Y MAGNETISMO" };
                    Segundos.Add(SegundoMTOM3);

                    var SegundoMTOM4 = new Segundo() { Id = 4, SMateria = "GESTION DEL MANTENIMIENTO" };
                    Segundos.Add(SegundoMTOM4);

                    var SegundoMTOM5 = new Segundo() { Id = 5, SMateria = "CALIDAD DEL MANTENIMIENTO" };
                    Segundos.Add(SegundoMTOM5);

                    var SegundoMTOM6 = new Segundo() { Id = 6, SMateria = "DIBUJO INDUSTRIAL" };
                    Segundos.Add(SegundoMTOM6);

                    var SegundoMTOM7 = new Segundo() { Id = 7, SMateria = "METODOS Y SISTEMAS DE TRABAJO" };
                    Segundos.Add(SegundoMTOM7);

                    var SegundoMTOM8 = new Segundo() { Id = 8, SMateria = "COSTOS Y PRESUPUESTOS" };
                    Segundos.Add(SegundoMTOM8);

                    var SegundoMTOM9 = new Segundo() { Id = 9, SMateria = "INGLES II" };
                    Segundos.Add(SegundoMTOM9);

                    ListSegundo.ItemsSource = Segundos;

                    #endregion

                    #region Materias MTO 3C

                    Terceros = new List<Tercero>();

                    var TerceroMTOM1 = new Tercero() { Id = 1, TMateria = "CALCULDO DIFERENCIAL" };
                    Terceros.Add(TerceroMTOM1);

                    var TerceroMTOM2 = new Tercero() { Id = 2, TMateria = "PROBABILIDAD Y ESTADISTICA" };
                    Terceros.Add(TerceroMTOM2);

                    var TerceroMTOM3 = new Tercero() { Id = 3, TMateria = "TERMODINAMICA" };
                    Terceros.Add(TerceroMTOM3);

                    var TerceroMTOM4 = new Tercero() { Id = 4, TMateria = "SISTEMAS ELECTRICOS" };
                    Terceros.Add(TerceroMTOM4);

                    var TerceroMTOM5 = new Tercero() { Id = 5, TMateria = "MAQUINAS Y MECANISMOS" };
                    Terceros.Add(TerceroMTOM5);

                    var TerceroMTOM6 = new Tercero() { Id = 6, TMateria = "ELECTRONICA ANALOGICA" };
                    Terceros.Add(TerceroMTOM6);

                    var TerceroMTOM7 = new Tercero() { Id = 7, TMateria = "INTEGRADORA I" };
                    Terceros.Add(TerceroMTOM7);

                    var TerceroMTOM8 = new Tercero() { Id = 8, TMateria = "INGLES III" };
                    Terceros.Add(TerceroMTOM8);

                    var TerceroMTOM9 = new Tercero() { Id = 9, TMateria = "FORMACION SOCIOCULTURAL II" };
                    Terceros.Add(TerceroMTOM9);

                    ListTercero.ItemsSource = Terceros;

                    #endregion

                    #region Materias MTO 4C

                    Cuartos = new List<Cuarto>();

                    var CuartoMTOM1 = new Cuarto() { Id = 1, CMateria = "CALCULO INTEGRAL" };
                    Cuartos.Add(CuartoMTOM1);

                    var CuartoMTOM2 = new Cuarto() { Id = 2, CMateria = "ESTRUCTURA Y PROPIEDADES DE LOS MATERIALES" };
                    Cuartos.Add(CuartoMTOM2);

                    var CuartoMTOM3 = new Cuarto() { Id = 3, CMateria = "MAQUINAS ELECTRICAS" };
                    Cuartos.Add(CuartoMTOM3);

                    var CuartoMTOM4 = new Cuarto() { Id = 4, CMateria = "REDES DE SERVICIOS INDUSTRIALES" };
                    Cuartos.Add(CuartoMTOM4);

                    var CuartoMTOM5 = new Cuarto() { Id = 5, CMateria = "ELECTRONICA DIGITAL" };
                    Cuartos.Add(CuartoMTOM5);

                    var CuartoMTOM6 = new Cuarto() { Id = 6, CMateria = "PRINCIPIOS DE PROGRAMACION" };
                    Cuartos.Add(CuartoMTOM6);

                    var CuartoMTOM7 = new Cuarto() { Id = 7, CMateria = "SISTEMAS NEUMATICOS E HIDRAULICOS" };
                    Cuartos.Add(CuartoMTOM7);

                    var CuartoMTOM8 = new Cuarto() { Id = 8, CMateria = "INGLES IV" };
                    Cuartos.Add(CuartoMTOM8);

                    var CuartoMTOM9 = new Cuarto() { Id = 9, CMateria = "FORMACION SOCIOCULTURAL III" };
                    Cuartos.Add(CuartoMTOM9);

                    ListCuarto.ItemsSource = Cuartos;

                    #endregion

                    #region Materias MTO 5C

                    Quintos = new List<Quinto>();

                    var QuintoMTOM1 = new Quinto() { Id = 1, QMateria = "INSTALACIONES ELECTRICAS" };
                    Quintos.Add(QuintoMTOM1);

                    var QuintoMTOM2 = new Quinto() { Id = 2, QMateria = "MAQUINAS TERMICAS" };
                    Quintos.Add(QuintoMTOM2);

                    var QuintoMTOM3 = new Quinto() { Id = 3, QMateria = "MANTENIMIENTO A PROCEDIMIENTOS DE MANUFACTURA" };
                    Quintos.Add(QuintoMTOM3);

                    var QuintoMTOM4 = new Quinto() { Id = 4, QMateria = "AUTOMATIZACION  Y ROBOTICA" };
                    Quintos.Add(QuintoMTOM4);

                    var QuintoMTOM5 = new Quinto() { Id = 5, QMateria = "INGENIERIA DE MATERIALES" };
                    Quintos.Add(QuintoMTOM5);

                    var QuintoMTOM6 = new Quinto() { Id = 6, QMateria = "INTEGRADORA II" };
                    Quintos.Add(QuintoMTOM6);

                    var QuintoMTOM7 = new Quinto() { Id = 7, QMateria = "INGLES V" };
                    Quintos.Add(QuintoMTOM7);

                    var QuintoMTOM8 = new Quinto() { Id = 8, QMateria = "EXPRESION ORAL Y ESCRITA II" };
                    Quintos.Add(QuintoMTOM8);

                    var QuintoMTOM9 = new Quinto() { Id = 9, QMateria = "FORMACION SOCIOCULTURAL IV" };
                    Quintos.Add(QuintoMTOM9);

                    ListQuinto.ItemsSource = Quintos;

                    #endregion

                    #region Materias MTO 6C

                    Sextos = new List<Sexto>();

                    var SextoMTOM1 = new Sexto() { Id = 1, SxMateria = "ESTADIA" };
                    Sextos.Add(SextoMTOM1);

                    ListSexto.ItemsSource = Sextos;

                    #endregion

                    break;

                #endregion

                #region Case 4

                case 4:

                    //Carrear de mecatronica

                    #region Materias MECA 1C

                    primeros = new List<Primero>();

                    var primeroMECAM1 = new Primero() { Id = 1, PMateria = "ALGEBRA LINEAL" };
                    primeros.Add(primeroMECAM1);

                    var primeroMECAM2 = new Primero() { Id = 2, PMateria = "FISICA" };
                    primeros.Add(primeroMECAM2);

                    var primeroMECAM3 = new Primero() { Id = 3, PMateria = "ELECTRICIDAD Y MAGENTISMO" };
                    primeros.Add(primeroMECAM3);

                    var primeroMECAM4 = new Primero() { Id = 4, PMateria = "HERRAMIENTAS INFORMATICAS 4.0" };
                    primeros.Add(primeroMECAM4);

                    var primeroMECAM5 = new Primero() { Id = 5, PMateria = "PROCESOS PRODUCTIVOS" };
                    primeros.Add(primeroMECAM5);

                    var primeroMECAM6 = new Primero() { Id = 6, PMateria = "ELEMENTOS DIMENSIONALES" };
                    primeros.Add(primeroMECAM6);

                    var primeroMECAM7 = new Primero() { Id = 7, PMateria = "INGLES I" };
                    primeros.Add(primeroMECAM7);

                    var primeroMECAM8 = new Primero() { Id = 8, PMateria = "EXPRESION ORAL Y ESCRITA I" };
                    primeros.Add(primeroMECAM8);

                    var primeroMECAM9 = new Primero() { Id = 9, PMateria = "FORMACION SOCIOCULTURAL" };
                    primeros.Add(primeroMECAM9);

                    ListPrimero.ItemsSource = primeros;

                    #endregion

                    #region Materias MECA 2C

                    Segundos = new List<Segundo>();

                    var SegundoMECAM1 = new Segundo() { Id = 1, SMateria = "FUNCIONES MATEMATICAS" };
                    Segundos.Add(SegundoMECAM1);

                    var SegundoMECAM2 = new Segundo() { Id = 2, SMateria = "QUIMICA BASICA" };
                    Segundos.Add(SegundoMECAM2);

                    var SegundoMECAM3 = new Segundo() { Id = 3, SMateria = "CIRCUITOS ELECTRICOS" };
                    Segundos.Add(SegundoMECAM3);

                    var SegundoMECAM4 = new Segundo() { Id = 4, SMateria = "SISTEMAS HIDRAULICOS Y NEUMATICOS" };
                    Segundos.Add(SegundoMECAM4);

                    var SegundoMECAM5 = new Segundo() { Id = 5, SMateria = "ELECTRONICA ANALOGICA" };
                    Segundos.Add(SegundoMECAM5);

                    var SegundoMECAM6 = new Segundo() { Id = 6, SMateria = "CONTROL DE MOTORES I" };
                    Segundos.Add(SegundoMECAM6);

                    var SegundoMECAM7 = new Segundo() { Id = 7, SMateria = "INGLES II" };
                    Segundos.Add(SegundoMECAM7);

                    var SegundoMECAM8 = new Segundo() { Id = 8, SMateria = "FORMACION SOCIOCULTURAL" };
                    Segundos.Add(SegundoMECAM8);

                    ListSegundo.ItemsSource = Segundos;

                    #endregion

                    #region Materias MECA 3C

                    Terceros = new List<Tercero>();

                    var TerceroMECAM1 = new Tercero() { Id = 1, TMateria = "CALCULDO DIFERENCIAL" };
                    Terceros.Add(TerceroMECAM1);

                    var TerceroMECAM2 = new Tercero() { Id = 2, TMateria = "PROBABILIDAD Y ESTADISTICAS" };
                    Terceros.Add(TerceroMECAM2);

                    var TerceroMECAM3 = new Tercero() { Id = 3, TMateria = "TERMODINAMICA" };
                    Terceros.Add(TerceroMECAM3);

                    var TerceroMECAM4 = new Tercero() { Id = 4, TMateria = "CONTROLADORES LOGICOS PROGRAMABLES" };
                    Terceros.Add(TerceroMECAM4);

                    var TerceroMECAM5 = new Tercero() { Id = 5, TMateria = "ELECTRONICA DIGITAL" };
                    Terceros.Add(TerceroMECAM5);

                    var TerceroMECAM6 = new Tercero() { Id = 6, TMateria = "SISTEMAS MECANICOS I" };
                    Terceros.Add(TerceroMECAM6);

                    var TerceroMECAM7 = new Tercero() { Id = 7, TMateria = "INTEGRADORA I" };
                    Terceros.Add(TerceroMECAM7);

                    var TerceroMECAM8 = new Tercero() { Id = 8, TMateria = "INGLES III" };
                    Terceros.Add(TerceroMECAM8);

                    var TerceroMECAM9 = new Tercero() { Id = 9, TMateria = "FORMACION SOCIOCULTURAL III" };
                    Terceros.Add(TerceroMECAM9);

                    ListTercero.ItemsSource = Terceros;

                    #endregion

                    #region Materias MECA 4C

                    Cuartos = new List<Cuarto>();

                    var CuartoMECAM1 = new Cuarto() { Id = 1, CMateria = "CALCULO INTEGRAL" };
                    Cuartos.Add(CuartoMECAM1);

                    var CuartoMECAM2 = new Cuarto() { Id = 2, CMateria = "ESTRUCTURA Y PROPIEDADES DE LOS MATERIALES" };
                    Cuartos.Add(CuartoMECAM2);

                    var CuartoMECAM3 = new Cuarto() { Id = 3, CMateria = "INSTRUMENTACION INDUSTRIAL" };
                    Cuartos.Add(CuartoMECAM3);

                    var CuartoMECAM4 = new Cuarto() { Id = 4, CMateria = "ANALISIS DE CIRCUITOS ELECTRICOS" };
                    Cuartos.Add(CuartoMECAM4);

                    var CuartoMECAM5 = new Cuarto() { Id = 5, CMateria = "DISPOSITIVOS DIGITALES" };
                    Cuartos.Add(CuartoMECAM5);

                    var CuartoMECAM6 = new Cuarto() { Id = 6, CMateria = "LENGUAJE DE PROGRAMACION" };
                    Cuartos.Add(CuartoMECAM6);

                    var CuartoMECAM7 = new Cuarto() { Id = 7, CMateria = "DISPOSITIVOS ANALÓGICOS" };
                    Cuartos.Add(CuartoMECAM7);

                    var CuartoMECAM8 = new Cuarto() { Id = 8, CMateria = "INGLÉS IV" };
                    Cuartos.Add(CuartoMECAM8);

                    var CuartoMECAM9 = new Cuarto() { Id = 9, CMateria = "FORMACIÓN SOCIOCULTURAL IV" };
                    Cuartos.Add(CuartoMECAM9);

                    ListCuarto.ItemsSource = Cuartos;

                    #endregion

                    #region  Materias MECA 5C

                    Quintos = new List<Quinto>();

                    var QuintoMECAM1 = new Quinto() { Id = 1, QMateria = "INTEGRADORA II" };
                    Quintos.Add(QuintoMECAM1);

                    var QuintoMECAM2 = new Quinto() { Id = 2, QMateria = "PROGRAMACIÓN VISUAL" };
                    Quintos.Add(QuintoMECAM2);

                    var QuintoMECAM3 = new Quinto() { Id = 3, QMateria = "INTEGRACIÓN DE SISTEMAS AUTOMÁTICOS" };
                    Quintos.Add(QuintoMECAM3);

                    var QuintoMECAM4 = new Quinto() { Id = 4, QMateria = "MICROCONTROLADORES" };
                    Quintos.Add(QuintoMECAM4);

                    var QuintoMECAM5 = new Quinto() { Id = 5, QMateria = "FUNDAMENTOS DE INSTRUMENTACIÓN VIRTUAL" };
                    Quintos.Add(QuintoMECAM5);

                    var QuintoMECAM6 = new Quinto() { Id = 6, QMateria = "SISTEMAS DE CONTROL" };
                    Quintos.Add(QuintoMECAM6);

                    var QuintoMECAM7 = new Quinto() { Id = 7, QMateria = "INGLÉS V" };
                    Quintos.Add(QuintoMECAM7);

                    var QuintoMECAM8 = new Quinto() { Id = 8, QMateria = "EXPRESIÓN ORAL Y ESCRITA II" };
                    Quintos.Add(QuintoMECAM8);

                    ListQuinto.ItemsSource = Quintos;

                    #endregion

                    #region Materias MECA 6C

                    Sextos = new List<Sexto>();

                    var SextoMECAM1 = new Sexto() { Id = 1, SxMateria = "ESTADIA" };
                    Sextos.Add(SextoMECAM1);

                    ListSexto.ItemsSource = Sextos;

                    #endregion

                    break;

                #endregion

                #region case 5

                case 5:

                    //Carrera Energias Renovables

                    #region Materias Energias Renovables 1C

                    primeros = new List<Primero>();

                    var primeroERM1 = new Primero() { Id = 1, PMateria = "PROBABILIDAD Y ESTADÍSTICA" };
                    primeros.Add(primeroERM1);

                    var primeroERM2 = new Primero() { Id = 2, PMateria = "QUÍMICA BÁSICA" };
                    primeros.Add(primeroERM2);

                    var primeroERM3 = new Primero() { Id = 3, PMateria = "ELECTRICIDAD Y MAGNETISMO" };
                    primeros.Add(primeroERM3);

                    var primeroERM4 = new Primero() { Id = 4, PMateria = "DESARROLLO SUSTENTABLE" };
                    primeros.Add(primeroERM4);

                    var primeroERM5 = new Primero() { Id = 5, PMateria = "INFORMÁTICA" };
                    primeros.Add(primeroERM5);

                    var primeroERM6 = new Primero() { Id = 6, PMateria = "CIRCUITOS ELÉCTRICOS" };
                    primeros.Add(primeroERM6);

                    var primeroERM7 = new Primero() { Id = 7, PMateria = " NGLÉS I" };
                    primeros.Add(primeroERM4);

                    var primeroERM8 = new Primero() { Id = 8, PMateria = "EXPRESIÓN ORAL Y ESCRITA I" };
                    primeros.Add(primeroERM8);

                    var primeroERM9 = new Primero() { Id = 9, PMateria = "FORMACIÓN SOCIOCULTURAL I" };
                    primeros.Add(primeroERM9);

                    ListPrimero.ItemsSource = primeros;

                    #endregion

                    #region Materias Energias Renovables 2C

                    Segundos = new List<Segundo>();

                    var SegundoERM1 = new Segundo() { Id = 1, SMateria = "ÁLGEBRA LINEAL" };
                    Segundos.Add(SegundoERM1);

                    var SegundoERM2 = new Segundo() { Id = 2, SMateria = "FÍSICA" };
                    Segundos.Add(SegundoERM2);

                    var SegundoERM3 = new Segundo() { Id = 3, SMateria = "TERMODINÁMICA" };
                    Segundos.Add(SegundoERM3);

                    var SegundoERM4 = new Segundo() { Id = 4, SMateria = "INSTALACIONES ELÉCTRICAS" };
                    Segundos.Add(SegundoERM4);

                    var SegundoERM5 = new Segundo() { Id = 5, SMateria = "MECÁNICA INDUSTRIAL" };
                    Segundos.Add(SegundoERM5);

                    var SegundoERM6 = new Segundo() { Id = 6, SMateria = "INGLÉS II" };
                    Segundos.Add(SegundoERM6);

                    var SegundoERM7 = new Segundo() { Id = 7, SMateria = "FOMACIÓN SOCIOCULTURAL II" };
                    Segundos.Add(SegundoERM7);

                    var SegundoERM8 = new Segundo() { Id = 8, SMateria = "ELECTRONICA INDUSTRIAL" };
                    Segundos.Add(SegundoERM8);

                    ListSegundo.ItemsSource = Segundos;

                    #endregion

                    #region Materias Energias Renovables 3C

                    Terceros = new List<Tercero>();

                    var TerceroEnergiaRMateria1 = new Tercero() { Id = 1, TMateria = "FUNCIONES MATEMÁTICAS" };
                    Terceros.Add(TerceroEnergiaRMateria1);

                    var TerceroEnergiaRMateria2 = new Tercero() { Id = 2, TMateria = "FISICOQUÍMICA" };
                    Terceros.Add(TerceroEnergiaRMateria2);

                    var TerceroEnergiaRMateria3 = new Tercero() { Id = 3, TMateria = "INSTRUMENTACIÓN INDUSTRIAL" };
                    Terceros.Add(TerceroEnergiaRMateria3);

                    var TerceroEnergiaRMateria4 = new Tercero() { Id = 4, TMateria = "MANTENIMIENTO ELECTROMECÁNICO" };
                    Terceros.Add(TerceroEnergiaRMateria4);

                    var TerceroEnergiaRMateria5 = new Tercero() { Id = 5, TMateria = "ENERGÍAS RENOVABLES" };
                    Terceros.Add(TerceroEnergiaRMateria5);

                    var TerceroEnergiaRMateria6 = new Tercero() { Id = 6, TMateria = "FORMULACION DE PROYECTOS" };
                    Terceros.Add(TerceroEnergiaRMateria6);

                    var TerceroEnergiaRMateria7 = new Tercero() { Id = 7, TMateria = "CALIDAD" };
                    Terceros.Add(TerceroEnergiaRMateria7);

                    var TerceroEnergiaRMateria8 = new Tercero() { Id = 8, TMateria = "INTEGRADORA I" };
                    Terceros.Add(TerceroEnergiaRMateria8);

                    var TerceroEnergiaRMateria9 = new Tercero() { Id = 9, TMateria = "INGLÉS III" };
                    Terceros.Add(TerceroEnergiaRMateria9);

                    ListTercero.ItemsSource = Terceros;

                    #endregion

                    #region Materias Energias Renovables 4C

                    Cuartos = new List<Cuarto>();

                    var CuartoEnergiaRMateria1 = new Cuarto() { Id = 1, CMateria = "CÁLCULO DIFERENCIAL" };
                    Cuartos.Add(CuartoEnergiaRMateria1);

                    var CuartoEnergiaRMateria2 = new Cuarto() { Id = 2, CMateria = "ESTRUCTURA Y PROPIEDADES DE LOS MATERIAL" };
                    Cuartos.Add(CuartoEnergiaRMateria2);

                    var CuartoEnergiaRMateria3 = new Cuarto() { Id = 3, CMateria = "FISICOQUÍMICA APLICADA" };
                    Cuartos.Add(CuartoEnergiaRMateria3);

                    var CuartoEnergiaRMateria4 = new Cuarto() { Id = 4, CMateria = "DIBUJO INDUSTRIAL" };
                    Cuartos.Add(CuartoEnergiaRMateria4);

                    var CuartoEnergiaRMateria5 = new Cuarto() { Id = 5, CMateria = "ELECTRÓNICA DE POTENCIA" };
                    Cuartos.Add(CuartoEnergiaRMateria5);

                    var CuartoEnergiaRMateria6 = new Cuarto() { Id = 6, CMateria = "ESTACIONES METEOROLOGICAS" };
                    Cuartos.Add(CuartoEnergiaRMateria6);

                    var CuartoEnergiaRMateria7 = new Cuarto() { Id = 7, CMateria = "PROCESOS INDUSTRIALES" };
                    Cuartos.Add(CuartoEnergiaRMateria7);

                    var CuartoEnergiaRMateria8 = new Cuarto() { Id = 8, CMateria = "INGLÉS IV" };
                    Cuartos.Add(CuartoEnergiaRMateria8);

                    ListCuarto.ItemsSource = Cuartos;

                    #endregion

                    #region Materias Energias Renovables 5C

                    Quintos = new List<Quinto>();

                    var QuintoEnergiaRMateria1 = new Quinto() { Id = 1, QMateria = "CÁLCULO INTEGRAL" };
                    Quintos.Add(QuintoEnergiaRMateria1);

                    var QuintoEnergiaRMateria2 = new Quinto() { Id = 2, QMateria = "SEGURIDAD INDUSTRIAL" };
                    Quintos.Add(QuintoEnergiaRMateria2);

                    var QuintoEnergiaRMateria3 = new Quinto() { Id = 3, QMateria = "CELDAS FOTOVOLTÁICAS" };
                    Quintos.Add(QuintoEnergiaRMateria3);

                    var QuintoEnergiaRMateria4 = new Quinto() { Id = 4, QMateria = "COLECTORES SOLARES" };
                    Quintos.Add(QuintoEnergiaRMateria4);

                    var QuintoEnergiaRMateria5 = new Quinto() { Id = 5, QMateria = "ADMINISTRACIÓN DE PROYECTOS" };
                    Quintos.Add(QuintoEnergiaRMateria5);

                    var QuintoEnergiaRMateria6 = new Quinto() { Id = 6, QMateria = "ADQUISICIÓN DE DATOS" };
                    Quintos.Add(QuintoEnergiaRMateria6);

                    var QuintoEnergiaRMateria7 = new Quinto() { Id = 7, QMateria = "INTEGRADORA II " };
                    Quintos.Add(QuintoEnergiaRMateria7);

                    var QuintoEnergiaRMateria8 = new Quinto() { Id = 8, QMateria = "INGLÉS V" };
                    Quintos.Add(QuintoEnergiaRMateria8);

                    ListQuinto.ItemsSource = Quintos;

                    #endregion

                    #region Estadia

                    Sextos = new List<Sexto>();

                    var Estadias = new Sexto() { Id = 1, SxMateria = "ESTADIA" };
                    Sextos.Add(Estadias);

                    ListSexto.ItemsSource = Sextos;

                    #endregion

                    break;

                #endregion

                #region case 6

                case 6:

                    //TECNOLOGIAS DE LA INFORMACION AREA DESARROLL MULTIPLATAFORMA

                    #region Primer Cuatrimestre

                    primeros = new List<Primero>();

                    var TidmMateria1 = new Primero() { Id = 1, PMateria = "ÁLGEBRA LINEAL" };
                    primeros.Add(TidmMateria1);

                    var TidmMateria2 = new Primero() { Id = 2, PMateria = "DESARROLLO DE HABILIDADES DE PENSAMIENTO LOGICO" };
                    primeros.Add(TidmMateria2);

                    var TidmMatetria3 = new Primero() { Id = 3, PMateria = "FUNDAMENTOS DE TI" };
                    primeros.Add(TidmMatetria3);

                    var TidmMateria4 = new Primero() { Id = 4, PMateria = "FUNDAMENTOS DE REDES" };
                    primeros.Add(TidmMateria4);

                    var TidmMateria5 = new Primero() { Id = 5, PMateria = "METODOLOGIA DE LA PROGRAMACION" };
                    primeros.Add(TidmMateria5);

                    var TidmMateria6 = new Primero() { Id = 6, PMateria = "EXPRESIÓN ORAL Y ESCRITA I" };
                    primeros.Add(TidmMateria6);

                    var TidmMateria7 = new Primero() { Id = 7, PMateria = "INGLÉS I" };
                    primeros.Add(TidmMateria7);

                    var TidmMateria8 = new Primero() { Id = 8, PMateria = "FORMACIÓN SOCIOCULTURAL I" };
                    primeros.Add(TidmMateria8);

                    ListPrimero.ItemsSource = primeros;

                    #endregion

                    #region Sgundo Cuatrimestres

                    Segundos = new List<Segundo>();

                    var SengundoTidmM1 = new Segundo() { Id = 1, SMateria = "FUNCIONES MATEMÁTICAS" };
                    Segundos.Add(SengundoTidmM1);

                    var SengundoTidmM2 = new Segundo() { Id = 2, SMateria = "METODOLOGIA Y MODELACION DE SOFTWARE" };
                    Segundos.Add(SengundoTidmM2);

                    var SengundoTidmM3 = new Segundo() { Id = 3, SMateria = "INTERCONEXIÓN DE REDES" };
                    Segundos.Add(SengundoTidmM3);

                    var SengundoTidmM4 = new Segundo() { Id = 4, SMateria = "PROGRAMACIÓN ORIENTADA A OBJETOS" };
                    Segundos.Add(SengundoTidmM4);

                    var SengundoTidmM5 = new Segundo() { Id = 5, SMateria = "INTRODUCCIÓN AL DISEÑO DIGITAL" };
                    Segundos.Add(SengundoTidmM5);

                    var SengundoTidmM6 = new Segundo() { Id = 6, SMateria = "BASE DE DATOS" };
                    Segundos.Add(SengundoTidmM6);

                    var SengundoTidmM7 = new Segundo() { Id = 7, SMateria = "INGLÉS II" };
                    Segundos.Add(SengundoTidmM7);

                    var SengundoTidmM8 = new Segundo() { Id = 8, SMateria = "FORMACIÓN SOCIOCULTURAL II" };
                    Segundos.Add(SengundoTidmM8);

                    ListSegundo.ItemsSource = Segundos;

                    #endregion

                    #region Tercer Cuatrimestre

                    Terceros = new List<Tercero>();

                    var TerceroTidmM1 = new Tercero() { Id = 1, TMateria = "CALCULO DIFERENCIAL" };
                    Terceros.Add(TerceroTidmM1);

                    var TerceroTidmM2 = new Tercero() { Id = 2, TMateria = "PROBABILIDAD Y ESTADÍSTICA" };
                    Terceros.Add(TerceroTidmM2);

                    var TerceroTidmM3 = new Tercero() { Id = 3, TMateria = "SISTEMAS OPERATIVOS" };
                    Terceros.Add(TerceroTidmM3);

                    var TerceroTidmM4 = new Tercero() { Id = 4, TMateria = "INTEGRADORA I" };
                    Terceros.Add(TerceroTidmM4);

                    var TerceroTidmM5 = new Tercero() { Id = 5, TMateria = "APLICACIONES WEB" };
                    Terceros.Add(TerceroTidmM5);

                    var TerceroTidmM6 = new Tercero() { Id = 6, TMateria = "BASE DE DATOS PARA APLICACIONES" };
                    Terceros.Add(TerceroTidmM6);

                    var TerceroTidmM7 = new Tercero() { Id = 7, TMateria = "INGLÉS III" };
                    Terceros.Add(TerceroTidmM7);

                    var TerceroTidmM8 = new Tercero() { Id = 8, TMateria = "FORMACIÓN SOCIOCULTURAL III" };
                    Terceros.Add(TerceroTidmM8);

                    ListTercero.ItemsSource = Terceros;

                    #endregion

                    #region Cuarto Cuatrimestre

                    Cuartos = new List<Cuarto>();

                    var CuartoTidmM1 = new Cuarto() { Id = 1, CMateria = "ÉSTANDARES Y MÉTRICAS PARA EL DESARROLLO DE SOFTWARE" };
                    Cuartos.Add(CuartoTidmM1);

                    var CuartoTidmM2 = new Cuarto() { Id = 2, CMateria = "PRINCIPIOS PARA loT" };
                    Cuartos.Add(CuartoTidmM2);

                    var CuartoTidmM3 = new Cuarto { Id = 3, CMateria = "DISEÑO DE APPS" };
                    Cuartos.Add(CuartoTidmM3);

                    var CuartoTidmM4 = new Cuarto() { Id = 4, CMateria = "APLICACIONES WEB ORIENTADA A SERVICIOS" };
                    Cuartos.Add(CuartoTidmM4);

                    var CuartoTidmM5 = new Cuarto() { Id = 5, CMateria = "EVALUACION Y MEJORA PARA EL DESARROLLO DE SOFTWARE" };
                    Cuartos.Add(CuartoTidmM5);

                    var CuartoTidmM6 = new Cuarto() { Id = 6, CMateria = "INGLÉS IV" };
                    Cuartos.Add(CuartoTidmM6);

                    var CuartoTidmM7 = new Cuarto() { Id = 7, CMateria = "FORMACIÓN SOCIOCULTURAL IV" };
                    Cuartos.Add(CuartoTidmM7);

                    var CuartoTidmM8 = new Cuarto() { Id = 8, CMateria = "ESTRUCTURA DE DATOS APLICADAS" };
                    Cuartos.Add(CuartoTidmM8);

                    ListCuarto.ItemsSource = Cuartos;

                    #endregion

                    #region Quinto Cuatrimestre

                    Quintos = new List<Quinto>();

                    var QuintoTidmM1 = new Quinto() { Id = 1, QMateria = "APLICAIONES DE loT" };
                    Quintos.Add(QuintoTidmM1);

                    var QuintoTidmM2 = new Quinto() { Id = 2, QMateria = "DESARROLLO MOVIL MULTIPLATAFORMA" };
                    Quintos.Add(QuintoTidmM2);

                    var QuintoTidmM3 = new Quinto() { Id = 3, QMateria = "INTEGRADORA II" };
                    Quintos.Add(QuintoTidmM3);

                    var QuintoTidmM4 = new Quinto() { Id = 4, QMateria = "APLICACIONES WEB PARA 14.0" };
                    Quintos.Add(QuintoTidmM4);

                    var QuintoTidmM5 = new Quinto() { Id = 5, QMateria = "BASE DE DATOS PARA COMPUTO EN LA NUBE" };
                    Quintos.Add(QuintoTidmM5);

                    var QuintoTidmM6 = new Quinto() { Id = 6, QMateria = "EXPRESION ORAL Y ESCRITA II" };
                    Quintos.Add(QuintoTidmM6);

                    var QuintoTidmM7 = new Quinto() { Id = 7, QMateria = "INGLÉS V" };
                    Quintos.Add(QuintoTidmM7);

                    ListQuinto.ItemsSource = Quintos;

                    #endregion

                    #region Sexto Cuatrimestre

                    Sextos = new List<Sexto>();

                    var E = new Sexto() { Id = 1, SxMateria = "ESTADIA" };
                    Sextos.Add(E);

                    ListSexto.ItemsSource = Sextos;

                    #endregion

                    break;

                #endregion

                #region case 7

                case 7:

                    //NANO

                    #region Primer Cuatrimestre

                    primeros = new List<Primero>();

                    var PrimerNanoM1 = new Primero() { Id = 1, PMateria = "ALGREBRA LINEAL" };
                    primeros.Add(PrimerNanoM1);

                    var PrimerNanoM2 = new Primero() { Id = 2, PMateria = "PROBABILIDAD Y ESTDISTICA" };
                    primeros.Add(PrimerNanoM2);

                    var PrimerNanoM3 = new Primero() { Id = 3, PMateria = "QUIMICA BASICA" };
                    primeros.Add(PrimerNanoM3);

                    var PrimerNanoM4 = new Primero() { Id = 4, PMateria = "BIOLOGIA" };
                    primeros.Add(PrimerNanoM4);

                    var PrimerNanoM5 = new Primero() { Id = 5, PMateria = "INFORMATICA" };
                    primeros.Add(PrimerNanoM5);

                    var PrimerNanoM6 = new Primero() { Id = 6, PMateria = "EXPRESION ORAL Y ESCRITA I" };
                    primeros.Add(PrimerNanoM6);

                    var PrimerNanoM7 = new Primero() { Id = 7, PMateria = "INGLES I" };
                    primeros.Add(PrimerNanoM7);

                    var PrimerNanoM8 = new Primero() { Id = 8, PMateria = "FORMACION SOCIOCULTURAL I" };
                    primeros.Add(PrimerNanoM8);

                    ListPrimero.ItemsSource = primeros;

                    #endregion

                    #region Segundo Cuatrimestre

                    Segundos = new List<Segundo>();

                    var SegundoNanoM1 = new Segundo() { Id = 1, SMateria = "FUNCIONES MATEMATICAS" };
                    Segundos.Add(SegundoNanoM1);

                    var SegundoNanoM2 = new Segundo() { Id = 2, SMateria = "ESTRUCTURA Y PROPIEDADES DE LOS MATERIALES" };
                    Segundos.Add(SegundoNanoM2);

                    var SegundoNanoM3 = new Segundo() { Id = 3, SMateria = "FISICA" };
                    Segundos.Add(SegundoNanoM3);

                    var SegundoNanoM4 = new Segundo() { Id = 4, SMateria = "QUIMICA ORGANICA" };
                    Segundos.Add(SegundoNanoM4);

                    var SegundoNanoM5 = new Segundo() { Id = 5, SMateria = "QUIMICA INORGANICA" };
                    Segundos.Add(SegundoNanoM5);

                    var SegundoNanoM6 = new Segundo() { Id = 6, SMateria = "METROLOGIA" };
                    Segundos.Add(SegundoNanoM6);

                    var SegundoNanoM7 = new Segundo() { Id = 7, SMateria = "ADMINISTRACION DE LABORATORIOS" };
                    Segundos.Add(SegundoNanoM7);

                    var SegundoNanoM8 = new Segundo() { Id = 8, SMateria = "INGLES II" };
                    Segundos.Add(SegundoNanoM8);

                    var SegundoNanoM9 = new Segundo() { Id = 9, SMateria = "FORMACION SOCIOCULTURAL" };
                    Segundos.Add(SegundoNanoM9);

                    ListSegundo.ItemsSource = Segundos;

                    #endregion

                    #region Tercer Cuatrimestre

                    Terceros = new List<Tercero>();

                    var TerceroNanoM1 = new Tercero() { Id = 1, TMateria = "CALCULO DIFERENCIAL" };
                    Terceros.Add(TerceroNanoM1);

                    var TerceroNanoM2 = new Tercero() { Id = 2, TMateria = "TERMODINAMICA" };
                    Terceros.Add(TerceroNanoM2);

                    var TerceroNanoM3 = new Tercero() { Id = 3, TMateria = "ELECTRICIDAD Y MAGNETISMO" };
                    Terceros.Add(TerceroNanoM3);

                    var TerceroNanoM4 = new Tercero() { Id = 4, TMateria = "QUIMICA ANALITICA" };
                    Terceros.Add(TerceroNanoM4);

                    var TerceroNanoM5 = new Tercero() { Id = 5, TMateria = "INSTRUMENTACION" };
                    Terceros.Add(TerceroNanoM5);

                    var TerceroNanoM6 = new Tercero() { Id = 6, TMateria = "SINTESIS DE MATERIALES I" };
                    Terceros.Add(TerceroNanoM6);

                    var TerceroNanoM7 = new Tercero() { Id = 7, TMateria = "CIENCIA DE LOS MATERIALES" };
                    Terceros.Add(TerceroNanoM7);

                    var TerceroNanoM8 = new Tercero() { Id = 8, TMateria = "COSTOS" };
                    Terceros.Add(TerceroNanoM8);

                    var TerceroNanoM9 = new Tercero() { Id = 9, TMateria = "INGLES III" };
                    Terceros.Add(TerceroNanoM9);

                    var TerceroNanoM10 = new Tercero() { Id = 10, TMateria = "FORMACION SOCIOCULTURAL III" };
                    Terceros.Add(TerceroNanoM10);

                    ListTercero.ItemsSource = Terceros;

                    #endregion

                    #region Cuarto Cuatrimestre

                    Cuartos = new List<Cuarto>();

                    var CuartoNanoM1 = new Cuarto() { Id = 1, CMateria = "CALCULO INTEGRAL" };
                    Cuartos.Add(CuartoNanoM1);

                    var CuartoNanoM2 = new Cuarto() { Id = 2, CMateria = "ELECTROQUIMICA" };
                    Cuartos.Add(CuartoNanoM2);

                    var CuartoNanoM3 = new Cuarto() { Id = 3, CMateria = "SINSTESIS DE LOS MATERIALES II" };
                    Cuartos.Add(CuartoNanoM3);

                    var CuartoNanoM4 = new Cuarto() { Id = 4, CMateria = "MECANICA DE MATERIALES" };
                    Cuartos.Add(CuartoNanoM4);

                    var CuartoNanoM5 = new Cuarto() { Id = 5, CMateria = "MECANICA CUANTICA" };
                    Cuartos.Add(CuartoNanoM5);

                    var CuartoNanoM6 = new Cuarto() { Id = 6, CMateria = "TERMOQUIMICA" };
                    Cuartos.Add(CuartoNanoM6);

                    var CuartoNanoM7 = new Cuarto() { Id = 7, CMateria = "INTEGRADORA I" };
                    Cuartos.Add(CuartoNanoM7);

                    var CuartoNanoM8 = new Cuarto() { Id = 8, CMateria = "INGLES IV" };
                    Cuartos.Add(CuartoNanoM8);

                    var CuartoNanoM9 = new Cuarto() { Id = 9, CMateria = "FORMACION SOCIOCULTURAL IV" };
                    Cuartos.Add(CuartoNanoM9);

                    ListCuarto.ItemsSource = Cuartos;

                    #endregion

                    #region Quinto Cuatrimestre

                    Quintos = new List<Quinto>();

                    var QuintoNanoM1 = new Quinto() { Id = 1, QMateria = "NANOMATERIALES" };
                    Quintos.Add(QuintoNanoM1);

                    var QuintoNanoM2 = new Quinto() { Id = 2, QMateria = "INCORMPORACION DE MATERIALES" };
                    Quintos.Add(QuintoNanoM2);

                    var QuintoNanoM3 = new Quinto() { Id = 3, QMateria = "CARACTERIZACION DE MATERIALES" };
                    Quintos.Add(QuintoNanoM3);

                    var QuintoNanoM4 = new Quinto() { Id = 4, QMateria = "FUNDAMENTOS DE CALIDAD" };
                    Quintos.Add(QuintoNanoM4);

                    var QuintoNanoM5 = new Quinto() { Id = 5, QMateria = "INTEGRADORA II" };
                    Quintos.Add(QuintoNanoM5);

                    var QuintoNanoM6 = new Quinto() { Id = 6, QMateria = "INGLÉS V" };
                    Quintos.Add(QuintoNanoM6);

                    var QuintoNanoM7 = new Quinto() { Id = 7, QMateria = "EXPRESION ORAL Y ESCRITA II" };
                    Quintos.Add(QuintoNanoM7);

                    ListQuinto.ItemsSource = Quintos;

                    #endregion

                    #region Estadia

                    Sextos = new List<Sexto>();

                    var sextoNano = new Sexto() { Id = 1, SxMateria = "ESTADIA" };
                    Sextos.Add(sextoNano);

                    ListSexto.ItemsSource = Sextos;

                    #endregion

                    break;

                #endregion

                #region case8

                case 8:

                    //Mercadotecnia

                    #region Primer Cuatrimestre

                    primeros = new List<Primero>();

                    var PrimeroMercaM1 = new Primero() { Id = 1, PMateria = "MATEMATICAS" };
                    primeros.Add(PrimeroMercaM1);

                    var PrimeroMercaM2 = new Primero() { Id = 2, PMateria = "ADMINISTRACION" };
                    primeros.Add(PrimeroMercaM2);

                    var PrimeroMercaM3 = new Primero() { Id = 3, PMateria = "INFORMATICA I" };
                    primeros.Add(PrimeroMercaM3);

                    var PrimeroMercaM4 = new Primero() { Id = 4, PMateria = "ECONOMIA" };
                    primeros.Add(PrimeroMercaM4);

                    var PrimeroMercaM5 = new Primero() { Id = 5, PMateria = "MERCADOTECNIA" };
                    primeros.Add(PrimeroMercaM5);

                    var PrimeroMercaM6 = new Primero() { Id = 6, PMateria = "INGLES I" };
                    primeros.Add(PrimeroMercaM6);

                    var PrimeroMercaM7 = new Primero() { Id = 7, PMateria = "EXPRESION ORAL Y ESCRITA I" };
                    primeros.Add(PrimeroMercaM7);

                    var PrimeroMercaM8 = new Primero() { Id = 8, PMateria = "FORMACION SOCIOCULTURAL" };
                    primeros.Add(PrimeroMercaM8);

                    ListPrimero.ItemsSource = primeros;

                    #endregion

                    #region Segundo cuatrimestre

                    Segundos = new List<Segundo>();

                    var SegundoMercaM1 = new Segundo() { Id = 1, SMateria = "ESTADISTICA" };
                    Segundos.Add(SegundoMercaM1);

                    var SegundoMercaM2 = new Segundo() { Id = 2, SMateria = "CONTABILIDAD" };
                    Segundos.Add(SegundoMercaM2);

                    var SegundoMercaM3 = new Segundo() { Id = 3, SMateria = "INFORMATICA II" };
                    Segundos.Add(SegundoMercaM3);

                    var SegundoMercaM4 = new Segundo() { Id = 4, SMateria = "PLANEACION ESTRATEGICA" };
                    Segundos.Add(SegundoMercaM4);

                    var SegundoMercaM5 = new Segundo() { Id = 5, SMateria = "SISTEMA DE INVESTIGACION DE MERCADO" };
                    Segundos.Add(SegundoMercaM5);

                    var SegundoMercaM6 = new Segundo() { Id = 6, SMateria = "VENTAS" };
                    Segundos.Add(SegundoMercaM6);

                    var SegundoMercaM7 = new Segundo() { Id = 7, SMateria = "INGLES II" };
                    Segundos.Add(SegundoMercaM7);

                    var SegundoMercaM8 = new Segundo() { Id = 8, SMateria = "FORMACION SOCIOCULTURAL II" };
                    Segundos.Add(SegundoMercaM8);

                    ListSegundo.ItemsSource = Segundos;

                    #endregion

                    #region Tercer Cuatrimestre

                    Terceros = new List<Tercero>();

                    var TercerMercaM1 = new Tercero() { Id = 1, TMateria = "CALIDAD" };
                    Terceros.Add(TercerMercaM1);

                    var TercerMercaM2 = new Tercero() { Id = 2, TMateria = "GESTION DE PROYECTOS" };
                    Terceros.Add(TercerMercaM2);

                    var TercerMercaM3 = new Tercero() { Id = 3, TMateria = "LEGISLACION COMERCIAL" };
                    Terceros.Add(TercerMercaM3);

                    var TercerMercaM4 = new Tercero() { Id = 4, TMateria = "SISTEMA DE INVESTIGACION DE MERCADOS II" };
                    Terceros.Add(TercerMercaM4);

                    var TercerMercaM5 = new Tercero() { Id = 5, TMateria = "INTEGRADORA I" };
                    Terceros.Add(TercerMercaM5);

                    var TercerMercaM6 = new Tercero() { Id = 6, TMateria = "ESTRATEGIAS DE PRODUCTO" };
                    Terceros.Add(TercerMercaM6);

                    var TercerMercaM7 = new Tercero() { Id = 7, TMateria = "INGLES III" };
                    Terceros.Add(TercerMercaM7);

                    var TercerMercaM8 = new Tercero() { Id = 8, TMateria = "FORMACION SOCIOCULTURAL" };
                    Terceros.Add(TercerMercaM8);

                    ListTercero.ItemsSource = Terceros;

                    #endregion

                    #region Cuarto Cautrimestre

                    Cuartos = new List<Cuarto>();

                    var CuartoMercaM1 = new Cuarto() { Id = 1, CMateria = "DISEÑO GRAFICO" };
                    Cuartos.Add(CuartoMercaM1);

                    var CuartoMercaM2 = new Cuarto() { Id = 2, CMateria = "LOGISTICA Y DISTRIBUCION" };
                    Cuartos.Add(CuartoMercaM2);

                    var CuartoMercaM3 = new Cuarto() { Id = 3, CMateria = "COMPORTAMIENTO DEL CONUSMIDOR" };
                    Cuartos.Add(CuartoMercaM3);

                    var CuartoMercaM4 = new Cuarto() { Id = 4, CMateria = "ESTRATEGIAS DE PRECIO" };
                    Cuartos.Add(CuartoMercaM4);

                    var CuartoMercaM5 = new Cuarto() { Id = 5, CMateria = "MEZCLA PROMOCIONAL I" };
                    Cuartos.Add(CuartoMercaM5);

                    var CuartoMercaM6 = new Cuarto() { Id = 6, CMateria = "METODOLOGIA DE LA INVESTIGACION" };
                    Cuartos.Add(CuartoMercaM6);

                    var CuartoMercaM7 = new Cuarto() { Id = 7, CMateria = "INGLES IV" };
                    Cuartos.Add(CuartoMercaM7);

                    var CuartoMercaM8 = new Cuarto() { Id = 8, CMateria = "FORMACIO SOCIOCULTURAL IV" };
                    Cuartos.Add(CuartoMercaM8);

                    ListCuarto.ItemsSource = Cuartos;

                    #endregion

                    #region Quinto cuatrimestre

                    Quintos = new List<Quinto>();

                    var QuintoMercaM1 = new Quinto() { Id = 1, QMateria = "MERCADOTECNIA INTERNACIONAL" };
                    Quintos.Add(QuintoMercaM1);

                    var QuintoMercaM2 = new Quinto() { Id = 2, QMateria = "MEZCLA PROMOCIONAL II" };
                    Quintos.Add(QuintoMercaM2);

                    var QuintoMercaM3 = new Quinto() { Id = 3, QMateria = "MERCADOTECNIA DIGITAL" };
                    Quintos.Add(QuintoMercaM3);

                    var QuintoMercaM4 = new Quinto() { Id = 4, QMateria = "MERCADOTECNIA ESTRATEGICA" };
                    Quintos.Add(QuintoMercaM4);

                    var QuintoMercaM5 = new Quinto() { Id = 5, QMateria = "INTEGRADORA II" };
                    Quintos.Add(QuintoMercaM5);

                    var QuintoMercaM6 = new Quinto() { Id = 6, QMateria = "INGLES V" };
                    Quintos.Add(QuintoMercaM6);

                    var QuintoMercaM7 = new Quinto() { Id = 7, QMateria = "EXPRESION ORAL Y ESCRITA II" };
                    Quintos.Add(QuintoMercaM7);

                    ListQuinto.ItemsSource = Quintos;

                    #endregion

                    #region Estadia

                    Sextos = new List<Sexto>();

                    var MercaEstadia = new Sexto() { Id = 1, SxMateria = "ESTADIA" };

                    Sextos.Add(MercaEstadia);

                    ListSexto.ItemsSource = Sextos;

                    #endregion

                    break;

                #endregion

                #region Case 9

                case 9:

                    //Ventas

                    #region Primer Cuatrimestre

                    primeros = new List<Primero>();

                    var PrimeroVentasM1 = new Primero() { Id = 1, PMateria = "MATEMATICAS" };
                    primeros.Add(PrimeroVentasM1);

                    var PrimeroVentasM2 = new Primero() { Id = 2, PMateria = "ENTORNO DE LA EMPRESA" };
                    primeros.Add(PrimeroVentasM2);

                    var PrimeroVentasM3 = new Primero() { Id = 3, PMateria = "ADMINISTRACION" };
                    primeros.Add(PrimeroVentasM3);

                    var PrimeroVentasM4 = new Primero() { Id = 4, PMateria = "INFORMATICA PARA NEGOCIOS I" };
                    primeros.Add(PrimeroVentasM4);

                    var PrimeroVentasM5 = new Primero() { Id = 5, PMateria = "FUNDAMENTOS DE MERCADOTECNIA" };
                    primeros.Add(PrimeroVentasM5);

                    var PrimeroVentasM6 = new Primero() { Id = 6, PMateria = "CALIDAD" };
                    primeros.Add(PrimeroVentasM6);

                    var PrimeroVentasM7 = new Primero() { Id = 7, PMateria = "INGLES I" };
                    primeros.Add(PrimeroVentasM7);

                    var PrimeroVentasM8 = new Primero() { Id = 8, PMateria = "EXPREISON ORAL Y ESCRITA I" };
                    primeros.Add(PrimeroVentasM8);

                    var PrimeroVentasM9 = new Primero() { Id = 9, PMateria = "FORMACION SOCIOCULTURAL I" };
                    primeros.Add(PrimeroVentasM9);

                    ListPrimero.ItemsSource = primeros;

                    #endregion

                    #region Segundo Cuatrimestre

                    Segundos = new List<Segundo>();

                    var SegundoVentasM1 = new Segundo() { Id = 1, SMateria = "ESTADISTICA PARA NEGOCIOS" };
                    Segundos.Add(SegundoVentasM1);

                    var SegundoVentasM2 = new Segundo() { Id = 2, SMateria = "INFORMATICA PARA NEGOCIOS II" };
                    Segundos.Add(SegundoVentasM2);

                    var SegundoVentasM3 = new Segundo() { Id = 3, SMateria = "ESTUDIO DEL CONSUMIDOR" };
                    Segundos.Add(SegundoVentasM3);

                    var SegundoVentasM4 = new Segundo() { Id = 4, SMateria = "COMPRAS" };
                    Segundos.Add(SegundoVentasM4);

                    var SegundoVentasM5 = new Segundo() { Id = 5, SMateria = "PRESUPUESTO" };
                    Segundos.Add(SegundoVentasM5);

                    var SegundoVentasM6 = new Segundo() { Id = 6, SMateria = "GESTION DE VENTAS" };
                    Segundos.Add(SegundoVentasM6);

                    var SegundoVentasM7 = new Segundo() { Id = 7, SMateria = "INGLES II" };
                    Segundos.Add(SegundoVentasM7);

                    var SegundoVentasM8 = new Segundo() { Id = 8, SMateria = "FORMACION SOCIOCULTURAL II" };
                    Segundos.Add(SegundoVentasM8);

                    ListSegundo.ItemsSource = Segundos;

                    #endregion

                    #region Tercer Cuatrimestre

                    Terceros = new List<Tercero>();

                    var TerceroVentasM1 = new Tercero() { Id = 1, TMateria = "MANEJO MONETARIO" };
                    Terceros.Add(TerceroVentasM1);

                    var TerceroVentasM2 = new Tercero() { Id = 2, TMateria = "ESTRATEGIAS DE VENTAS" };
                    Terceros.Add(TerceroVentasM2);

                    var TerceroVentasM3 = new Tercero() { Id = 3, TMateria = "ADMINISTRACION DE ALMACEN" };
                    Terceros.Add(TerceroVentasM3);

                    var TerceroVentasM4 = new Tercero() { Id = 4, TMateria = "INTEGRADORA I" };
                    Terceros.Add(TerceroVentasM4);

                    var TerceroVentasM5 = new Tercero() { Id = 5, TMateria = "MERCEOLOGIA" };
                    Terceros.Add(TerceroVentasM5);

                    var TerceroVentasM6 = new Tercero() { Id = 6, TMateria = "FUNDAMENTOS DE LOGISTICA" };
                    Terceros.Add(TerceroVentasM6);

                    var TerceroVentasM7 = new Tercero() { Id = 7, TMateria = "FUNDAMENTOS DE CONTABILIDAD" };
                    Terceros.Add(TerceroVentasM7);

                    var TerceroVentasM8 = new Tercero() { Id = 8, TMateria = "FORMACION SOCIOCULTURAL III" };
                    Terceros.Add(TerceroVentasM8);

                    var TerceroVentasM9 = new Tercero() { Id = 9, TMateria = "INGLES III" };
                    Terceros.Add(TerceroVentasM9);

                    ListTercero.ItemsSource = Terceros;

                    #endregion

                    #region Cuarto Cuatrimestre

                    Cuartos = new List<Cuarto>();

                    var CuartoVentasM1 = new Cuarto() { Id = 1, CMateria = "MARCHANDISING" };
                    Cuartos.Add(CuartoVentasM1);

                    var CuartoVentasM2 = new Cuarto() { Id = 2, CMateria = "OPERACION DE ALMACENES" };
                    Cuartos.Add(CuartoVentasM2);

                    var CuartoVentasM3 = new Cuarto() { Id = 3, CMateria = "QUIMICA DE LOS ALIMENTOS" };
                    Cuartos.Add(CuartoVentasM3);

                    var CuartoVentasM4 = new Cuarto() { Id = 4, CMateria = "TECNICAS DE VENTAS" };
                    Cuartos.Add(CuartoVentasM4);

                    var CuartoVentasM5 = new Cuarto() { Id = 5, CMateria = "FUNDAMENTOS DE PLANEACION ESTRATEGICA" };
                    Cuartos.Add(CuartoVentasM5);

                    var CuartoVentasM6 = new Cuarto() { Id = 6, CMateria = "DISEÑO DE RUTAS DE VENTAS" };
                    Cuartos.Add(CuartoVentasM6);

                    var CuartoVentasM7 = new Cuarto() { Id = 7, CMateria = "FORMACION SOCIOCULTURAL III" };
                    Cuartos.Add(CuartoVentasM7);

                    var CuartoVentasM8 = new Cuarto() { Id = 8, CMateria = "INGLES IV" };
                    Cuartos.Add(CuartoVentasM8);

                    ListCuarto.ItemsSource = Cuartos;

                    #endregion

                    #region Quinto Cuatrimestre

                    Quintos = new List<Quinto>();

                    var QuintoVentasM1 = new Quinto() { Id = 1, QMateria = "ARGUMENTACION Y CIERRE DE LA VENTA" };
                    Quintos.Add(QuintoVentasM1);

                    var QuintoVentasM2 = new Quinto() { Id = 2, QMateria = "INVESTIGACION Y DESARROLLO DE MERCADO" };
                    Quintos.Add(QuintoVentasM2);

                    var QuintoVentasM3 = new Quinto() { Id = 3, QMateria = "CONTROL DE VENTAS" };
                    Quintos.Add(QuintoVentasM3);

                    var QuintoVentasM4 = new Quinto() { Id = 4, QMateria = "SERVICIO AL CLIENTE" };
                    Quintos.Add(QuintoVentasM4);

                    var QuintoVentasM5 = new Quinto() { Id = 5, QMateria = "OPERACIONES BASICAS  DE VEHICULOS DE TRANSPORTE" };
                    Quintos.Add(QuintoVentasM5);

                    var QuintoVentasM6 = new Quinto() { Id = 6, QMateria = "INTEGRADORA II" };
                    Quintos.Add(QuintoVentasM6);

                    var QuintoVentasM7 = new Quinto() { Id = 7, QMateria = "EXPRESION ORAL Y ESCRITA II" };
                    Quintos.Add(QuintoVentasM7);

                    var QuintoVentasM8 = new Quinto() { Id = 8, QMateria = "INGLES V" };
                    Quintos.Add(QuintoVentasM8);

                    ListQuinto.ItemsSource = Quintos;

                    #endregion

                    #region Ventas Estadia

                    Sextos = new List<Sexto>();

                    var VentaEstadia = new Sexto() { Id = 1, SxMateria = "ESTADIA" };
                    Sextos.Add(VentaEstadia);

                    ListSexto.ItemsSource = Sextos;

                    #endregion

                    break;

                #endregion

                #region Case 10

                case 10:

                    //Logistica

                    #region Primero Cuatrimestre

                    primeros = new List<Primero>();

                    var PrimeroLogisticaM1 = new Primero() { Id = 1, PMateria = "MATEMATICAS" };
                    primeros.Add(PrimeroLogisticaM1);

                    var PrimeroLogisticaM2 = new Primero() { Id = 2, PMateria = "INTRODUCCION A LA LOGISTICA" };
                    primeros.Add(PrimeroLogisticaM2);

                    var PrimeroLogisticaM3 = new Primero() { Id = 3, PMateria = "ALMACEN" };
                    primeros.Add(PrimeroLogisticaM3);

                    var PrimeroLogisticaM4 = new Primero() { Id = 4, PMateria = "FUNDAMENTOS DE ADMINISTRACION" };
                    primeros.Add(PrimeroLogisticaM4);

                    var PrimeroLogisticaM5 = new Primero() { Id = 5, PMateria = "FUNDAMENTOS DE INVENTARIO" };
                    primeros.Add(PrimeroLogisticaM5);

                    var PrimeroLogisticaM6 = new Primero() { Id = 6, PMateria = "INFORMATICA" };
                    primeros.Add(PrimeroLogisticaM6);

                    var PrimeroLogisticaM7 = new Primero() { Id = 7, PMateria = "INGLES I" };
                    primeros.Add(PrimeroLogisticaM7);

                    var PrimeroLogisticaM8 = new Primero() { Id = 8, PMateria = "EXPRESION ORAL Y ESCRITA I" };
                    primeros.Add(PrimeroLogisticaM8);

                    var PrimeroLogisticaM9 = new Primero() { Id = 9, PMateria = "FORMACION SOCIOCULTURAL I" };
                    primeros.Add(PrimeroLogisticaM9);

                    ListPrimero.ItemsSource = primeros;

                    #endregion

                    #region Segundo Cuaitrimestre

                    Segundos = new List<Segundo>();

                    var SegundoLogisticaM1 = new Segundo() { Id = 1, SMateria = "MODELOS MATEMATICOS" };
                    Segundos.Add(SegundoLogisticaM1);

                    var SegundoLogisticaM2 = new Segundo() { Id = 2, SMateria = "LOGISTICA" };
                    Segundos.Add(SegundoLogisticaM2);

                    var SegundoLogisticaM3 = new Segundo() { Id = 3, SMateria = "COMPRAS" };
                    Segundos.Add(SegundoLogisticaM3);

                    var SegundoLogisticaM4 = new Segundo() { Id = 4, SMateria = "COSTOS" };
                    Segundos.Add(SegundoLogisticaM4);

                    var SegundoLogisticaM5 = new Segundo() { Id = 5, SMateria = "MANEJO DE LA CARGAR" };
                    Segundos.Add(SegundoLogisticaM5);

                    var SegundoLogisticaM6 = new Segundo() { Id = 6, SMateria = "FUNDAMENTOS DE COMERCIO INTERNACIONAL" };
                    Segundos.Add(SegundoLogisticaM6);

                    var SegundoLogisticaM7 = new Segundo() { Id = 7, SMateria = "CONTROL DE INVENTARIOS" };
                    Segundos.Add(SegundoLogisticaM7);

                    var SegundoLogisticaM8 = new Segundo() { Id = 8, SMateria = "INGLES III" };
                    Segundos.Add(SegundoLogisticaM8);

                    var SegundoLogisticaM9 = new Segundo() { Id = 9, SMateria = "FORMACION SOCIOCULTURAL II" };
                    Segundos.Add(SegundoLogisticaM9);

                    ListSegundo.ItemsSource = Segundos;

                    #endregion

                    #region Tercer Cuatrimestre

                    Terceros = new List<Tercero>();

                    var TerceroLogisticaM1 = new Tercero() { Id = 1, TMateria = "ESTADISTICA" };
                    Terceros.Add(TerceroLogisticaM1);

                    var TerceroLogisticaM2 = new Tercero() { Id = 2, TMateria = "TRANSPORTE" };
                    Terceros.Add(TerceroLogisticaM2);

                    var TerceroLogisticaM3 = new Tercero() { Id = 3, TMateria = "TRAFICO" };
                    Terceros.Add(TerceroLogisticaM3);

                    var TerceroLogisticaM4 = new Tercero() { Id = 4, TMateria = "PRESUPUESTOS" };
                    Terceros.Add(TerceroLogisticaM4);

                    var TerceroLogisticaM5 = new Tercero() { Id = 5, TMateria = "GESTION DE ALMACEN" };
                    Terceros.Add(TerceroLogisticaM5);

                    var TerceroLogisticaM6 = new Tercero() { Id = 6, TMateria = "MARCO REGULATORIO DE COMERCIO INTERNACIONAL" };
                    Terceros.Add(TerceroLogisticaM6);

                    var TerceroLogisticaM7 = new Tercero() { Id = 7, TMateria = "CALIDAD" };
                    Terceros.Add(TerceroLogisticaM7);

                    var TerceroLogisticaM8 = new Tercero() { Id = 8, TMateria = "INTEGRADORA I" };
                    Terceros.Add(TerceroLogisticaM8);

                    var TerceroLogisticaM9 = new Tercero() { Id = 9, TMateria = "INGLES III" };
                    Terceros.Add(TerceroLogisticaM9);

                    var TerceroLogisticaM10 = new Tercero() { Id = 10, TMateria = "FORMACION SOCIOCULTURAL III" };
                    Terceros.Add(TerceroLogisticaM10);

                    ListTercero.ItemsSource = Terceros;

                    #endregion

                    #region Cuarto Cuatrimestre

                    Cuartos = new List<Cuarto>();

                    var CuartoLogisticaM1 = new Cuarto() { Id = 1, CMateria = "INDICADORES DE DESEMPEÑO" };
                    Cuartos.Add(CuartoLogisticaM1);

                    var CuartoLogisticaM2 = new Cuarto() { Id = 2, CMateria = "INFRAESTRUCTURA LOGISTICA" };
                    Cuartos.Add(CuartoLogisticaM2);

                    var CuartoLogisticaM3 = new Cuarto() { Id = 3, CMateria = "EMBALAJE Y ETIQUETADO" };
                    Cuartos.Add(CuartoLogisticaM3);

                    var CuartoLogisticaM4 = new Cuarto() { Id = 4, CMateria = "ADMINISTRACION DE MATERIALES DE LA PRODUCCION" };
                    Cuartos.Add(CuartoLogisticaM4);

                    var CuartoLogisticaM5 = new Cuarto() { Id = 5, CMateria = "ADMINISTRACION DE INVENTARIOS DE LA CADENA DE SUMINISTROS" };
                    Cuartos.Add(CuartoLogisticaM5);

                    var CuartoLogisticaM6 = new Cuarto() { Id = 6, CMateria = "CALIDAD APLICADA" };
                    Cuartos.Add(CuartoLogisticaM6);

                    var CuartoLogisticaM7 = new Cuarto() { Id = 7, CMateria = "INGLES IV" };
                    Cuartos.Add(CuartoLogisticaM7);

                    var CuartoLogisticaM8 = new Cuarto() { Id = 8, CMateria = "FORMACION SOCIOCULTURAL IV" };
                    Cuartos.Add(CuartoLogisticaM8);

                    ListCuarto.ItemsSource = Cuartos;

                    #endregion

                    #region Quinto Cuatrimestre

                    Quintos = new List<Quinto>();

                    var QuintoLogisticaM1 = new Quinto() { Id = 1, QMateria = "MATEMATICAS FINANCIERAS" };
                    Quintos.Add(QuintoLogisticaM1);

                    var QuintoLogisticaM2 = new Quinto() { Id = 2, QMateria = "GESTION DE LA CADENA DE SUMINISTRO" };
                    Quintos.Add(QuintoLogisticaM2);

                    var QuintoLogisticaM3 = new Quinto() { Id = 3, QMateria = "REDES DE BASTECIMIENTO" };
                    Quintos.Add(QuintoLogisticaM3);

                    var QuintoLogisticaM4 = new Quinto() { Id = 4, QMateria = "OPERACION DE COMERCIO EXTERIOR" };
                    Quintos.Add(QuintoLogisticaM4);

                    var QuintoLogisticaM5 = new Quinto() { Id = 5, QMateria = "INTEGRADORA II" };
                    Quintos.Add(QuintoLogisticaM5);

                    var QuintoLogisticaM6 = new Quinto() { Id = 6, QMateria = "INGLES V" };
                    Quintos.Add(QuintoLogisticaM6);

                    var QuintoLogisticaM7 = new Quinto() { Id = 7, QMateria = "EXPRESION ORAL Y ESCRITA II" };
                    Quintos.Add(QuintoLogisticaM7);

                    ListQuinto.ItemsSource = Quintos;

                    #endregion

                    #region Estadia

                    Sextos = new List<Sexto>();

                    var LogisticaEstadia = new Sexto() { Id = 1, SxMateria = "ESTADIA" };
                    Sextos.Add(LogisticaEstadia);

                    ListSexto.ItemsSource = Sextos;

                    #endregion

                    break;

                    #endregion

            }
        }

    }

}