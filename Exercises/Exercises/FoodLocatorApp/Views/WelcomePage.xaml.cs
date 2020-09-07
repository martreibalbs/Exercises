using Exercises.FoodLocatorApp.Models;
using Exercises.FoodLocatorApp.ViewModels;
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
    public partial class WelcomePage : ContentPage
    {
        Lists mock => DependencyService.Get<Lists>();
        public WelcomePage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            getData();
        }
        public async void getData()
        {
            List<ListModel> newItem = new List<ListModel>();
            newItem = await mock.getlists();
            TheCarousel.ItemsSource = newItem;
        }

        private async void GetStarted_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LocationPage());
        }
    }
}