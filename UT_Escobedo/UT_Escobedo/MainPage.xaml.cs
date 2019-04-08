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

namespace UT_Escobedo
{
    public partial class MainPage : MasterDetailPage
    {

        public List<MasterMenuItem> MasterItem { get; set; }

        public MainPage()
        {

            InitializeComponent();

            #region Objects into the List

            MasterItem = new List<MasterMenuItem>();

            var page1 = new MasterMenuItem() { Id = 1, Title = "OfertaEducativa", Icon = "https://i.imgur.com/Brrtp3k.png" };
            MasterItem.Add(page1);

            var page2 = new MasterMenuItem() { Id = 2, Title = "Calendario Escolar", Icon = "https://i.imgur.com/GVcx6fw.png" };
            MasterItem.Add(page2);

            var page4 = new MasterMenuItem() { Id = 4, Title = "Directorio Escolar", Icon = "https://i.imgur.com/xifspk0.png" };
            MasterItem.Add(page4);

            var page5 = new MasterMenuItem() { Id = 5, Title = "Becas de Apoyo", Icon = "https://i.imgur.com/VXRv3u0.png" };
            MasterItem.Add(page5);

            var page6 = new MasterMenuItem() { Id = 6, Title = "Transporte", Icon = "https://i.imgur.com/cwxGDFc.png" };
            MasterItem.Add(page6);

            var page7 = new MasterMenuItem() { Id = 7, Title = "Tu Universidad", Icon = "https://i.imgur.com/DlwREdG.png" };
            MasterItem.Add(page7);

            #endregion

            navigationDrawerList.ItemsSource = MasterItem;

            Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(HomePage)));

            this.BindingContext = new MasterMenuItem();

        }

        private void NavigationDrawerList_ItemTapped(object sender, ItemTappedEventArgs e)
        {

            var selectedItem = e.Item as MasterMenuItem;

            switch (selectedItem.Id)
            {

                #region NavitaionPage into the List

                case 1:

                    Detail = new NavigationPage(new Main());

                    break;

                case 2:

                    Detail = new NavigationPage(new CalendarioEscolarPage());

                    break;

                case 4:

                    Detail = new NavigationPage(new DirectorioEscolarPage());

                    break;

                case 5:

                    Detail = new NavigationPage(new BecasPage());

                    break;

                case 6:

                    Detail = new NavigationPage(new TransportePage());

                    DisplayAlert("NOTA", "No olvides ir a comprar tus boletos.", "OK");

                    break;

                case 7:

                    Detail = new NavigationPage(new TuUniversidadPage());

                    break;

                    #endregion

            }

            ((ListView)sender).SelectedItem = null;

            IsPresented = false;

        }

        private void BtnHome_Clicked(object sender, EventArgs e)
        {

            Detail = new NavigationPage(new HomePage());

        }

    }
}
