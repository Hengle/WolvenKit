using System;
using System.Reactive.Linq;
using System.Windows;
using System.Windows.Controls;
using ReactiveUI;
using WolvenKit.RED4.Types;

namespace WolvenKit.Views.Editors
{
    /// <summary>
    /// Interaction logic for RedStringEditor.xaml
    /// </summary>
    public partial class RedStringEditor : UserControl
    {
        public RedStringEditor()
        {
            InitializeComponent();
            //TextBox.TextChanged += TextBox_TextChanged;

            // causes things to be redrawn :/
            Observable.FromEventPattern<TextChangedEventHandler, TextChangedEventArgs>(
                handler => TextBox.TextChanged += handler,
                handler => TextBox.TextChanged -= handler)
                .Throttle(TimeSpan.FromSeconds(.5))
                .ObserveOn(RxApp.MainThreadScheduler)
                .Subscribe(x =>
                {
                    SetRedValue(TextBox.Text);
                });

        }

        public CString RedString
        {
            get => (CString)GetValue(RedStringProperty);
            set => SetValue(RedStringProperty, value);
        }
        public static readonly DependencyProperty RedStringProperty = DependencyProperty.Register(
            nameof(RedString), typeof(CString), typeof(RedStringEditor), new PropertyMetadata(default(CString)));


        public string Text
        {
            get => GetValueFromRedValue();
            set => SetRedValue(value);
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e) => SetRedValue(TextBox.Text);

        private void SetRedValue(string value) => SetCurrentValue(RedStringProperty, (CString)value);

        private string GetValueFromRedValue()
        {
            var redvalue = (string)RedString;
            if (redvalue is string redstring)
            {
                return redstring;
            }
            else if (redvalue is null)
            {
                return "";
            }
            else
            {
                throw new ArgumentException(nameof(redvalue));
            }
        }


    }
}
