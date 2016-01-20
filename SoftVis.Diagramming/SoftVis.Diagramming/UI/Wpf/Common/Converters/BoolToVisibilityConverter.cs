﻿using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace Codartis.SoftVis.UI.Wpf.Common.Converters
{
    /// <summary>
    /// Converts True value to Visibility.Visible, False value to Visibility.Collapsed.
    /// </summary>
    public class BoolToVisibilityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (!(value is bool))
                throw new ArgumentException("Bool value expected.");

            return (bool)value ? Visibility.Visible : Visibility.Collapsed;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
