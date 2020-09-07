using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Exercises.FoodLocatorApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LocationPage : ContentPage
    {
        public LocationPage()
        {
            InitializeComponent(); 
            NavigationPage.SetHasNavigationBar(this, false);
        }

        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            DisplayAlert("Information", "Under Construction", "OK!");
        }


        private async void ShowRestaurant_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MasterDetailMenu());
        }
    }
}