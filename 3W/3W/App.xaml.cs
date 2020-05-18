using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using _3W.Services;
using _3W.Views;

namespace _3W
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new MainPage();
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
