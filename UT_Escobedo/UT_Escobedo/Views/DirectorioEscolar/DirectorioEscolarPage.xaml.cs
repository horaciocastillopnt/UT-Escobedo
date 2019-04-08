using Plugin.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UT_Escobedo.Factory;
using UT_Escobedo.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UT_Escobedo.Views.DirectorioEscolar
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DirectorioEscolarPage : ContentPage
	{
		public DirectorioEscolarPage ()
		{

			InitializeComponent ();

            HomePage.bandera = 0;

            ListaDeContactos.ItemsSource = ContactosFactory.Contactos;

        }

        private void ListaDeContactos_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

            var CALL = e.SelectedItem as Contacto;

            var phonecall = CrossMessaging.Current.PhoneDialer;

            phonecall.MakePhoneCall(CALL.Telefono);

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