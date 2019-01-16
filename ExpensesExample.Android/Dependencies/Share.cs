using System;
using System.Threading.Tasks;
using Android.Content;
using Android.Support.V4.Content;
using ExpensesExample.Droid.Dependencies;
using ExpensesExample.ViewModel.Interfaces;
using Xamarin.Forms;

[assembly: Dependency(typeof(Share))]
namespace ExpensesExample.Droid.Dependencies
{
    public class Share : IShare
    {
        public Task Show(string title, string message, string filePath)
        {
            var intent = new Intent(Intent.ActionSend);
            intent.SetType("text/plain");
            var fileUri = FileProvider.GetUriForFile(Forms.Context.ApplicationContext, "com.lalorosas.ExpensesExample.provider", new Java.IO.File(filePath));

            intent.PutExtra(Intent.ExtraStream, fileUri);
            intent.PutExtra(Intent.ExtraTitle, title);
            intent.PutExtra(Intent.ExtraText, message);

            var chooser = Intent.CreateChooser(intent, title);
            chooser.SetFlags(ActivityFlags.GrantReadUriPermission);
            Android.App.Application.Context.StartActivity(chooser);

            return Task.FromResult(true);
        }
    }
}
