using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UT_Escobedo.Views.Oferta_Educativa;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UT_Escobedo.Views.OfertaEducativa
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Main : ContentPage
	{

        public static new int xd = 0;

		public Main ()
		{

			InitializeComponent ();

            if (xd == 0)
            {

                btnIngPage.IsEnabled = true;
                btnTsuPage.IsEnabled = true;

            }

            HomePage.bandera = 0;

        }

        private void BtnTsuPage_Clicked(object sender, EventArgs e)
        {

            xd = 1;

            btnIngPage.IsEnabled = false;
            btnTsuPage.IsEnabled = false;

            var tsu = new MainPage()
            {

                Detail = new NavigationPage(new OfertaEducativaPage())

            };

            NavigationPage.SetHasNavigationBar(tsu, false);

            Navigation.PushAsync(tsu);

        }

        private void BtnIngPage_Clicked(object sender, EventArgs e)
        {

            xd = 1;

            btnIngPage.IsEnabled = false;
            btnTsuPage.IsEnabled = false;


            var ing = new MainPage()
            {

                Detail = new NavigationPage(new Ing())

            };

            NavigationPage.SetHasNavigationBar(ing, false);

            Navigation.PushAsync(ing);

            DisplayAlert("INFORMACION", "Necesitas crusar el TSU para ingresar a la Inenieria", "Aceptar");

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