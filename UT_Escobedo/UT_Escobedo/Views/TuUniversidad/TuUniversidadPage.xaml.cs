using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UT_Escobedo.Views.TuUniversidad
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class TuUniversidadPage : ContentPage
	{
		public TuUniversidadPage ()
		{

			InitializeComponent ();

            HomePage.bandera = 0;

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