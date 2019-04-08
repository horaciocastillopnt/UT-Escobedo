using CalendarCardView.RecyclerView;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace CalendarCardView
{
    public partial class View_Recycler : ContentPage
    {
        CardData cards = new CardData();

        StackLayout cardStack = new StackLayout()
        {
            Spacing = 15,
            Padding = new Thickness(10),
            VerticalOptions = LayoutOptions.StartAndExpand,
        };

        StackLayout shadowcardStack = new StackLayout()
        {
            Spacing = 5,
            Padding = new Thickness(5),
            VerticalOptions = LayoutOptions.StartAndExpand,
        };

        public View_Recycler()
        {
            this.Title = "RecyclerView/CardView";
            CargarLista();
        }

        public void CargarLista()
        {
            foreach(var card in cards)
            {
                cardStack.Children.Add(new CardView(card));
            }

            this.BackgroundColor = Color.White;

            Content = new ScrollView()
            {
                Content = new StackLayout()
                {
                    Spacing = 30,
                    Padding = 25,
                    Children =
                    {
                        cardStack,
                        shadowcardStack
                    }
                }
            };
        }
    }
}
