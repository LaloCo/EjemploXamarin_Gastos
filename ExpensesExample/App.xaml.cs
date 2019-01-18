using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ExpensesExample.View;
using Microsoft.WindowsAzure.MobileServices;
using ExpensesExample.Resources;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;
using Microsoft.AppCenter.Push;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace ExpensesExample
{
    public partial class App : Application
    {
        public static MobileServiceClient MobileServiceClient = new MobileServiceClient("https://personalexpenses001.azurewebsites.net");

        public App()
        {
            InitializeComponent();

            //! Testing only
            AppResources.Culture = new System.Globalization.CultureInfo("en");

            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
            AppCenter.Start("ios=344791c1-9a35-4ef2-acbd-1d160a1cbbae;android=718a8554-36ac-4f94-b80f-8701258d1f49", typeof(Analytics), typeof(Crashes), typeof(Push));
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
