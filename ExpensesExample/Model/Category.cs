using System;
using System.Collections.Generic;
using ExpensesExample.Resources;

namespace ExpensesExample.Model
{
    public static class Category
    {
        public static List<string> GetCategories()
        {
            List<string> categories = new List<string>();
            categories.Add(AppResources.transportCategory);
            categories.Add(AppResources.personalCategory);
            categories.Add(AppResources.healthCategory);
            categories.Add(AppResources.savingsCategory);
            categories.Add(AppResources.playCategory);
            categories.Add(AppResources.housingCategory);
            categories.Add(AppResources.otherCategory);

            return categories;
        }
    }
}
