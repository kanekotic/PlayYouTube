using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Markup;

namespace Soft.Hati.PlayYouTube.App.ViewModels
{
    public abstract class BaseConverter : MarkupExtension, IValueConverter
    {
        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return this;
        }

        public abstract object Convert(object value, Type targetType, object parameter, CultureInfo culture);
        public abstract object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture);
    }
}