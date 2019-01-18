using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;

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
                Analytics.TrackEvent("Gasto insertado");
                return true;
            }
            catch (Exception ex)
            {
                Crashes.TrackError(ex);
                return false;
            }
        }

        public async Task<bool> UpdateExpense()
        {
            try
            {
                await App.MobileServiceClient.GetTable<Expense>().UpdateAsync(this);
                Analytics.TrackEvent("Gasto actualizado");
                return true;
            }
            catch (Exception ex)
            {
                Crashes.TrackError(ex);
                return false;
            }
        }

        public async Task<bool> DeleteExpense()
        {
            try
            {
                await App.MobileServiceClient.GetTable<Expense>().DeleteAsync(this);
                Analytics.TrackEvent("Gasto borrado");
                return true;
            }
            catch (Exception ex)
            {
                Crashes.TrackError(ex);
                return false;
            }
        }

        public static async Task<List<Expense>> GetExpensesAsync()
        {
            try
            {
                Analytics.TrackEvent("Gastos leídos");
                return await App.MobileServiceClient.GetTable<Expense>().ToListAsync();
            }
            catch (Exception ex)
            {
                Crashes.TrackError(ex);
                return null;
            }
        }
    }
}
