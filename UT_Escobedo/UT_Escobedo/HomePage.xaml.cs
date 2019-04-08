using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UT_Escobedo.Views.Becas;
using UT_Escobedo.Views.CalendarioEscolar;
using UT_Escobedo.Views.DirectorioEscolar;
using UT_Escobedo.Views.OfertaEducativa;
using UT_Escobedo.Views.Transporte;
using UT_Escobedo.Views.TuUniversidad;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UT_Escobedo
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class HomePage : ContentPage
	{

        public static new int bandera = 0;

        public HomePage()
        {

            InitializeComponent();

            bandera = 0;

            if (bandera == 0)
            {

                btnDirectorioEscolar.IsEnabled = true;
                btnCalendario.IsEnabled = true;
                btnOferta.IsEnabled = true;
                btnTransporte.IsEnabled = true;
                btnTuUniversidad.IsEnabled = true;
                btnBecas.IsEnabled = true;

            }

        }

        private void BtnBecas_Clicked(object sender, EventArgs e)
        {

            bandera = 1;

            btnBecas.IsEnabled = false;
            btnDirectorioEscolar.IsEnabled = false;
            btnCalendario.IsEnabled = false;
            btnOferta.IsEnabled = false;
            btnTransporte.IsEnabled = false;
            btnTuUniversidad.IsEnabled = false;

            var masterBecas = new MainPage()
            {

                Detail = new NavigationPage(new BecasPage())

            };

            NavigationPage.SetHasNavigationBar(masterBecas, false);

            Navigation.PushAsync(masterBecas);

        }

        private void BtnDirectorioEscolar_Clicked(object sender, EventArgs e)
        {

            bandera = 1;

            btnDirectorioEscolar.IsEnabled = false;
            btnCalendario.IsEnabled = false;
            btnOferta.IsEnabled = false;
            btnTransporte.IsEnabled = false;
            btnTuUniversidad.IsEnabled = false;
            btnBecas.IsEnabled = false;

            var masterDirectorio = new MainPage()
            {

                Detail = new NavigationPage(new DirectorioEscolarPage())

            };

            NavigationPage.SetHasNavigationBar(masterDirectorio, false);

            Navigation.PushAsync(masterDirectorio);

        }

        private void BtnTransporte_Clicked(object sender, EventArgs e)
        {

            bandera = 1;

            btnTransporte.IsEnabled = false;
            btnDirectorioEscolar.IsEnabled = false;
            btnCalendario.IsEnabled = false;
            btnOferta.IsEnabled = false;
            btnBecas.IsEnabled = false;
            btnTuUniversidad.IsEnabled = false;

            var masterTransporte = new MainPage()
            {

                Detail = new NavigationPage(new TransportePage())

            };

            NavigationPage.SetHasNavigationBar(masterTransporte, false);

            Navigation.PushAsync(masterTransporte);

            DisplayAlert("NOTA", "No olvides ir a comprar tus boletos.", "OK");

        }

        private void BtnOfertaEducativa_Clicked(object sender, EventArgs e)
        {

            bandera = 1;

            btnOferta.IsEnabled = false;
            btnDirectorioEscolar.IsEnabled = false;
            btnCalendario.IsEnabled = false;
            btnBecas.IsEnabled = false;
            btnTransporte.IsEnabled = false;
            btnTuUniversidad.IsEnabled = false;

            var masterOfertaE = new MainPage()
            {

                Detail = new NavigationPage(new Main())

            };

            NavigationPage.SetHasNavigationBar(masterOfertaE, false);

            Navigation.PushAsync(masterOfertaE);

        }

        private void BtnCalendario_Clicked(object sender, EventArgs e)
        {

            bandera = 1;

            btnCalendario.IsEnabled = false;
            btnDirectorioEscolar.IsEnabled = false;
            btnBecas.IsEnabled = false;
            btnOferta.IsEnabled = false;
            btnTransporte.IsEnabled = false;
            btnTuUniversidad.IsEnabled = false;

            var masterCalendario = new MainPage()
            {

                Detail = new NavigationPage(new CalendarioEscolarPage())

            };

            NavigationPage.SetHasNavigationBar(masterCalendario, false);

            Navigation.PushAsync(masterCalendario);

        }

        private void BtnTuUniversidad_Clicked(object sender, EventArgs e)
        {

            bandera = 1;

            btnTuUniversidad.IsEnabled = false;
            btnDirectorioEscolar.IsEnabled = false;
            btnCalendario.IsEnabled = false;
            btnOferta.IsEnabled = false;
            btnTransporte.IsEnabled = false;
            btnBecas.IsEnabled = false;

            var masterTuUniversidad = new MainPage()
            {

                Detail = new NavigationPage(new TuUniversidadPage())

            };

            NavigationPage.SetHasNavigationBar(masterTuUniversidad, false);

            Navigation.PushAsync(masterTuUniversidad);

        }

    }
}