using System;
using System.Collections.Generic;

namespace ExpensesExample.Model
{
    public static class Category
    {
        public static List<string> GetCategories()
        {
            List<string> categories = new List<string>();
            categories.Add("Transporte");
            categories.Add("Personal");
            categories.Add("Salud");
            categories.Add("Ahorro");
            categories.Add("Ocio");
            categories.Add("Hogar");
            categories.Add("Otros");

            return categories;
        }
    }
}
