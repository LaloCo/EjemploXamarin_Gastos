using System;
using System.Threading.Tasks;

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

        public async Task<bool> InsertExpense()
        {
            try
            {
                await App.MobileServiceClient.GetTable<Expense>().InsertAsync(this);
                return true;
            }
            catch(Exception)
            {
                return false;
            }
        }
    }
}
