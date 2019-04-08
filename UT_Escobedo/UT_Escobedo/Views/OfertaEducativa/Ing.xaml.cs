using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UT_Escobedo.Model.OfertaEducativaModelo;
using UT_Escobedo.Views.OfertaEducativa;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UT_Escobedo.Views.Oferta_Educativa
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Ing : ContentPage
	{

        public List<Ingenierias> ingenierias { get; set; }

        public new static int IdIng = 0;

        public Ing ()
		{

			InitializeComponent ();

            #region ItemDisplay Ingenieria

            ingenierias = new List<Ingenierias>();

            var ing1 = new Ingenierias() { Id = 1, INGCarreras = "ING. EN TECNOLOGIAS DE LA INFORMACION" };
            ingenierias.Add(ing1);

            var ing2 = new Ingenierias() { Id = 2, INGCarreras = "ING. EN MECATRONICA" };
            ingenierias.Add(ing2);

            var ing3 = new Ingenierias() { Id = 3, INGCarreras = "ING. EN MANTENIMIENTO INDUSTRIAL" };
            ingenierias.Add(ing3);

            var ing4 = new Ingenierias() { Id = 4, INGCarreras = "ING. EN DESARROLLO E INNOVACION EMPRESARIAL" };
            ingenierias.Add(ing4);

            var ing5 = new Ingenierias() { Id = 5, INGCarreras = "ING. EN TECNOLOGIA AMBIENTAL" };
            ingenierias.Add(ing5);

            var ing6 = new Ingenierias() { Id = 6, INGCarreras = "ING. EN GESTION INSTITUCIONAL EDUCATIVA Y CURRICULAR" };
            ingenierias.Add(ing6);

            var ing7 = new Ingenierias() { Id = 7, INGCarreras = "ING. NANOTECNOLOGIA" };
            ingenierias.Add(ing7);

            listView1.ItemsSource = ingenierias;

            #endregion

        }

        private void ListView1_ItemTapped(object sender, ItemTappedEventArgs e)
        {

            var selectedItem = e.Item as Ingenierias;

            switch (selectedItem.Id)
            {

                case 1:

                    IdIng = selectedItem.Id;
                    Navigation.PushAsync(new Ing_Page());

                    break;

                case 2:

                    IdIng = selectedItem.Id;
                    Navigation.PushAsync(new Ing_Page());

                    break;

                case 3:

                    IdIng = selectedItem.Id;
                    Navigation.PushAsync(new Ing_Page());

                    break;

                case 4:

                    IdIng = selectedItem.Id;
                    Navigation.PushAsync(new Ing_Page());

                    break;

                case 5:

                    IdIng = selectedItem.Id;
                    Navigation.PushAsync(new Ing_Page());

                    break;

                case 6:

                    IdIng = selectedItem.Id;
                    Navigation.PushAsync(new Ing_Page());

                    break;

                case 7:

                    IdIng = selectedItem.Id;
                    Navigation.PushAsync(new Ing_Page());

                    break;

            }

        }

        protected override bool OnBackButtonPressed()
        {

            Device.BeginInvokeOnMainThread(async () =>
            {

                var home = new MainPage()
                {

                    Detail = new NavigationPage(new Main())

                };

                NavigationPage.SetHasNavigationBar(home, false);

                await Navigation.PushAsync(home);

            });

            return true;

        }

    }
}