﻿using System;
using System.ComponentModel;
using System.Windows.Input;
using ExpensesExample.Model;
using Xamarin.Forms;

namespace ExpensesExample.ViewModel
{
    public class NewExpenseVM : INotifyPropertyChanged
    {
        private string name;
        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                OnPropertyChanged("Name");
            }
        }

        private string category;
        public string Category
        {
            get { return category; }
            set
            {
                category = value;
                OnPropertyChanged("Category");
            }
        }

        private DateTime date;
        public DateTime Date
        {
            get { return date; }
            set
            {
                date = value;
                OnPropertyChanged("Date");
            }
        }

        private double ammount;
        public double Ammount
        {
            get { return ammount; }
            set
            {
                ammount = value;
                OnPropertyChanged("Ammount");
            }
        }

        public ICommand SaveExpenseCommand { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        public NewExpenseVM()
        {
            SaveExpenseCommand = new Command(SaveExpense);
        }

        void SaveExpense(object obj)
        {
            Expense expense = new Expense
            {
                Ammount = Ammount,
                Name = Name,
                Category = Category,
                Date = Date
            };
            if (expense.InsertExpense())
                App.Current.MainPage.Navigation.PopAsync();
            else
                App.Current.MainPage.DisplayAlert("Error", "Hubo un error guardando el gasto", "Ok");
        }

        void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
