﻿using System;
using System.Globalization;
using System.Windows.Data;

namespace TicTacToe.Utilities.ValueConverters
{
    public class SymbolToColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if(value is char)
            {
                switch (value)
                {
                    case 'X':
                        return "Blue";
                    case 'O':
                        return "Red";
                    default:
                        return "Black";
                }
            }
            return "Black";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
