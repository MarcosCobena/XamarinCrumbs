using System;
using System.Collections;
using System.Globalization;
using Xamarin.Forms;

namespace XamarinCrumbs.Converters
{
    public class AnyConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            int count;

            if (value is int number)
            {
                count = number;
            }
            else if (value is IEnumerable enumerable)
            {
                count = 0;

                foreach (var item in enumerable)
                {
                    count++;
                }
            }
            else
            {
                count = 0;
            }

            bool result;

            if (parameter is string inverse && inverse == "Inverse")
            {
                result = count == 0;
            }
            else
            {
                result = count > 0;
            }

            return result;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
