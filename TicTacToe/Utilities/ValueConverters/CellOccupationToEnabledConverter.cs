using System;
using System.Globalization;
using System.Windows.Data;

namespace TicTacToe.Utilities.ValueConverters
{
    public class CellOccupationToEnabledConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is char)
            {
                switch (value)
                {
                    case 'X':
                    case 'O':
                        return "False";
                    default:
                        return "True";
                }
            }
            return "True";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
