using System;
using System.ComponentModel;
using ExpensesExample.Model;

namespace ExpensesExample.ViewModel
{
    public class ExpenseDetailsVM : INotifyPropertyChanged
    {
        private Expense selectedExpense;
        public Expense SelectedExpense
        {
            get { return selectedExpense; }
            set
            {
                selectedExpense = value;
                OnPropertyChanged("SelectedExpense");
            }
        }

        public ExpenseDetailsVM()
        {
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
