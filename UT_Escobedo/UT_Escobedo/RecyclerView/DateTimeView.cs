using System;
using System.Collections.Generic;
using Xamarin.Forms;
using System.Text;

namespace CalendarCardView.RecyclerView
{
    public class DateTimeView : ContentView
    {
        public DateTimeView(Card card)
        {
            var labelStyle = new Style(typeof(Label))
                .Set(Label.FontSizeProperty, 12)
                .Set(Label.TextColorProperty, StyleKit.MediumGray)
                .Set(Image.VerticalOptionsProperty, LayoutOptions.Center);

            var iconStyle = new Style(typeof(Image))
                .Set(Image.HeightRequestProperty, 10)
                .Set(Image.WidthRequestProperty, 10)
                .Set(Image.VerticalOptionsProperty, LayoutOptions.Center);

            var stack = new StackLayout()
            {
                VerticalOptions = LayoutOptions.Center,
                HeightRequest = 20,
                Padding = new Thickness(0),
                Orientation = StackOrientation.Horizontal,
                Children = {
                    new Image()
                    {
                        Style = iconStyle,
                        Source = StyleKit.Icons.SmallCalendar,
                    },
                    new Label()
                    {
                        Text = card.DueDate.Date.ToString("dd/MM/yyyy"),
                        Style = labelStyle,
                    },
                    new BoxView (){ Color = Color.Transparent, WidthRequest = 20 },
                }
            };
            Content = stack;
        }
    }
}
