using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace WPFCanvas_practice;

public class Center : IValueConverter
{
    const double RADIUS = 50;
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        return (double)value - RADIUS;
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        return (double)value + RADIUS;
    }
}
