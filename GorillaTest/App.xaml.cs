using System;
using GorillaTest.View;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GorillaTest
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            NavigationPage navigation = new NavigationPage(new HomeView());

            MainPage = new MasterDetailPage { 
                Master = new MenuView(),
                Detail = navigation
            };
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
