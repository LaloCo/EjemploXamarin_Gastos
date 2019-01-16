using System;
using CoreGraphics;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using ExpensesExample.iOS.CustomRenderers;

[assembly: ExportRenderer(typeof(TextCell), typeof(CustomTextCellRenderer))]
[assembly: ExportRenderer(typeof(ProgressBar), typeof(CustomProgressBarRenderer))]
namespace ExpensesExample.iOS.CustomRenderers
{
    public class CustomProgressBarRenderer : ProgressBarRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<ProgressBar> e)
        {
            base.OnElementChanged(e);

            if (double.IsNaN(e.NewElement.Progress))
                Control.ProgressTintColor = Color.FromHex("#000000").ToUIColor();
            else if (e.NewElement.Progress < 0.3)
                Control.ProgressTintColor = Color.FromHex("#008DD5").ToUIColor();
            else if (e.NewElement.Progress < 0.5)
                Control.ProgressTintColor = Color.FromHex("#2D76BA").ToUIColor();
            else if (e.NewElement.Progress < 0.7)
                Control.ProgressTintColor = Color.FromHex("#5A5F9F").ToUIColor();
            else if (e.NewElement.Progress < 0.9)
                Control.ProgressTintColor = Color.FromHex("#B3316A").ToUIColor();
            else
                Control.ProgressTintColor = Color.FromHex("#E01A4F").ToUIColor();

            LayoutSubviews();
        }

        public override void LayoutSubviews()
        {
            base.LayoutSubviews();

            float scaleX = 1.0f;
            float scaleY = 4.0f;

            var transform = CGAffineTransform.MakeScale(scaleX, scaleY);
            Transform = transform;
        }
    }
}
