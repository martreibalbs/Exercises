using Exercises.FoodLocatorApp.Models;
using Exercises.FoodLocatorApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Exercises.FoodLocatorApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BrowsePage : ContentPage
    {
        Lists mock => DependencyService.Get<Lists>();
        public BrowsePage()
        {
            InitializeComponent();
            getData();
        }
        public async void getData()
        {
            List<PlaceModel> newItem = new List<PlaceModel>();
            newItem = await mock.getplaces();
            myItem.ItemsSource = newItem;
        }
        private async void myItem_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var restaurantDetails = e.Item as PlaceModel;
            await Navigation.PushAsync(new RestaurantDetailPage(restaurantDetails));
        }
    }
}