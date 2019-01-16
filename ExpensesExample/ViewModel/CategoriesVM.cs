using System;
using System.Linq;
using System.Collections.ObjectModel;
using ExpensesExample.Model;
using System.Windows.Input;
using Xamarin.Forms;
using System.ComponentModel;
using PCLStorage;
using System.IO;
using ExpensesExample.ViewModel.Interfaces;

namespace ExpensesExample.ViewModel
{
    public class CategoriesVM : INotifyPropertyChanged
    {
        public class Progress
        {
            public string Name { get; set; }

            public double ProgressValue { get; set; }
        }

        private bool hasProgresses;
        public bool HasProgresses
        {
            get { return hasProgresses; }
            set
            {
                hasProgresses = value;
                OnPropertyChanged("HasProgresses");
            }
        }

        public ObservableCollection<Progress> Progresses { get; set; }

        public ICommand ShareCommand { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        public CategoriesVM()
        {
            HasProgresses = false;

            ShareCommand = new Command<bool>(ShareReport, ShareCommandCanExecute);
            Progresses = new ObservableCollection<Progress>();

            GetProgresses();
        }

        bool ShareCommandCanExecute(bool arg)
        {
            return arg;
        }

        async void ShareReport(bool obj)
        {
            // Todo: create file with progresses
            IFileSystem fileSystem = FileSystem.Current;
            var rootFolder = fileSystem.LocalStorage;
            var reportsFolder = await rootFolder.CreateFolderAsync("reports", CreationCollisionOption.OpenIfExists);
            var reportFile = await reportsFolder.CreateFileAsync("report.txt", CreationCollisionOption.ReplaceExisting);

            using (StreamWriter sw = new StreamWriter(reportFile.Path))
            {
                foreach(var progress in Progresses)
                {
                    sw.WriteLine($"{progress.Name} - {progress.ProgressValue:p}");
                }
            }

            IShare shareDependency = DependencyService.Get<IShare>();
            await shareDependency.Show("Reporte de Gastos", "Reporte de gastos por categoría", reportFile.Path);
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

                HasProgresses = true;
            }
        }

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
