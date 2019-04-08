using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UT_Escobedo.Model.OfertaEducativaModelo;
using UT_Escobedo.Model.OfertaEducativaModelo.Cuatrimestres;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UT_Escobedo.Views.Oferta_Educativa
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Nocturno : ContentPage
	{

        public List<Primero> primeros { get; set; }
        public List<Segundo> Segundos { get; set; }
        public List<Tercero> Terceros { get; set; }
        public List<Cuarto> Cuartos { get; set; }
        public List<Quinto> Quintos { get; set; }
        public List<Sexto> Sextos { get; set; }
        public List<Septimo> Septimos { get; set; }
        public List<Octavo> Octavos { get; set; }

        public Nocturno ()
		{

			InitializeComponent ();

            int IdTsu = OfertaEducativaPage.Id;

            switch (IdTsu)
            {

                #region case 1

                case 1:

                    //Materias de Quimica Ambiental

                    Grid.IsEnabled = false;
                    Grid.IsVisible = false;

                    NOC.IsVisible = true;
                    NOC.IsEnabled = true; 

                    break;

                #endregion

                #region Case 2

                case 2:

                    //Materias de LENGUA INGLESA

                    Grid.IsEnabled = false;
                    Grid.IsVisible = false;

                    NOC.IsVisible = true;
                    NOC.IsEnabled = true; 

                    break;

                #endregion

                #region Case 3

                case 3:
                    // Carrreras de mantenimiento

                    #region Materias MTO 1C

                    primeros = new List<Primero>();

                    var primeroMTOM1 = new Primero() { Id = 1, PMateria = "ALGEBRA LINEAL" };
                    primeros.Add(primeroMTOM1);

                    var primeroMTOM2 = new Primero() { Id = 2, PMateria = "TECNOLOGIAS PARA LA DIGITALIZACION" };
                    primeros.Add(primeroMTOM2);

                    var primeroMTOM3 = new Primero() { Id = 3, PMateria = "INTRODUCCION AL MANTENIMIENTO" };
                    primeros.Add(primeroMTOM3);

                    var primeroMTOM4 = new Primero() { Id = 4, PMateria = "INGLES I" };
                    primeros.Add(primeroMTOM4);

                    var primeroMTOM5 = new Primero() { Id = 5, PMateria = "EXPRESION ORAL Y ESCRITA I" };
                    primeros.Add(primeroMTOM5);

                    var primeroMTOM6 = new Primero() { Id = 6, PMateria = "FORMACION SOCIOCULTURAL I" };
                    primeros.Add(primeroMTOM6);

                    NocturnoPrimero.ItemsSource = primeros;

                    #endregion

                    #region Materias MTO 2C

                    Segundos = new List<Segundo>();

                    var SegundoMTOM1 = new Segundo() { Id = 1, SMateria = "FUNCIONES MATEMATICAS" };
                    Segundos.Add(SegundoMTOM1);

                    var SegundoMTOM2 = new Segundo() { Id = 2, SMateria = "GESTION DEL MANTENIMIENTO" };
                    Segundos.Add(SegundoMTOM2);

                    var SegundoMTOM3 = new Segundo() { Id = 3, SMateria = "ADMINISTRACION DEL PERSONAL" };
                    Segundos.Add(SegundoMTOM3);

                    var SegundoMTOM4 = new Segundo() { Id = 4, SMateria = "DIBUJO INDUSTRIAL" };
                    Segundos.Add(SegundoMTOM4);

                    var SegundoMTOM5 = new Segundo() { Id = 5, SMateria = "SEGURIDAD Y MEDIO AMBIENTE" };
                    Segundos.Add(SegundoMTOM5);

                    var SegundoMTOM6 = new Segundo() { Id = 6, SMateria = "INGLES II" };
                    Segundos.Add(SegundoMTOM6);

                    var SegundoMTOM7 = new Segundo() { Id = 7, SMateria = "FORMACIÓN SOCIOCULTURAL II" };
                    Segundos.Add(SegundoMTOM7);

                    NocturnoSegundo.ItemsSource = Segundos;

                    #endregion

                    #region Materias MTO 3C

                    Terceros = new List<Tercero>();

                    var TerceroMTOM1 = new Tercero() { Id = 1, TMateria = "CALCULDO DIFERENCIAL" };
                    Terceros.Add(TerceroMTOM1);

                    var TerceroMTOM2 = new Tercero() { Id = 2, TMateria = "FISICA" };
                    Terceros.Add(TerceroMTOM2);

                    var TerceroMTOM3 = new Tercero() { Id = 3, TMateria = "METODOS Y SISTEMAS DE TRABAJO" };
                    Terceros.Add(TerceroMTOM3);

                    var TerceroMTOM4 = new Tercero() { Id = 4, TMateria = "CALIDAD DEL MANTENIMIENTO" };
                    Terceros.Add(TerceroMTOM4);

                    var TerceroMTOM5 = new Tercero() { Id = 5, TMateria = "COSTOS Y PRESUPUESTOS" };
                    Terceros.Add(TerceroMTOM5);

                    var TerceroMTOM6 = new Tercero() { Id = 6, TMateria = "INTEGRADORA I" };
                    Terceros.Add(TerceroMTOM6);

                    var TerceroMTOM7 = new Tercero() { Id = 7, TMateria = "INGLES III" };
                    Terceros.Add(TerceroMTOM7);

                    NocturnoTercero.ItemsSource = Terceros;

                    #endregion

                    #region Materias MTO 4C

                    Cuartos = new List<Cuarto>();

                    var CuartoMTOM1 = new Cuarto() { Id = 1, CMateria = "QUIMICA" };
                    Cuartos.Add(CuartoMTOM1);

                    var CuartoMTOM2 = new Cuarto() { Id = 2, CMateria = "TERMODINAMICA" };
                    Cuartos.Add(CuartoMTOM2);

                    var CuartoMTOM3 = new Cuarto() { Id = 3, CMateria = "CALCULO INTEGRAL" };
                    Cuartos.Add(CuartoMTOM3);

                    var CuartoMTOM4 = new Cuarto() { Id = 4, CMateria = "ELECTRICIDAD Y MAGNETISMO" };
                    Cuartos.Add(CuartoMTOM4);

                    var CuartoMTOM5 = new Cuarto() { Id = 5, CMateria = "PRINCIPIOS DE PROGRAMACION" };
                    Cuartos.Add(CuartoMTOM5);

                    var CuartoMTOM6 = new Cuarto() { Id = 6, CMateria = "MAQUINAS Y MECANISMOS" };
                    Cuartos.Add(CuartoMTOM6);

                    NocturnoCuarto.ItemsSource = Cuartos;

                    #endregion

                    #region Materias MTO 5C

                    Quintos = new List<Quinto>();

                    var QuintoMTOM1 = new Quinto() { Id = 1, QMateria = "PROBABILIDAD Y ESTADISTICA" };
                    Quintos.Add(QuintoMTOM1);

                    var QuintoMTOM2 = new Quinto() { Id = 2, QMateria = "ESTRUCTURA Y PROPIEDADES DE LOS MATERIALES" };
                    Quintos.Add(QuintoMTOM2);

                    var QuintoMTOM3 = new Quinto() { Id = 3, QMateria = "REDES DE SERVICIOS INDUSTRIALES" };
                    Quintos.Add(QuintoMTOM3);

                    var QuintoMTOM4 = new Quinto() { Id = 4, QMateria = "SISTEMAS ELECTRICOS" };
                    Quintos.Add(QuintoMTOM4);

                    var QuintoMTOM5 = new Quinto() { Id = 5, QMateria = "SISTEMAS NEUMATICOS E HIDRAULICOS" };
                    Quintos.Add(QuintoMTOM5);
                
                    var QuintoMTOM6 = new Quinto() { Id = 6, QMateria = "INGLES IV" };
                    Quintos.Add(QuintoMTOM6);

                    NocturnoQuinto.ItemsSource = Quintos;

                    #endregion

                    #region Materias MTO 6C

                    Sextos = new List<Sexto>();

                    var SextoMTOM1 = new Sexto() { Id = 1, SxMateria = "INGENIERIA DE MATERIALES" };
                    Sextos.Add(SextoMTOM1);

                    var SextoMTOM2 = new Sexto() { Id = 2, SxMateria = "ELECTRONICA ANALOGICA" };
                    Sextos.Add(SextoMTOM2);

                    var SextoMTOM3 = new Sexto() { Id = 3, SxMateria = "MAQUINAS ELECTRICAS" };
                    Sextos.Add(SextoMTOM3);

                    var SextoMTOM4 = new Sexto() { Id = 4, SxMateria = "ELECTRONICA DIGITAL" };
                    Sextos.Add(SextoMTOM4);

                    var SextoMTOM5 = new Sexto() { Id = 5, SxMateria = "MANTENIMIENTO A PROCEDIMIENTOS DE MANUFACTURA" };
                    Sextos.Add(SextoMTOM3);

                    var SextoMTOM6 = new Sexto() { Id = 6, SxMateria = "INTEGRADORA II" };
                    Sextos.Add(SextoMTOM6);

                    var SextoMTOM7 = new Sexto() { Id = 7, SxMateria = "FORMACION SOCIOCULTURAL II" };
                    Sextos.Add(SextoMTOM7);

                    NocturnoSexto.ItemsSource = Sextos;

                    #endregion

                    #region Materias MTO 7C

                    Septimos = new List<Septimo>();

                    var SeptimoMTOM1 = new Septimo() { Id = 1, SepMateria = "MAQUINAS TERMICAS" };
                    Septimos.Add(SeptimoMTOM1);

                    var SeptimoMTOM2 = new Septimo() { Id = 2, SepMateria = "INSTALACIONES ELECTRICAS" };
                    Septimos.Add(SeptimoMTOM2);

                    var SeptimoMTOM3 = new Septimo() { Id = 3, SepMateria = "AUTOMATIZACION  Y ROBOTICA" };
                    Septimos.Add(SeptimoMTOM3);

                    var SeptimoMTOM4 = new Septimo() { Id = 4, SepMateria = "INGLES V" };
                    Septimos.Add(SeptimoMTOM4);

                    var SeptimoMTOM5 = new Septimo() { Id = 5, SepMateria = "EXPRESION ORAL Y ESCRITA II" };
                    Septimos.Add(SeptimoMTOM5);

                    var SeptimoMTOM6 = new Septimo() { Id = 6, SepMateria = "FORMACION SOCIOCULTURAL IV" };
                    Septimos.Add(SeptimoMTOM6);

                    NocturnoSeptimo.ItemsSource = Septimos;

                    #endregion

                    #region Estadia

                    Octavos = new List<Octavo>();

                    var OctavoMTOEstadia = new Octavo() { Id = 1, OcMateria = "ESTADIA" };
                    Octavos.Add(OctavoMTOEstadia);

                    NocturnoOctavo.ItemsSource = Octavos;

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

                    var primeroMECAM3 = new Primero() { Id = 3, PMateria = "HERRAMIENTAS INFORMATICAS 4.0" };
                    primeros.Add(primeroMECAM3);

                    var primeroMECAM4 = new Primero() { Id = 4, PMateria = "ELEMENTOS DIMENSIONALES" };
                    primeros.Add(primeroMECAM4);

                    var primeroMECAM5 = new Primero() { Id = 5, PMateria = "EXPRESIÓN ORAL Y ESCRITA I" };
                    primeros.Add(primeroMECAM5);

                    var primeroMECAM6 = new Primero() { Id = 6, PMateria = "FORMACIÓN SOCIOCULTURAL I" };
                    primeros.Add(primeroMECAM6);

                    NocturnoPrimero.ItemsSource = primeros;

                    #endregion

                    #region Materias MECA 2C

                    Segundos = new List<Segundo>();

                    var SegundoMECAM1 = new Segundo() { Id = 1, SMateria = "FUNCIONES MATEMATICAS" };
                    Segundos.Add(SegundoMECAM1);

                    var SegundoMECAM2 = new Segundo() { Id = 2, SMateria = "QUIMICA BASICA" };
                    Segundos.Add(SegundoMECAM2);

                    var SegundoMECAM3 = new Segundo() { Id = 3, SMateria = "ELECTRICIDAD Y MAGNETISMO" };
                    Segundos.Add(SegundoMECAM3);

                    var SegundoMECAM4 = new Segundo() { Id = 4, SMateria = "CIRCUITOS ELÉCTRICOS" };
                    Segundos.Add(SegundoMECAM4);

                    var SegundoMECAM5 = new Segundo() { Id = 5, SMateria = "PROCESOS PRODUCTIVOS" };
                    Segundos.Add(SegundoMECAM5);

                    var SegundoMECAM6 = new Segundo() { Id = 6, SMateria = "SISTEMAS MECÁNICOS I" };
                    Segundos.Add(SegundoMECAM6);

                    var SegundoMECAM7 = new Segundo() { Id = 7, SMateria = "FORMACIÓN SOCIOCULTURAL I" };
                    Segundos.Add(SegundoMECAM7);

                    

                    NocturnoSegundo.ItemsSource = Segundos;

                    #endregion

                    #region Materias MECA 3C

                    Terceros = new List<Tercero>();

                    var TerceroMECAM1 = new Tercero() { Id = 1, TMateria = "CALCULDO DIFERENCIAL" };
                    Terceros.Add(TerceroMECAM1);

                    var TerceroMECAM2 = new Tercero() { Id = 2, TMateria = "PROBABILIDAD Y ESTADISTICAS" };
                    Terceros.Add(TerceroMECAM2);

                    var TerceroMECAM3 = new Tercero() { Id = 3, TMateria = "TERMODINAMICA" };
                    Terceros.Add(TerceroMECAM3);

                    var TerceroMECAM4 = new Tercero() { Id = 4, TMateria = "SISTEMAS HIDRÁULICOS Y NEUMÁTICOS" };
                    Terceros.Add(TerceroMECAM4);

                    var TerceroMECAM5 = new Tercero() { Id = 5, TMateria = "INGLÉS I" };
                    Terceros.Add(TerceroMECAM5);

                    var TerceroMECAM6 = new Tercero() { Id = 6, TMateria = "FORMACIÓN SOCIOCULTURAL III" };
                    Terceros.Add(TerceroMECAM6);

                    

                    NocturnoTercero.ItemsSource = Terceros;

                    #endregion

                    #region Materias MECA 4C

                    Cuartos = new List<Cuarto>();

                    var CuartoMECAM1 = new Cuarto() { Id = 1, CMateria = "CALCULO INTEGRAL" };
                    Cuartos.Add(CuartoMECAM1);

                    var CuartoMECAM2 = new Cuarto() { Id = 2, CMateria = "ELECTRÓNICA DIGITAL" };
                    Cuartos.Add(CuartoMECAM2);

                    var CuartoMECAM3 = new Cuarto() { Id = 3, CMateria = "CONTROL DE MOTORES I" };
                    Cuartos.Add(CuartoMECAM3);

                    var CuartoMECAM4 = new Cuarto() { Id = 4, CMateria = "CONTROLADORES LÓGICOS PROGRAMABLES" };
                    Cuartos.Add(CuartoMECAM4);

                    var CuartoMECAM5 = new Cuarto() { Id = 5, CMateria = "INGLÉS II" };
                    Cuartos.Add(CuartoMECAM5);

                    var CuartoMECAM6 = new Cuarto() { Id = 6, CMateria = "FORMACIÓN SOCIOCULTURAL IV" };
                    Cuartos.Add(CuartoMECAM6);


                    NocturnoCuarto.ItemsSource = Cuartos;

                    #endregion

                    #region  Materias MECA 5C

                    Quintos = new List<Quinto>();

                    var QuintoMECAM1 = new Quinto() { Id = 1, QMateria = "ANÁLISIS DE CIRCUITOS ELÉCTRICOS" };
                    Quintos.Add(QuintoMECAM1);

                    var QuintoMECAM2 = new Quinto() { Id = 2, QMateria = "ELECTRÓNICA ANÁLOGICA" };
                    Quintos.Add(QuintoMECAM2);

                    var QuintoMECAM3 = new Quinto() { Id = 3, QMateria = "LENGUAJE DE PROGRAMACIÓN" };
                    Quintos.Add(QuintoMECAM3);

                    var QuintoMECAM4 = new Quinto() { Id = 4, QMateria = "INSTRUMENTACIÓN INDUSTRIAL" };
                    Quintos.Add(QuintoMECAM4);

                    var QuintoMECAM5 = new Quinto() { Id = 5, QMateria = "INTEGRADORA I" };
                    Quintos.Add(QuintoMECAM5);

                    var QuintoMECAM6 = new Quinto() { Id = 6, QMateria = "INGLÉS III" };
                    Quintos.Add(QuintoMECAM6);

                    

                    NocturnoQuinto.ItemsSource = Quintos;

                    #endregion

                    #region Materias MECA 6C

                    Sextos = new List<Sexto>();

                    var SextoMECAM1 = new Sexto() { Id = 1, SxMateria = "ESTRUCTURA Y PROPIEDADES DE LOS MATERIALES" };
                    Sextos.Add(SextoMECAM1);

                    var SextoMECAM2 = new Sexto() { Id = 2, SxMateria = "PROGRAMACIÓN VISUAL" };
                    Sextos.Add(SextoMECAM2);

                    var SextoMECAM3 = new Sexto() { Id = 3, SxMateria = "DISPOSITIVOS DIGITALES" };
                    Sextos.Add(SextoMECAM3);

                    var SextoMECAM4 = new Sexto() { Id = 4, SxMateria = "MICROCONTROLADORES" };
                    Sextos.Add(SextoMECAM4);

                    var SextoMECAM5 = new Sexto() { Id = 5, SxMateria = "DISPOSITIVOS ANALÓGICOS" };
                    Sextos.Add(SextoMECAM5);

                    var SextoMECAM6 = new Sexto() { Id = 6, SxMateria = "INGLÉS IV" };
                    Sextos.Add(SextoMECAM6);

                    NocturnoSexto.ItemsSource = Sextos;

                    #endregion

                    #region Materias Meca 7C

                    Septimos = new List<Septimo>();

                    var SeptimoMECAM1 = new Septimo() { Id = 1, SepMateria = "FUNDAMENTOS DE INSTRUMENTACIÓN VIRTUAL" };
                    Septimos.Add(SeptimoMECAM1);

                    var SeptimoMECAM2 = new Septimo() { Id = 2, SepMateria = "INTEGRACIÓN DE SISTEMAS AUTOMÁTICOS" };
                    Septimos.Add(SeptimoMECAM2);

                    var SeptimoMECAM3 = new Septimo() { Id = 3, SepMateria = "SISTEMAS DE CONTROL" };
                    Septimos.Add(SeptimoMECAM3);

                    var SeptimoMECAM4 = new Septimo() { Id = 4, SepMateria = "INTEGRADORA II" };
                    Septimos.Add(SeptimoMECAM4);

                    var SeptimoMECAM5 = new Septimo() { Id = 5, SepMateria = "INGLÉS V" };
                    Septimos.Add(SeptimoMECAM5);

                    var SeptimoMECAM6 = new Septimo() { Id = 6, SepMateria = "EXPRESIÓN ORAL Y ESCRITA II" };
                    Septimos.Add(SeptimoMECAM6);


                    NocturnoSeptimo.ItemsSource = Septimos;

                    #endregion

                    #region Estadia

                    Octavos = new List<Octavo>();

                    var OctavoMECAEstadia = new Octavo() { Id = 1, OcMateria = "ESTADIA" };
                    Octavos.Add(OctavoMECAEstadia);

                    NocturnoOctavo.ItemsSource = Octavos;

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

                    var primeroERM2 = new Primero() { Id = 2, PMateria = "ELECTRICIDAD Y MAGNETISMO" };
                    primeros.Add(primeroERM2);

                    var primeroERM3 = new Primero() { Id = 3, PMateria = "DESARROLLO SUSTENTABLE" };
                    primeros.Add(primeroERM3);

                    var primeroERM4 = new Primero() { Id = 4, PMateria = "INFORMÁTICA" };
                    primeros.Add(primeroERM4);

                    var primeroERM5 = new Primero() { Id = 5, PMateria = "NGLÉS I" };
                    primeros.Add(primeroERM5);

                    var primeroERM6 = new Primero() { Id = 6, PMateria = "EXPRESIÓN ORAL Y ESCRITA I" };
                    primeros.Add(primeroERM6);

                    var primeroERM7 = new Primero() { Id = 7, PMateria = "FORMACIÓN SOCIOCULTURAL I" };
                    primeros.Add(primeroERM7);

                    

                    NocturnoPrimero.ItemsSource = primeros;

                    #endregion

                    #region Materias Energias Renovables 2C

                    Segundos = new List<Segundo>();

                    var SegundoERM1 = new Segundo() { Id = 1, SMateria = "ÁLGEBRA LINEAL" };
                    Segundos.Add(SegundoERM1);

                    var SegundoERM2 = new Segundo() { Id = 2, SMateria = "QUÍMICA BÁSICA" };
                    Segundos.Add(SegundoERM2);

                    var SegundoERM3 = new Segundo() { Id = 3, SMateria = "FÍSICA" };
                    Segundos.Add(SegundoERM3);

                    var SegundoERM4 = new Segundo() { Id = 4, SMateria = "CIRCUITOS ELÉCTRICOS" };
                    Segundos.Add(SegundoERM4);

                    var SegundoERM5 = new Segundo() { Id = 5, SMateria = "INGLÉS II" };
                    Segundos.Add(SegundoERM5);

                    var SegundoERM6 = new Segundo() { Id = 6, SMateria = "FORMACIÓN SOCIOCULTURAL II" };
                    Segundos.Add(SegundoERM6);

                    

                    NocturnoSegundo.ItemsSource = Segundos;

                    #endregion

                    #region Materias Energias Renovables 3C

                    Terceros = new List<Tercero>();

                    var TerceroEnergiaRMateria1 = new Tercero() { Id = 1, TMateria = "FUNCIONES MATEMÁTICAS" };
                    Terceros.Add(TerceroEnergiaRMateria1);

                    var TerceroEnergiaRMateria2 = new Tercero() { Id = 2, TMateria = "TERMODINÁMICA" };
                    Terceros.Add(TerceroEnergiaRMateria2);

                    var TerceroEnergiaRMateria3 = new Tercero() { Id = 3, TMateria = "INSTALACIONES ELÉCTRICAS" };
                    Terceros.Add(TerceroEnergiaRMateria3);

                    var TerceroEnergiaRMateria4 = new Tercero() { Id = 4, TMateria = "ELECTRÓNICA INDUSTRIAL" };
                    Terceros.Add(TerceroEnergiaRMateria4);

                    var TerceroEnergiaRMateria5 = new Tercero() { Id = 5, TMateria = "INGLÉS III" };
                    Terceros.Add(TerceroEnergiaRMateria5);

                    var TerceroEnergiaRMateria6 = new Tercero() { Id = 6, TMateria = "FORMACIÓN SOCIOCULTURAL III" };
                    Terceros.Add(TerceroEnergiaRMateria6);

                   

                    NocturnoTercero.ItemsSource = Terceros;

                    #endregion

                    #region Materias Energias Renovables 4C

                    Cuartos = new List<Cuarto>();

                    var CuartoEnergiaRMateria1 = new Cuarto() { Id = 1, CMateria = "CÁLCULO DIFERENCIAL" };
                    Cuartos.Add(CuartoEnergiaRMateria1);

                    var CuartoEnergiaRMateria2 = new Cuarto() { Id = 2, CMateria = "FISICOQUÍMICA" };
                    Cuartos.Add(CuartoEnergiaRMateria2);

                    var CuartoEnergiaRMateria3 = new Cuarto() { Id = 3, CMateria = "INSTRUMENTACIÓN INDUSTRIAL" };
                    Cuartos.Add(CuartoEnergiaRMateria3);

                    var CuartoEnergiaRMateria4 = new Cuarto() { Id = 4, CMateria = "MANTENIMIENTO ELECTROMECÁNICO" };
                    Cuartos.Add(CuartoEnergiaRMateria4);

                    var CuartoEnergiaRMateria5 = new Cuarto() { Id = 5, CMateria = "MECÁNICA INDUSTRIAL" };
                    Cuartos.Add(CuartoEnergiaRMateria5);

                    var CuartoEnergiaRMateria6 = new Cuarto() { Id = 6, CMateria = "INGLÉS IV" };
                    Cuartos.Add(CuartoEnergiaRMateria6);

                    

                    NocturnoCuarto.ItemsSource = Cuartos;

                    #endregion

                    #region Materias Energias Renovables 5C

                    Quintos = new List<Quinto>();

                    var QuintoEnergiaRMateria1 = new Quinto() { Id = 1, QMateria = "CÁLCULO INTEGRAL" };
                    Quintos.Add(QuintoEnergiaRMateria1);

                    var QuintoEnergiaRMateria2 = new Quinto() { Id = 2, QMateria = "ESTRUCTURA Y PROPIEDADES DE LOS MATERIALES" };
                    Quintos.Add(QuintoEnergiaRMateria2);

                    var QuintoEnergiaRMateria3 = new Quinto() { Id = 3, QMateria = "ENERGÍAS RENOVABLES" };
                    Quintos.Add(QuintoEnergiaRMateria3);

                    var QuintoEnergiaRMateria4 = new Quinto() { Id = 4, QMateria = "FORMULACIÓN DE PROYECTOS" };
                    Quintos.Add(QuintoEnergiaRMateria4);

                    var QuintoEnergiaRMateria5 = new Quinto() { Id = 5, QMateria = "CALIDAD" };
                    Quintos.Add(QuintoEnergiaRMateria5);

                    var QuintoEnergiaRMateria6 = new Quinto() { Id = 6, QMateria = "INTEGRADORA II" };
                    Quintos.Add(QuintoEnergiaRMateria6);

                    var QuintoEnergiaRMateria7 = new Quinto() { Id = 7, QMateria = "INGLÉS IV" };
                    Quintos.Add(QuintoEnergiaRMateria7);

                   

                    NocturnoQuinto.ItemsSource = Quintos;

                    #endregion

                    #region Materias Energias Renovables 6C

                    Sextos = new List<Sexto>();

                    var SextoEnergiaRMateria1 = new Sexto() { Id = 1, SxMateria = "FISICOQUÍMICA APLICADA" };
                    Sextos.Add(SextoEnergiaRMateria1);

                    var SextoEnergiaRMateria2 = new Sexto() { Id = 2, SxMateria = "DIBUJO INDUSTRIAL" };
                    Sextos.Add(SextoEnergiaRMateria2);

                    var SextoEnergiaRMateria3 = new Sexto() { Id = 3, SxMateria = "COLECTORES SOLARES" };
                    Sextos.Add(SextoEnergiaRMateria3);

                    var SextoEnergiaRMateria4 = new Sexto() { Id = 4, SxMateria = "ESTACIONES METEOROLÓGICAS" };
                    Sextos.Add(SextoEnergiaRMateria4);

                    var SextoEnergiaRMateria5 = new Sexto() { Id = 5, SxMateria = "PROCESOS INDUSTRIALES" };
                    Sextos.Add(SextoEnergiaRMateria5);

                    var SextoEnergiaRMateria6 = new Sexto() { Id = 6, SxMateria = "FORMACIÓN SOCIOCULTURAL IV" };
                    Sextos.Add(SextoEnergiaRMateria6);

                    NocturnoSexto.ItemsSource = Sextos;

                    #endregion

                    #region Materias Energias Renovables 7C
                    Septimos = new List<Septimo>();

                    var SeptimoEnergiaRMateria1 = new Septimo() { Id = 1, SepMateria = "SEGURIDAD INDUSTRIAL" };
                    Septimos.Add(SeptimoEnergiaRMateria1);

                    var SeptimoEnergiaRMateria2 = new Septimo() { Id = 2, SepMateria = "CELDAS FOTOVOLTÁICAS" };
                    Septimos.Add(SeptimoEnergiaRMateria2);

                    var SeptimoEnergiaRMateria3 = new Septimo() { Id = 3, SepMateria = "ELECTRÓNICA DE POTENCIA" };
                    Septimos.Add(SeptimoEnergiaRMateria3);

                    var SeptimoEnergiaRMateria4 = new Septimo() { Id = 4, SepMateria = "ADMINISTRACIÓN DE PROYECTOS" };
                    Septimos.Add(SeptimoEnergiaRMateria4);

                    var SeptimoEnergiaRMateria5 = new Septimo() { Id = 5, SepMateria = "ADQUISICIÓN DE DATOS" };
                    Septimos.Add(SeptimoEnergiaRMateria5);

                    var SeptimoEnergiaRMateria6 = new Septimo() { Id = 6, SepMateria = "INTEGRADORA II" };
                    Septimos.Add(SeptimoEnergiaRMateria6);

                    var SeptimoEnergiaRMateria7 = new Septimo() { Id = 7, SepMateria = "EXPRESIÓN ORAL Y ESCRITA II" };
                    Septimos.Add(SeptimoEnergiaRMateria7);

                    NocturnoSeptimo.ItemsSource = Septimos;

                    #endregion

                    #region Estadia

                    Octavos = new List<Octavo>();

                    var OctavoEREstadias = new Octavo() { Id = 1, OcMateria = "ESTADIA" };
                    Octavos.Add(OctavoEREstadias);

                    NocturnoOctavo.ItemsSource = Octavos;

                    #endregion

                    break;

                #endregion

                #region case 6

                case 6:

                    //TECNOLOGIAS DE LA INFORMACION AREA DESARROLL MULTIPLATAFORMA

                    #region Primer Cuatrimestre

                    primeros = new List<Primero>();

                    var TidmMateria1 = new Primero() { Id = 1, PMateria = "DESARROLLO DE HABILIDADES DE PENSAMIENTO LOGICO" };
                    primeros.Add(TidmMateria1);

                    var TidmMateria2 = new Primero() { Id = 2, PMateria = "FUNDAMENTOS DE TI" };
                    primeros.Add(TidmMateria2);

                    var TidmMatetria3 = new Primero() { Id = 3, PMateria = "METODOLOGIA DE LA PROGRAMACION" };
                    primeros.Add(TidmMatetria3);

                    var TidmMateria4 = new Primero() { Id = 4, PMateria = "EXPRESIÓN ORAL Y ESCRITA I" };
                    primeros.Add(TidmMateria4);

                    var TidmMateria5 = new Primero() { Id = 5, PMateria = "INGLÉS I" };
                    primeros.Add(TidmMateria5);

                    var TidmMateria6 = new Primero() { Id = 6, PMateria = "FORMACIÓN SOCIOCULTURAL I" };
                    primeros.Add(TidmMateria6);


                    NocturnoPrimero.ItemsSource = primeros;

                    #endregion

                    #region Sgundo Cuatrimestres

                    Segundos = new List<Segundo>();

                    var SengundoTidmM1 = new Segundo() { Id = 1, SMateria = "ALGEBRA LINEAL" };
                    Segundos.Add(SengundoTidmM1);

                    var SengundoTidmM2 = new Segundo() { Id = 2, SMateria = "FUNDAMENTOS DE REDES" };
                    Segundos.Add(SengundoTidmM2);

                    var SengundoTidmM3 = new Segundo() { Id = 3, SMateria = "METODOLOGIAS Y MODELADOS DE DESARROLLO DE SOFTWARE" };
                    Segundos.Add(SengundoTidmM3);

                    var SengundoTidmM4 = new Segundo() { Id = 4, SMateria = "PROGRAMACIÓN ORIENTADA A OBJETOS" };
                    Segundos.Add(SengundoTidmM4);

                    var SengundoTidmM5 = new Segundo() { Id = 5, SMateria = "FORMACIÓN SOCIOCULTURAL II" };
                    Segundos.Add(SengundoTidmM5);


                    NocturnoSegundo.ItemsSource = Segundos;

                    #endregion

                    #region Tercer Cuatrimestre

                    Terceros = new List<Tercero>();

                    var TerceroTidmM1 = new Tercero() { Id = 1, TMateria = "FUNCIONES MATEMATICAS" };
                    Terceros.Add(TerceroTidmM1);

                    var TerceroTidmM2 = new Tercero() { Id = 2, TMateria = "INTERCONEXION DE REDES" };
                    Terceros.Add(TerceroTidmM2);

                    var TerceroTidmM3 = new Tercero() { Id = 3, TMateria = "INTRODUCCION DISEÑO DIGITAL" };
                    Terceros.Add(TerceroTidmM3);

                    var TerceroTidmM4 = new Tercero() { Id = 4, TMateria = "BASE DE DATOS" };
                    Terceros.Add(TerceroTidmM4);

                    var TerceroTidmM5 = new Tercero() { Id = 5, TMateria = "INGLES II" };
                    Terceros.Add(TerceroTidmM5);

                    var TerceroTidmM6 = new Tercero() { Id = 6, TMateria = "INTEGRADORA I" };
                    Terceros.Add(TerceroTidmM6);

                    var TerceroTidmM7 = new Tercero() { Id = 7, TMateria = "FORMACIÓN SOCIOCULTURAL III" };
                    Terceros.Add(TerceroTidmM7);

                 
                    NocturnoTercero.ItemsSource = Terceros;

                    #endregion

                    #region Cuarto Cuatrimestre

                    Cuartos = new List<Cuarto>();

                    var CuartoTidmM1 = new Cuarto() { Id = 1, CMateria = "CÁLCULO DIFERENCIAL" };
                    Cuartos.Add(CuartoTidmM1);

                    var CuartoTidmM2 = new Cuarto() { Id = 2, CMateria = "SISTEMAS OPERATIVOS " };
                    Cuartos.Add(CuartoTidmM2);

                    var CuartoTidmM3 = new Cuarto() { Id = 3, CMateria = "APLICACIONES WEB" };
                    Cuartos.Add(CuartoTidmM3);

                    var CuartoTidmM4 = new Cuarto() { Id = 4, CMateria = "BASE DE DATOS PARA APLICACIONES" };
                    Cuartos.Add(CuartoTidmM4);

                    var CuartoTidmM5 = new Cuarto() { Id = 5, CMateria = "INGLÉS III" };
                    Cuartos.Add(CuartoTidmM5);

   

                    NocturnoCuarto.ItemsSource = Cuartos;

                    #endregion

                    #region Quinto Cuatrimestre

                    Quintos = new List<Quinto>();

                    var QuintoTidmM1 = new Quinto() { Id = 1, QMateria = "ESTÁNDARES Y MÉTRICAS PARA EL DESARROLLO DE SOFTWARE" };
                    Quintos.Add(QuintoTidmM1);

                    var QuintoTidmM2 = new Quinto() { Id = 2, QMateria = "PRINCIPIOS PARA IOT " };
                    Quintos.Add(QuintoTidmM2);

                    var QuintoTidmM3 = new Quinto() { Id = 3, QMateria = "DISEÑO DE APPS" };
                    Quintos.Add(QuintoTidmM3);

                    var QuintoTidmM4 = new Quinto() { Id = 4, QMateria = "APLICACIONES WEB ORIENTADAS A SERVICIOS " };
                    Quintos.Add(QuintoTidmM4);

                    var QuintoTidmM5 = new Quinto() { Id = 5, QMateria = "EVALUACIÓN Y MEJORA PARA EL DESARROLLO DE SOFTWARE" };
                    Quintos.Add(QuintoTidmM5);

                    var QuintoTidmM6 = new Quinto() { Id = 6, QMateria = "INGLÉS IV" };
                    Quintos.Add(QuintoTidmM6);

                    

                    NocturnoQuinto.ItemsSource = Quintos;

                    #endregion

                    #region Sexto Cuatrimestre

                    Sextos = new List<Sexto>();

                    var SextoTidmM1 = new Sexto() { Id = 1, SxMateria = "PROBABILIDAD Y ESTADÍSTICA" };
                    Sextos.Add(SextoTidmM1);

                    var SextoTidmM2 = new Sexto() { Id = 2, SxMateria = "ESTRUCTURA DE DATOS" };
                    Sextos.Add(SextoTidmM2);

                    var SextoTidmM3 = new Sexto() { Id = 3, SxMateria = "FORMACIÓN SOCIOCULTURAL IV " };
                    Sextos.Add(SextoTidmM3);

                    var SextoTidmM4 = new Sexto() { Id = 4, SxMateria = "APLICACIONES WEB PARA I4.0 " };
                    Sextos.Add(SextoTidmM4);

                    var SextoTidmM5 = new Sexto() { Id = 5, SxMateria = "EXPRESIÓN ORAL Y ESCRITA II " };
                    Sextos.Add(SextoTidmM5);


                    NocturnoSexto.ItemsSource = Sextos;

                    #endregion

                    #region Septimo Cuatrimestre

                    Septimos = new List<Septimo>();

                    var SeptimoTidmM1 = new Septimo() { Id = 1, SepMateria = "APLICACIONES DE IOT " };
                    Septimos.Add(SeptimoTidmM1);

                    var SeptimoTidmM2 = new Septimo() { Id = 2, SepMateria = "DESARROLLO MÓVIL MULTIPLATAFORMA" };
                    Septimos.Add(SeptimoTidmM2);

                    var SeptimoTidmM3 = new Septimo() { Id = 3, SepMateria = "INTEGRADORA II" };
                    Septimos.Add(SeptimoTidmM3);

                    var SeptimoTidmM4 = new Septimo() { Id = 4, SepMateria = "BASES DE DATOS PARA CÓMPUTO EN LA NUBE" };
                    Septimos.Add(SeptimoTidmM4);

                    var SeptimoTidmM5 = new Septimo() { Id = 5, SepMateria = "INGLÉS V" };
                    Septimos.Add(SeptimoTidmM5);

                    NocturnoSeptimo.ItemsSource = Septimos;

                    #endregion

                    #region Estadia

                    Octavos = new List<Octavo>();

                    var OctavoTidmEstadias = new Octavo() { Id = 1, OcMateria = "ESTADIA" };
                    Octavos.Add(OctavoTidmEstadias);

                    NocturnoOctavo.ItemsSource = Octavos;

                    #endregion

                    break;

                #endregion

                #region case 7

                case 7:

                    //NANO

                    Grid.IsEnabled = false;
                    Grid.IsVisible = false;

                    NOC.IsVisible = true;
                    NOC.IsEnabled = true;  

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

                    var PrimeroMercaM3 = new Primero() { Id = 3, PMateria = "MERCADOTECNIA" };
                    primeros.Add(PrimeroMercaM3);

                    var PrimeroMercaM4 = new Primero() { Id = 4, PMateria = "INGLÉS I" };
                    primeros.Add(PrimeroMercaM4);

                    var PrimeroMercaM5 = new Primero() { Id = 5, PMateria = "EXPRESION ORAL Y ESCRITA I" };
                    primeros.Add(PrimeroMercaM5);

                    var PrimeroMercaM6 = new Primero() { Id = 6, PMateria = "FORMACIÓN SOCIOCULTURAL I" };
                    primeros.Add(PrimeroMercaM6);

                    NocturnoPrimero.ItemsSource = primeros;

                    #endregion

                    #region Segundo cuatrimestre

                    Segundos = new List<Segundo>();

                    var SegundoMercaM1 = new Segundo() { Id = 1, SMateria = "CONTABILIDAD" };
                    Segundos.Add(SegundoMercaM1);

                    var SegundoMercaM2 = new Segundo() { Id = 2, SMateria = "INFORMATICA I" };
                    Segundos.Add(SegundoMercaM2);

                    var SegundoMercaM3 = new Segundo() { Id = 3, SMateria = "CALIDAD" };
                    Segundos.Add(SegundoMercaM3);

                    var SegundoMercaM4 = new Segundo() { Id = 4, SMateria = "VENTAS" };
                    Segundos.Add(SegundoMercaM4);

                    var SegundoMercaM5 = new Segundo() { Id = 5, SMateria = "INGLÉS II" };
                    Segundos.Add(SegundoMercaM5);

                    var SegundoMercaM6 = new Segundo() { Id = 6, SMateria = "FORMACIÓN SOCIOCULTURAL II" };
                    Segundos.Add(SegundoMercaM6);

                    NocturnoSegundo.ItemsSource = Segundos;

                    #endregion

                    #region Tercer Cuatrimestre

                    Terceros = new List<Tercero>();

                    var TercerMercaM1 = new Tercero() { Id = 1, TMateria = "ESTADÍSTICA" };
                    Terceros.Add(TercerMercaM1);

                    var TercerMercaM2 = new Tercero() { Id = 2, TMateria = "INFORMÁTICA II" };
                    Terceros.Add(TercerMercaM2);

                    var TercerMercaM3 = new Tercero() { Id = 3, TMateria = "ECONOMÍA" };
                    Terceros.Add(TercerMercaM3);

                    var TercerMercaM4 = new Tercero() { Id = 4, TMateria = "SISTEMA DE INVESTIGACIÓN DE MERCADOS I" };
                    Terceros.Add(TercerMercaM4);

                    var TercerMercaM5 = new Tercero() { Id = 5, TMateria = "LEGISLACIÓN COMERCIAL" };
                    Terceros.Add(TercerMercaM5);

                    NocturnoTercero.ItemsSource = Terceros;

                    #endregion

                    #region Cuarto Cautrimestre

                    Cuartos = new List<Cuarto>();

                    var CuartoMercaM1 = new Cuarto() { Id = 1, CMateria = "COMPORTAMIENTO DEL CONUSMIDOR" };
                    Cuartos.Add(CuartoMercaM1);

                    var CuartoMercaM2 = new Cuarto() { Id = 2, CMateria = "SISTEMA DE INVESTIGACIÓN DE MERCADOS II" };
                    Cuartos.Add(CuartoMercaM2);

                    var CuartoMercaM3 = new Cuarto() { Id = 3, CMateria = "LOGÍSTICA Y DISTRIBUCIÓN" };
                    Cuartos.Add(CuartoMercaM3);

                    var CuartoMercaM4 = new Cuarto() { Id = 4, CMateria = "PLANEACIÓN ESTRATÉGICA" };
                    Cuartos.Add(CuartoMercaM4);

                    var CuartoMercaM5 = new Cuarto() { Id = 5, CMateria = "INGLÉS III" };
                    Cuartos.Add(CuartoMercaM5);

                    var CuartoMercaM6 = new Cuarto() { Id = 6, CMateria = "FORMACIÓN SOCIOCULTURAL III" };
                    Cuartos.Add(CuartoMercaM6);

                    NocturnoCuarto.ItemsSource = Cuartos;

                    #endregion

                    #region Quinto cuatrimestre

                    Quintos = new List<Quinto>();

                    var QuintoMercaM1 = new Quinto() { Id = 1, QMateria = "ESTRATEGIAS DE PRECIO" };
                    Quintos.Add(QuintoMercaM1);

                    var QuintoMercaM2 = new Quinto() { Id = 2, QMateria = "GESTIÓN DE PROYECTOS" };
                    Quintos.Add(QuintoMercaM2);

                    var QuintoMercaM3 = new Quinto() { Id = 3, QMateria = "MEZCLA PROMOCIONAL I" };
                    Quintos.Add(QuintoMercaM3);

                    var QuintoMercaM4 = new Quinto() { Id = 4, QMateria = "INTEGRADORA I" };
                    Quintos.Add(QuintoMercaM4);

                    var QuintoMercaM5 = new Quinto() { Id = 5, QMateria = "INGLÉS IV" };
                    Quintos.Add(QuintoMercaM5);

                    var QuintoMercaM6 = new Quinto() { Id = 6, QMateria = "FORMACIÓN SOCIOCULTURAL IV" };
                    Quintos.Add(QuintoMercaM6);

                    

                    NocturnoQuinto.ItemsSource = Quintos;

                    #endregion

                    #region Sexto Cuatrimestre

                    Sextos = new List<Sexto>();

                    var SextoMercaMi1 = new Sexto() { Id = 1, SxMateria = "ESTRATEGIAS DE PRODUCTO" };
                    Sextos.Add(SextoMercaMi1);

                    var SextoMercaMi2 = new Sexto() { Id = 2, SxMateria = "METODOLOGÍA DE LA INVESTIGACIÓN" };
                    Sextos.Add(SextoMercaMi2);

                    var SextoMercaMi3 = new Sexto() { Id = 3, SxMateria = "DISEÑO GRÁFICO" };
                    Sextos.Add(SextoMercaMi3);

                    var SextoMercaMi4 = new Sexto() { Id = 4, SxMateria = "MERCADOTECNIA DIGITAL" };
                    Sextos.Add(SextoMercaMi4);

                    var SextoMercaMi5 = new Sexto() { Id = 5, SxMateria = "INGLÉS V" };
                    Sextos.Add(SextoMercaMi5);

                    NocturnoSexto.ItemsSource = Sextos;

                    #endregion

                    #region Septimo Cuatrimestre

                    Septimos = new List<Septimo>();

                    var SeptimoMercaMi1 = new Septimo() { Id = 1, SepMateria = "MERCADOTECNIA ESTRATÉGICA" };
                    Septimos.Add(SeptimoMercaMi1);

                    var SeptimoMercaMi2 = new Septimo() { Id = 2, SepMateria = "MERCADOTECNIA INTERNACIONAL" };
                    Septimos.Add(SeptimoMercaMi2);

                    var SeptimoMercaMi3 = new Septimo() { Id = 3, SepMateria = "MEZCLA PROMOCIONAL II" };
                    Septimos.Add(SeptimoMercaMi3);

                    var SeptimoMercaMi4 = new Septimo() { Id = 4, SepMateria = "INTEGRADORA II" };
                    Septimos.Add(SeptimoMercaMi4);

                    var SeptimoMercaMi5 = new Septimo() { Id = 5, SepMateria = "EXPRESIÓN ORAL Y ESCRITA II" };
                    Septimos.Add(SeptimoMercaMi5);

                    NocturnoSeptimo.ItemsSource = Septimos;

                    #endregion

                    #region Estadia

                    Octavos = new List<Octavo>();

                    var OctavoMercaEstadias = new Octavo() { Id = 1, OcMateria = "ESTADIA" };
                    Octavos.Add(OctavoMercaEstadias);

                    NocturnoOctavo.ItemsSource = Octavos;

                    #endregion

                    break;

                #endregion

                #region Case 9

                case 9:

                    //Ventas

                    Grid.IsEnabled = false;
                    Grid.IsVisible = false;

                    NOC.IsVisible = true;
                    NOC.IsEnabled = true; 

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

                    var PrimeroLogisticaM4 = new Primero() { Id = 4, PMateria = "INFORMATICA" };
                    primeros.Add(PrimeroLogisticaM4);

                    var PrimeroLogisticaM5 = new Primero() { Id = 5, PMateria = "INGLES I" };
                    primeros.Add(PrimeroLogisticaM5);

                    var PrimeroLogisticaM6 = new Primero() { Id = 6, PMateria = "EXPRESIÓN ORAL Y ESCRITA I" };
                    primeros.Add(PrimeroLogisticaM6);

                    NocturnoPrimero.ItemsSource = primeros;

                    #endregion

                    #region Segundo Cuaitrimestre

                    Segundos = new List<Segundo>();

                    var SegundoLogisticaM1 = new Segundo() { Id = 1, SMateria = "MODELOS MATEMATICOS" };
                    Segundos.Add(SegundoLogisticaM1);

                    var SegundoLogisticaM2 = new Segundo() { Id = 2, SMateria = "LOGISTICA" };
                    Segundos.Add(SegundoLogisticaM2);

                    var SegundoLogisticaM3 = new Segundo() { Id = 3, SMateria = "FUNDAMENTOS DE  ADMINISTRACIÓN" };
                    Segundos.Add(SegundoLogisticaM3);

                    var SegundoLogisticaM4 = new Segundo() { Id = 4, SMateria = "COMPRAS" };
                    Segundos.Add(SegundoLogisticaM4);

                    var SegundoLogisticaM5 = new Segundo() { Id = 5, SMateria = "FUNDAMENTOS DE INVENTARIOS" };
                    Segundos.Add(SegundoLogisticaM5);

                    var SegundoLogisticaM6 = new Segundo() { Id = 6, SMateria = "FORMACIÓN SOCIOCULTURAL I" };
                    Segundos.Add(SegundoLogisticaM6);


                    NocturnoSegundo.ItemsSource = Segundos;

                    #endregion

                    #region Tercer Cuatrimestre

                    Terceros = new List<Tercero>();

                    var TerceroLogisticaM1 = new Tercero() { Id = 1, TMateria = "ESTADISTICA" };
                    Terceros.Add(TerceroLogisticaM1);

                    var TerceroLogisticaM2 = new Tercero() { Id = 2, TMateria = "COSTO" };
                    Terceros.Add(TerceroLogisticaM2);

                    var TerceroLogisticaM3 = new Tercero() { Id = 3, TMateria = "MANEJO DE LA CARGA" };
                    Terceros.Add(TerceroLogisticaM3);

                    var TerceroLogisticaM4 = new Tercero() { Id = 4, TMateria = "FUNDAMENTOS DE COMERCIO  INTERNACIONAL" };
                    Terceros.Add(TerceroLogisticaM4);

                    var TerceroLogisticaM5 = new Tercero() { Id = 5, TMateria = "GESTION DE ALMACEN" };
                    Terceros.Add(TerceroLogisticaM5);

                    var TerceroLogisticaM6 = new Tercero() { Id = 6, TMateria = "INGLÉS II" };
                    Terceros.Add(TerceroLogisticaM6);

                    var TerceroLogisticaM7 = new Tercero() { Id = 7, TMateria = "FORMACIÓN SOCIOCULTURAL II" };
                    Terceros.Add(TerceroLogisticaM7);

                    
                    NocturnoTercero.ItemsSource = Terceros;

                    #endregion

                    #region Cuarto Cuatrimestre

                    Cuartos = new List<Cuarto>();

                    var CuartoLogisticaM1 = new Cuarto() { Id = 1, CMateria = "CONTROL DE INVENTARIOS" };
                    Cuartos.Add(CuartoLogisticaM1);

                    var CuartoLogisticaM2 = new Cuarto() { Id = 2, CMateria = "TRANSPORTE" };
                    Cuartos.Add(CuartoLogisticaM2);

                    var CuartoLogisticaM3 = new Cuarto() { Id = 3, CMateria = "TRÁFICO" };
                    Cuartos.Add(CuartoLogisticaM3);

                    var CuartoLogisticaM4 = new Cuarto() { Id = 4, CMateria = "PRESUPUESTOS" };
                    Cuartos.Add(CuartoLogisticaM4);

                    var CuartoLogisticaM5 = new Cuarto() { Id = 5, CMateria = "MARCO REGULATORIO DE COMERCIO INTERNACIONAL" };
                    Cuartos.Add(CuartoLogisticaM5);

                    var CuartoLogisticaM6 = new Cuarto() { Id = 6, CMateria = "INGLÉS III" };
                    Cuartos.Add(CuartoLogisticaM6);

                    var CuartoLogisticaM7 = new Cuarto() { Id = 7, CMateria = "FORMACIÓN SOCIOCULTURAL III" };
                    Cuartos.Add(CuartoLogisticaM7);

                    NocturnoCuarto.ItemsSource = Cuartos;

                    #endregion

                    #region Quinto Cuatrimestre

                    Quintos = new List<Quinto>();

                    var QuintoLogisticaM1 = new Quinto() { Id = 1, QMateria = "INDICADORES DE DESEMPEÑO" };
                    Quintos.Add(QuintoLogisticaM1);

                    var QuintoLogisticaM2 = new Quinto() { Id = 2, QMateria = "CALIDAD" };
                    Quintos.Add(QuintoLogisticaM2);

                    var QuintoLogisticaM3 = new Quinto() { Id = 3, QMateria = "INTEGRADORA I" };
                    Quintos.Add(QuintoLogisticaM3);

                    var QuintoLogisticaM4 = new Quinto() { Id = 4, QMateria = "INFRAESTRUCTURA LOGÍSTICA" };
                    Quintos.Add(QuintoLogisticaM4);

                    var QuintoLogisticaM5 = new Quinto() { Id = 5, QMateria = "ADMINISTRACIÓN DE MATERIALES DE LA PRODUCCIÓN" };
                    Quintos.Add(QuintoLogisticaM5);

                    var QuintoLogisticaM6 = new Quinto() { Id = 6, QMateria = "INGLES IV" };
                    Quintos.Add(QuintoLogisticaM6);

                    NocturnoQuinto.ItemsSource = Quintos;

                    #endregion

                    #region Sexto Cuatrimestre

                    Sextos = new List<Sexto>();

                    var SextoLogisticaM1 = new Sexto() { Id = 1, SxMateria = "ADMINISTRACIÓN DE INVENTARIOS DE LA CADENA DE SUMINISTROS" };
                    Sextos.Add(SextoLogisticaM1);

                    var SextoLogisticaM2 = new Sexto() { Id = 2, SxMateria = "GESTIÓN DE LA CADENA DE SUMINISTROS" };
                    Sextos.Add(SextoLogisticaM2);

                    var SextoLogisticaM3 = new Sexto() { Id = 3, SxMateria = "GESTIÓN DE LA CADENA DE SUMINISTROS" };
                    Sextos.Add(SextoLogisticaM3);

                    var SextoLogisticaM4 = new Sexto() { Id = 4, SxMateria = "GESTIÓN DE LA CADENA DE SUMINISTROS" };
                    Sextos.Add(SextoLogisticaM4);

                    var SextoLogisticaM5 = new Sexto() { Id = 5, SxMateria = "FORMACIÓN SOCIOCULTURAL IV" };
                    Sextos.Add(SextoLogisticaM5);

                    NocturnoSexto.ItemsSource = Sextos;

                    #endregion

                    #region Septimo Cuatrimestre

                    Septimos = new List<Septimo>();

                    var SeptimoLogisticaM1 = new Septimo() { Id = 1, SepMateria = "MATEMÁTICAS FINANCIERAS" };
                    Septimos.Add(SeptimoLogisticaM1);

                    var SeptimoLogisticaM2 = new Septimo() { Id = 2, SepMateria = "CALIDAD APLICADA" };
                    Septimos.Add(SeptimoLogisticaM2);

                    var SeptimoLogisticaM3 = new Septimo() { Id = 3, SepMateria = "REDES DE ABASTECIMIENTO" };
                    Septimos.Add(SeptimoLogisticaM3);

                    var SeptimoLogisticaM4 = new Septimo() { Id = 4, SepMateria = "INTEGRADORA II" };
                    Septimos.Add(SeptimoLogisticaM4);

                    var SeptimoLogisticaM5 = new Septimo() { Id = 5, SepMateria = "EMBALAJE Y ETIQUETADO" };
                    Septimos.Add(SeptimoLogisticaM5);

                    var SeptimoLogisticaM6 = new Septimo() { Id = 6, SepMateria = "INGLÉS V" };
                    Septimos.Add(SeptimoLogisticaM6);

                    NocturnoSeptimo.ItemsSource = Septimos;

                    #endregion

                    #region Estadias

                    Octavos = new List<Octavo>();

                    var OctavoLogisticaEstadias = new Octavo() { Id = 1, OcMateria = "ESTADIA" };
                    Octavos.Add(OctavoLogisticaEstadias);

                    NocturnoOctavo.ItemsSource = Octavos;

                    #endregion

                    break;

                    #endregion

            }

        }
    }
}