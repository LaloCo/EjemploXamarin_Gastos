using System;
namespace ExpensesExample.Model
{
    public class Expense
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public string Category { get; set; }

        public DateTime Date { get; set; }

        public double Ammount { get; set; }

        public Expense()
        {
        }

        public bool InsertExpense()
        {
            // Todo: insert expense (this)
            return true;
        }
    }
}
