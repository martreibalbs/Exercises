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
    public partial class MasterDetailMenu : MasterDetailPage
    {
        public MasterDetailMenu()
        {
            InitializeComponent();
            Detail = new NavigationPage(new BrowsePage());
            IsPresented = false;
            NavigationPage.SetHasNavigationBar(this, false);
        }

        private void About_Clicked(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new AboutPage());
            IsPresented = false;
        }

        private void Quit_Clicked(object sender, EventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }

        private void BrowseRestaurant_Clicked(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new BrowsePage());
            IsPresented = false;
        }
    }
}