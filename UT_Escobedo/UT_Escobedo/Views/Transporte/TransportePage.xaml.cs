using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UT_Escobedo.Model;
using UT_Escobedo.Views.Transporte.GEMA;
using UT_Escobedo.Views.Transporte.RutaUrbana;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UT_Escobedo.Views.Transporte
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class TransportePage : ContentPage
	{

        public List<Rutas> rutas { get; set; }

        public TransportePage ()
		{

			InitializeComponent ();

            HomePage.bandera = 0;

            rutas = new List<Rutas>();

            rutas.Add(new Rutas()
            {


                Id = 1,
                Icon = "bus.png",
                RutaU = "Ruta 88"

            });

            rutas.Add(new Rutas()
            {

                Id = 2,
                Icon = "bus.png",
                RutaU = "Ruta 527"

            });

            RutaUrbana.ItemsSource = rutas;

        }

        private void UtBus_ItemTapped(object sender, ItemTappedEventArgs e)
        {

            var bus = e.Item as UT_Bus;

            switch (bus.Id)
            {

                case 1:

                    Navigation.PushAsync(new GemaEscobedo_Page());

                    break;

                case 2:

                    Navigation.PushAsync(new RutaHidalgo_Page());

                    break;

                case 3:

                    Navigation.PushAsync(new GemaZuazua_Page());

                    break;

                case 4:

                    Navigation.PushAsync(new GemaSolidaridad_Page());

                    break;

                case 5:

                    Navigation.PushAsync(new GemaConcordia_Page());

                    break;

            }

        }

        private void RutaUrbana_ItemTapped(object sender, ItemTappedEventArgs e)
        {

            var ruta = e.Item as Rutas;

            switch (ruta.Id)
            {

                case 1:

                    Navigation.PushAsync(new Ruta527_Page());

                    break;

                case 2:

                    Navigation.PushAsync(new Ruta88_Page());

                    break;

            }

        }

        protected override bool OnBackButtonPressed()
        {

            Device.BeginInvokeOnMainThread(async () =>
            {

                var home = new MainPage()
                {

                    Detail = new NavigationPage(new HomePage())

                };

                NavigationPage.SetHasNavigationBar(home, false);

                await Navigation.PushAsync(home);

            });

            return true;

        }

    }
}