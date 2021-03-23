using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace Menu
{
    public class NumberToDayConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            try
            {
                switch ((int)value) 
                {
                    case 0: return "Poniedziałek";
                    case 1: return "Wtorek";
                    case 2: return "Środa";
                    case 3: return "Czwartek";
                    case 4: return "Piątek";
                    case 5: return "Sobota";
                    case 6: return "Niedziela";
                } 
            }
            catch (Exception)
            {

            }
            return null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
