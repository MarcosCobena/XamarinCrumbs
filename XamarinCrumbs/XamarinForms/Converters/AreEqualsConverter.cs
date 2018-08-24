using System;
using System.Globalization;
using Xamarin.Forms;

namespace XamarinCrumbs.Converters
{
    public class AreEqualsConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var equals = object.Equals(value, parameter);

            return equals;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
