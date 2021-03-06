﻿namespace MajorLeagueMiruken.Wpf.App.Features
{
    using System;
    using System.Globalization;
    using System.Windows.Data;
    using Api;

    public class ColorEnumToStringConverter: IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value != null) return value.ToString();
            return "Gray";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            Color col;
            if (value != null && Enum.TryParse(value.ToString(), true, out col))
            {
                return col;
            }
            return Color.Orange;
        }
    }
}
