using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Maps;
using Xamarin.Forms.Xaml;

namespace Exercises.FoodLocatorApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ShowRoute : ContentPage
    {
        public ShowRoute(string restaurantName, string restaurantFood, double latitude, double longitude)
        {
            InitializeComponent();
            RestaurantNameShow.Text = restaurantName;
            RestaurantFoodShow.Text = restaurantFood;

            Position position = new Position(latitude, longitude);
            MapSpan mapSpan = new MapSpan(position, 0.05, 0.05);
            Map MyMap = new Map(mapSpan);

            Pin pin = new Pin
            {
                Position = new Position(latitude, longitude),
                Label = "Any",
                Address = "Value"
            };

            MyMap.Pins.Add(pin);

            container.Children.Add(MyMap);
            //  MyMap.HasZoomEnabled = false;
            MyMap.IsEnabled = false;
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {

        }
    }
}