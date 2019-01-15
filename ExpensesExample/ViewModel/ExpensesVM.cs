using System;
using System.Windows.Input;
using ExpensesExample.View;
using Xamarin.Forms;

namespace ExpensesExample.ViewModel
{
    public class ExpensesVM
    {
        public ICommand NewExpenseCommand { get; set; }

        public ExpensesVM()
        {
            NewExpenseCommand = new Command(NewCommandNavigation);
        }

        void NewCommandNavigation(object obj)
        {
            App.Current.MainPage.Navigation.PushAsync(new NewExpensePage());
        }
    }
}
