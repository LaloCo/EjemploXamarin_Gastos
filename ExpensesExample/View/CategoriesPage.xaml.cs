using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ExpensesExample.View
{
    public partial class CategoriesPage : ContentPage
    {
        public CategoriesPage()
        {
            InitializeComponent();

            SizeChanged += CategoriesPage_SizeChanged;
        }

        void CategoriesPage_SizeChanged(object sender, EventArgs e)
        {
            string visualState = Width > Height ? "Landscape" : "Portrait";

            VisualStateManager.GoToState(titleLabel, visualState);
        }
    }
}
