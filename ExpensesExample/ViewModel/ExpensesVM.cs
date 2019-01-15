using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using ExpensesExample.Model;
using ExpensesExample.View;
using Xamarin.Forms;

namespace ExpensesExample.ViewModel
{
    public class ExpensesVM
    {
        public ICommand NewExpenseCommand { get; set; }

        public ObservableCollection<Expense> Expenses { get; set; }

        public ExpensesVM()
        {
            NewExpenseCommand = new Command(NewCommandNavigation);
            Expenses = new ObservableCollection<Expense>();

            GetExpenses();
        }

        private async void GetExpenses()
        {
            Expenses.Clear();
            var expenses = await Expense.GetExpensesAsync();

            foreach (var expense in expenses)
                Expenses.Add(expense);
        }

        void NewCommandNavigation(object obj)
        {
            App.Current.MainPage.Navigation.PushAsync(new NewExpensePage());
        }
    }
}
