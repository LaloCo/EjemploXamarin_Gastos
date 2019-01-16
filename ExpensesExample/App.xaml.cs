using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ExpensesExample.View;
using Microsoft.WindowsAzure.MobileServices;
using ExpensesExample.Resources;

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
            AppResources.Culture = new System.Globalization.CultureInfo("es");

            MainPage = new NavigationPage(new MainPage());
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
