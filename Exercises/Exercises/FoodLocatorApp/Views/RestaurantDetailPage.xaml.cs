using Exercises.FoodLocatorApp.Models;
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
    public partial class RestaurantDetailPage : ContentPage
    {
        PlaceModel myValue = new PlaceModel();
        public RestaurantDetailPage(PlaceModel list)
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            myValue = list;

            RestaurantImageShow.Source = myValue.RestaurantImage;
            RestaurantNameShow.Text = myValue.RestaurantName;
            RestaurantFoodShow.Text = myValue.RestaurantFood;
            RestaurantDetailShow.Text = myValue.RestaurantDetail;


            Position position = new Position(myValue.Latitude, myValue.Longitude);
            MapSpan mapSpan = new MapSpan(position, 0.05, 0.05);
            Map MyMap = new Map(mapSpan);

            Pin pin = new Pin
            {
                Position = new Position(myValue.Latitude, myValue.Longitude),
                Label = myValue.RestaurantName,
                Address = myValue.RestaurantFood
            };

            MyMap.Pins.Add(pin);

            container.Children.Add(MyMap);
            //  MyMap.HasZoomEnabled = false;
            MyMap.IsEnabled = false;
        }
        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ShowRoute(RestaurantNameShow.Text, RestaurantFoodShow.Text, myValue.Latitude, myValue.Longitude));
        }

        private async void backArrow_Tapped(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}