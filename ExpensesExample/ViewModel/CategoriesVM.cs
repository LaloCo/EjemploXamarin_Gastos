using System;
using System.Linq;
using System.Collections.ObjectModel;
using ExpensesExample.Model;

namespace ExpensesExample.ViewModel
{
    public class CategoriesVM
    {
        public class Progress
        {
            public string Name { get; set; }

            public double ProgressValue { get; set; }
        }

        public ObservableCollection<Progress> Progresses { get; set; }

        public CategoriesVM()
        {
            Progresses = new ObservableCollection<Progress>();

            GetProgresses();
        }

        private async void GetProgresses()
        {
            var categories = Category.GetCategories();
            var expenses = await Expense.GetExpensesAsync();

            if (expenses != null)
            {
                double totalExpenses = expenses.Sum(e => e.Ammount);

                foreach (string category in categories)
                {
                    double expensesInCategory = expenses.Where(e => e.Category == category).Sum(e => e.Ammount);
                    Progresses.Add(new Progress { Name = category, ProgressValue = expensesInCategory / totalExpenses });
                }
            }
        }
    }
}
