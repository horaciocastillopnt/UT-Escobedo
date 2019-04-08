using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace CalendarCardView.RecyclerView
{
    public class CardView : ContentView
    {
        public CardView(Card card)
        {
            Grid grid = new Grid
            {
                Padding = new Thickness(0, 1, 1, 1),
                RowSpacing = 1,
                ColumnSpacing = 1,
                BackgroundColor = StyleKit.CardBorderColor,
                VerticalOptions = LayoutOptions.FillAndExpand,
                RowDefinitions = {
                    new RowDefinition { Height = new GridLength (90, GridUnitType.Absolute) },
                    new RowDefinition { Height = new GridLength (30, GridUnitType.Absolute) }
                },
                ColumnDefinitions = {
                    new ColumnDefinition { Width = new GridLength (4, GridUnitType.Absolute) },
                    new ColumnDefinition { Width = new GridLength (1, GridUnitType.Star) },
                    new ColumnDefinition { Width = new GridLength (100, GridUnitType.Absolute) }
                }
            };

            grid.Children.Add(new CardStatusView(card), 0, 1, 0, 2);

            grid.Children.Add(new CardDetailsView(card), 1, 3, 0, 1);

            grid.Children.Add(new IconLabelView(card.StatusMessageFileSource, card.StatusMessage), 2, 1);

            grid.Children.Add(new ContentView() { BackgroundColor = Color.FromHex("#F6F6F6") }, 1, 1);

            Content = grid;
        }
    }
}
