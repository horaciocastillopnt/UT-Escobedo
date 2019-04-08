﻿using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace CalendarCardView.RecyclerView
{
    public class IconLabelView : ContentView
    {
        public IconLabelView(FileImageSource imgSource, string text)
        {
            BackgroundColor = StyleKit.CardFooterBackgroundColor;

            var label = new Label()
            {
                Text = text,
                FontSize = 9,
                FontAttributes = FontAttributes.Bold,
                TextColor = StyleKit.LightTextColor
            };

            var stack = new StackLayout()
            {
                Padding = new Thickness(5),
                Orientation = StackOrientation.Horizontal,
                HorizontalOptions = LayoutOptions.StartAndExpand,
                VerticalOptions = LayoutOptions.Center,
                Children =
                {
                    new Image ()
                    {
                        Source = imgSource,
                        HeightRequest = 10,
                        WidthRequest = 10
                    },

                    label
                }
            };
            Content = stack;
        }
    }
}
