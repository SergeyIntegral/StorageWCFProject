using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;

namespace Storage.Views.converters
{
    public class NullToVisibilityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            bool isNull = value == null;
            Visibility nullResult = Visibility.Collapsed;
            Visibility notNullResult = Visibility.Visible;

            if (parameter is Visibility)
            {
                nullResult = (Visibility)parameter;

                notNullResult = nullResult == Visibility.Visible
                    ? Visibility.Collapsed
                    : Visibility.Visible;
            }

            return isNull ? nullResult : notNullResult;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}