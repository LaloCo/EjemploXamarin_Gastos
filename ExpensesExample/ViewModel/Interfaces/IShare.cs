using System;
using System.Threading.Tasks;

namespace ExpensesExample.ViewModel.Interfaces
{
    public interface IShare
    {
        Task Show(string title, string message, string filePath);
    }
}
