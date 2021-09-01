using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace Orez360.Libraries.Converters
{
    public class ColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string Cor = (string)value;
            switch(Cor)
            {
                case "Roxo":
                    return Color.FromHex("#C45CA4");
                case "Laranja":
                    return Color.FromHex("#DF6E57");
                default:
                    return Color.FromHex("#5CBCC4");
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
