using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace ClinicApp.XamlPages
{
    public class AgeConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            DateTime birthDate = (DateTime)value;
            int yearDifference = DateTime.Now.Year - birthDate.Year;
            return yearDifference + (birthDate.AddYears(yearDifference) >= DateTime.Now ? 1 : 0);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return string.Empty;
        }
    }
}
