using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;
using ExpensesExample.Model;
using ExpensesExample.View;
using Xamarin.Forms;

namespace ExpensesExample.ViewModel
{
    public class ExpensesVM : INotifyPropertyChanged
    {
        public ICommand NewExpenseCommand { get; set; }
        public ICommand DeleteExpenseCommand { get; set; }

        public ObservableCollection<Expense> Expenses { get; set; }

        private Expense selectedExpense;
        public Expense SelectedExpense
        {
            get { return selectedExpense; }
            set
            {
                selectedExpense = value;
                OnPropertyChanged("SelectedExpense");
                App.Current.MainPage.Navigation.PushAsync(new ExpenseDetailsPage(selectedExpense));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public ExpensesVM()
        {
            NewExpenseCommand = new Command(NewCommandNavigation);
            DeleteExpenseCommand = new Command<Expense>(DeleteExpense);

            Expenses = new ObservableCollection<Expense>();

            GetExpenses();
        }

        async void DeleteExpense(Expense expense)
        {
            await expense.DeleteExpense();
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

        void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
