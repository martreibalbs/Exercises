using Exercises.FoodLocatorApp.ViewModels;
using Exercises.FoodLocatorApp.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Exercises
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            DependencyService.Register<Lists>();

            //MainPage = new MasterDetailMenu();

            MainPage = new NavigationPage( new WelcomePage());
            //MainPage = new NavigationPage( new Location());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
