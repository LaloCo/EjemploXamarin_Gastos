using System;
using System.Collections.Generic;
using ExpensesExample.Model;
using ExpensesExample.ViewModel;
using Xamarin.Forms;

namespace ExpensesExample.View
{
    public partial class ExpenseDetailsPage : ContentPage
    {
        public ExpenseDetailsVM ViewModel;

        public ExpenseDetailsPage()
        {
            InitializeComponent();
        }

        public ExpenseDetailsPage(Expense selectedExpense)
        {
            InitializeComponent();

            ViewModel = Resources["vm"] as ExpenseDetailsVM;
            ViewModel.SelectedExpense = selectedExpense;
        }
    }
}
