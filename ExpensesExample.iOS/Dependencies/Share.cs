using System;
using System.Threading.Tasks;
using ExpensesExample.iOS.Dependencies;
using ExpensesExample.ViewModel.Interfaces;
using Xamarin.Forms;

[assembly: Dependency(typeof(Share))]
namespace ExpensesExample.iOS.Dependencies
{
    public class Share : IShare
    {
        public Task Show(string title, string message, string filePath)
        {
            return Task.FromResult(true);
        }
    }
}
