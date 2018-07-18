using System;
using System.Globalization;
using System.Windows.Data;

namespace TicTacToe.Utilities.ValueConverters
{
    public class GameOverToHitTestVisibleConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is bool)
            {
                switch (value)
                {
                    case false:
                        return "True";
                    case true:
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
