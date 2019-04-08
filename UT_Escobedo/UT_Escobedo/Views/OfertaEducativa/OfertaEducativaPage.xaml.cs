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
    public partial class OfertaEducativaPage : ContentPage
    {

        public List<TSU> Ts { get; set; }

        public new static int Id = 0;

        public OfertaEducativaPage()
        {

            InitializeComponent();

            #region ItemDisplay Carreras TSU

            Ts = new List<TSU>();

            var carrera1 = new TSU() { Id = 1, TSUCarreras = "TSU EN QUIMICA AREA TECNOLOGIA AMBIENTAL" };
            Ts.Add(carrera1);

            var carrera2 = new TSU() { Id = 2, TSUCarreras = "TSU EN LENGUA INGLESA" };
            Ts.Add(carrera2);

            var carrera3 = new TSU() { Id = 3, TSUCarreras = "TSU EN MANTENIMIENTO AREA INDUSTRIAL" };
            Ts.Add(carrera3);

            var carrera4 = new TSU() { Id = 4, TSUCarreras = "TSU EN MECATRONICA AREA AUTOMATIZACION" };
            Ts.Add(carrera4);

            var carrera5 = new TSU() { Id = 5, TSUCarreras = "TSU EN ENERGIAS RENOVABLES AREA ENERGIA SOLAR" };
            Ts.Add(carrera5);

            var carrera6 = new TSU() { Id = 6, TSUCarreras = "TSU EN TECNOLOGIAS DE LA INFORMACION AREA DESARROLLO MULTIPLATAFORMA" };
            Ts.Add(carrera6);

            var carrera7 = new TSU() { Id = 7, TSUCarreras = "TSU EN NANOTECNOLOGIA AREA MATERIALES" };
            Ts.Add(carrera7);

            var carrera8 = new TSU() { Id = 8, TSUCarreras = "TSU EN DESARROLLO DE NEGOCIOS AREA MERCADOTECNIA" };
            Ts.Add(carrera8);

            var carrera9 = new TSU() { Id = 9, TSUCarreras = "TSU EN DESARROLLO DE NEGOCIOS AREA VENTAS" };
            Ts.Add(carrera9);

            var carrera10 = new TSU() { Id = 10, TSUCarreras = "TSU EN LOGISTICA AREA CADENA SUMINISTROS" };
            Ts.Add(carrera10);

            ListView.ItemsSource = Ts;

            #endregion

        }

        private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {

            var selectedItem = e.Item as TSU;

            switch (selectedItem.Id)
            {

                case 1:

                    Id = selectedItem.Id;
                    Navigation.PushAsync(new Tabbed_Page());

                    break;

                case 2:

                    Id = selectedItem.Id;
                    Navigation.PushAsync(new Tabbed_Page());

                    break;

                case 3:

                    Id = selectedItem.Id;
                    Navigation.PushAsync(new Tabbed_Page());

                    break;

                case 4:

                    Id = selectedItem.Id;
                    Navigation.PushAsync(new Tabbed_Page());

                    break;

                case 5:

                    Id = selectedItem.Id;
                    Navigation.PushAsync(new Tabbed_Page());

                    break;

                case 6:

                    Id = selectedItem.Id;
                    Navigation.PushAsync(new Tabbed_Page());

                    break;

                case 7:

                    Id = selectedItem.Id;
                    Navigation.PushAsync(new Tabbed_Page());

                    break;

                case 8:

                    Id = selectedItem.Id;
                    Navigation.PushAsync(new Tabbed_Page());

                    break;

                case 9:

                    Id = selectedItem.Id;
                    Navigation.PushAsync(new Tabbed_Page());

                    break;

                case 10:

                    Id = selectedItem.Id;
                    Navigation.PushAsync(new Tabbed_Page());

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