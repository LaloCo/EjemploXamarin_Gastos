using System;
using System.Collections.Generic;
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
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<bool> UpdateExpense()
        {
            try
            {
                await App.MobileServiceClient.GetTable<Expense>().UpdateAsync(this);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<bool> DeleteExpense()
        {
            try
            {
                await App.MobileServiceClient.GetTable<Expense>().DeleteAsync(this);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static async Task<List<Expense>> GetExpensesAsync()
        {
            try
            {
                return await App.MobileServiceClient.GetTable<Expense>().ToListAsync();
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
