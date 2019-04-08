using CalendarCardView;
using CalendarCardView.RecyclerView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UT_Escobedo.Views.CalendarioEscolar
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CalendarioEscolarPage : ContentPage
	{
		public CalendarioEscolarPage ()
		{

			InitializeComponent ();

            HomePage.bandera = 0;

            #region Carga del picker 
            pickerPrueba.ItemsSource = new List<ItemMonth>()
            {
                new ItemMonth() { MonthName = "Enero"},
                new ItemMonth() { MonthName = "Febrero"},
                new ItemMonth() { MonthName = "Marzo"},
                new ItemMonth() { MonthName = "Abril"},
                new ItemMonth() { MonthName = "Mayo"},
                new ItemMonth() { MonthName = "Junio"},
                new ItemMonth() { MonthName = "Julio"},
                new ItemMonth() { MonthName = "Agosto"},
                new ItemMonth() { MonthName = "Septiembre"},
                new ItemMonth() { MonthName = "Octubre"},
                new ItemMonth() { MonthName = "Noviembre"},
                new ItemMonth() { MonthName = "Diciembre"}
            };
            #endregion

        }

        private void PickerPrueba_SelectedIndexChanged(object sender, EventArgs e)
        {

            CardData cards = new CardData();

            //Aqui se ponen los meses para establecer las fechas
            List<CardView> dataCards = new List<CardView>();

            var item = pickerPrueba.SelectedItem as ItemMonth;

            switch (item.MonthName)
            {
                case "Enero":

                    foreach (var card in cards.Enero())
                    {
                        if (card.DueDate >= DateTime.Now.Date)
                            dataCards.Add(new CardView(card));
                    }

                    eventsList.ItemsSource = dataCards;

                    break;

                case "Febrero":

                    foreach (var card in cards.Febrero())
                    {
                        if (card.DueDate >= DateTime.Now.Date)
                            dataCards.Add(new CardView(card));
                    }

                    eventsList.ItemsSource = dataCards;

                    break;

                case "Marzo":

                    foreach (var card in cards.Marzo())
                    {
                        if (card.DueDate >= DateTime.Now.Date)
                            dataCards.Add(new CardView(card));
                    }

                    eventsList.ItemsSource = dataCards;

                    break;

                case "Abril":

                    foreach (var card in cards.Abril())
                    {
                        if (card.DueDate >= DateTime.Now.Date)
                            dataCards.Add(new CardView(card));
                    }

                    eventsList.ItemsSource = dataCards;

                    break;

                case "Mayo":

                    foreach (var card in cards.Mayo())
                    {
                        if (card.DueDate >= DateTime.Now.Date)
                            dataCards.Add(new CardView(card));
                    }

                    eventsList.ItemsSource = dataCards;

                    break;

                case "Junio":

                    foreach (var card in cards.Junio())
                    {
                        if (card.DueDate >= DateTime.Now.Date)
                            dataCards.Add(new CardView(card));
                    }

                    eventsList.ItemsSource = dataCards;

                    break;

                case "Julio":

                    foreach (var card in cards.Julio())
                    {
                        if (card.DueDate >= DateTime.Now.Date)
                            dataCards.Add(new CardView(card));
                    }

                    eventsList.ItemsSource = dataCards;

                    break;

                case "Agosto":

                    foreach (var card in cards.Agosto())
                    {
                        if (card.DueDate >= DateTime.Now.Date)
                            dataCards.Add(new CardView(card));
                    }

                    eventsList.ItemsSource = dataCards;

                    break;

                case "Septiembre":

                    foreach (var card in cards.Septiembre())
                    {
                        if (card.DueDate >= DateTime.Now.Date)
                            dataCards.Add(new CardView(card));
                    }

                    eventsList.ItemsSource = dataCards;

                    break;

                case "Octubre":

                    foreach (var card in cards.Octubre())
                    {
                        if (card.DueDate >= DateTime.Now.Date)
                            dataCards.Add(new CardView(card));
                    }

                    eventsList.ItemsSource = dataCards;

                    break;

                case "Noviembre":

                    foreach (var card in cards.Noviembre())
                    {
                        if (card.DueDate >= DateTime.Now.Date)
                            dataCards.Add(new CardView(card));
                    }

                    eventsList.ItemsSource = dataCards;

                    break;

                case "Diciembre":

                    foreach (var card in cards.Diciembre())
                    {
                        if (card.DueDate >= DateTime.Now.Date)
                            dataCards.Add(new CardView(card));
                    }

                    eventsList.ItemsSource = dataCards;

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

    public class ItemMonth
    {

        public string MonthName { get; set; }

    }

}