using System;
using System.Globalization;
using System.Windows.Data;
using Nodify;
using WolvenKit.App.ViewModels.Documents;

namespace WolvenKit.App.Converters;

public class FlowToDirectionConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        if (value is ConnectorFlow flow)
        {
            return flow == ConnectorFlow.Output ? ConnectionDirection.Forward : ConnectionDirection.Backward;
        }

        return value;
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        if (value is ConnectionDirection dir)
        {
            return dir == ConnectionDirection.Forward ? ConnectorFlow.Output : ConnectorFlow.Input;
        }

        return value;
    }
}
