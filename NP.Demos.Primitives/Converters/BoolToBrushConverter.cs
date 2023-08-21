using Avalonia.Data.Converters;
using Avalonia.Media;
using System;
using System.Globalization;

// Basic sample to learn about IValueConverter and IMultiValueConverter. 
// https://github.com/dolbilov/ValueConvertersSample

namespace NP.Demos.Primitives.Converters
{
    public class BoolToBrushConverter : IValueConverter
    {
        public IBrush? FalseBrush { get; set; }
        public IBrush? TrueBrush { get; set; }

        public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            if (value is bool b)
            {
                return b ? TrueBrush : FalseBrush;
            }

            return FalseBrush;
        }

        public object ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
