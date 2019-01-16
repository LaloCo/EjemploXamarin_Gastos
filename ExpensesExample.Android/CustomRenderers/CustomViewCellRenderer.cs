using System;
using System.ComponentModel;
using Android.Content;
using Android.Graphics.Drawables;
using Android.Views;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

namespace ExpensesExample.Droid.CustomRenderers
{
    public class CustomViewCellRenderer : ViewCellRenderer
    {
        private Android.Views.View _cell;
        private Drawable _normalBackground;
        private bool _isSelected;

        protected override Android.Views.View GetCellCore(Cell item, Android.Views.View convertView, ViewGroup parent, Context context)
        {
            _cell = base.GetCellCore(item, convertView, parent, context);

            _normalBackground = _cell.Background;
            _isSelected = false;

            return _cell;
        }

        protected override void OnCellPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnCellPropertyChanged(sender, e);

            var cell = sender as ViewCell;

            if(e.PropertyName == "IsSelected")
            {
                _isSelected = !_isSelected;

                if (_isSelected)
                {
                    switch (cell.StyleId)
                    {
                        case "blue":
                            _cell.SetBackgroundColor(Android.Graphics.Color.DodgerBlue);
                            break;
                        case "red":
                            _cell.SetBackgroundColor(Android.Graphics.Color.DarkRed);
                            break;
                        case "transparent":
                            _cell.SetBackgroundColor(Android.Graphics.Color.Transparent);
                            break;
                        case "green":
                            _cell.SetBackgroundColor(Android.Graphics.Color.PaleGreen);
                            break;
                        default:
                            _cell.SetBackgroundColor(Android.Graphics.Color.LightGray);
                            break;
                    }
                }
                else
                {
                    _cell.SetBackgroundColor(Android.Graphics.Color.Transparent);
                }
            }
        }
    }

    public class CustomTextCellRenderer : TextCellRenderer
    {
        private Android.Views.View _cell;
        private Drawable _normalBackground;
        private bool _isSelected;

        protected override Android.Views.View GetCellCore(Cell item, Android.Views.View convertView, ViewGroup parent, Context context)
        {
            _cell = base.GetCellCore(item, convertView, parent, context);

            _normalBackground = _cell.Background;
            _isSelected = false;

            return _cell;
        }

        protected override void OnCellPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnCellPropertyChanged(sender, e);

            var cell = sender as TextCell;

            if (e.PropertyName == "IsSelected")
            {
                _isSelected = !_isSelected;

                if (_isSelected)
                {
                    switch (cell.StyleId)
                    {
                        case "blue":
                            _cell.SetBackgroundColor(Android.Graphics.Color.DodgerBlue);
                            break;
                        case "red":
                            _cell.SetBackgroundColor(Android.Graphics.Color.DarkRed);
                            break;
                        case "transparent":
                            _cell.SetBackgroundColor(Android.Graphics.Color.Transparent);
                            break;
                        case "green":
                            _cell.SetBackgroundColor(Android.Graphics.Color.PaleGreen);
                            break;
                        default:
                            _cell.SetBackgroundColor(Android.Graphics.Color.LightGray);
                            break;
                    }
                }
                else
                {
                    _cell.SetBackgroundColor(Android.Graphics.Color.Transparent);
                }
            }
        }
    }
}
