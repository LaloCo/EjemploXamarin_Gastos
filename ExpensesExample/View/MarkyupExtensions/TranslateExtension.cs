using System;
using System.Globalization;
using System.Reflection;
using System.Resources;
using ExpensesExample.Resources;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ExpensesExample.View.MarkyupExtensions
{
    [ContentProperty("Text")]
    public class TranslateExtension : IMarkupExtension
    {
        readonly CultureInfo cultureInfo = null;

        public string ResourceName { get; set; }

        static readonly Lazy<ResourceManager> resourceManager = new Lazy<ResourceManager>(() => new ResourceManager("ExpensesExample.Resources.AppResources", IntrospectionExtensions.GetTypeInfo(typeof(TranslateExtension)).Assembly));

        public TranslateExtension()
        {
            cultureInfo = AppResources.Culture;
        }

        public object ProvideValue(IServiceProvider serviceProvider)
        {
            if (string.IsNullOrWhiteSpace(ResourceName))
                return string.Empty;

            string value = resourceManager.Value.GetString(ResourceName, cultureInfo);

            if (value == null)
                return string.Empty;

            return value;
        }
    }
}
