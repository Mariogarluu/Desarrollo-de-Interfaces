using System.Windows;
using System.Windows.Controls;

namespace Ejercicio1User_Control.Controls
{
    public partial class FixedLengthInput : UserControl
    {
        public FixedLengthInput() { InitializeComponent(); }

        public static readonly DependencyProperty ValorProperty =
            DependencyProperty.Register("Valor", typeof(string), typeof(FixedLengthInput),
                new FrameworkPropertyMetadata(string.Empty, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));
        public string Valor
        {
            get { return (string)GetValue(ValorProperty); }
            set { SetValue(ValorProperty, value); }
        }

        public static readonly DependencyProperty LongitudMaximaProperty =
            DependencyProperty.Register("LongitudMaxima", typeof(int), typeof(FixedLengthInput), new PropertyMetadata(10));
        public int LongitudMaxima
        {
            get { return (int)GetValue(LongitudMaximaProperty); }
            set { SetValue(LongitudMaximaProperty, value); }
        }

        public static readonly DependencyProperty PlaceholderProperty =
            DependencyProperty.Register("Placeholder", typeof(string), typeof(FixedLengthInput), new PropertyMetadata("Escriba aquí..."));
        public string Placeholder
        {
            get { return (string)GetValue(PlaceholderProperty); }
            set { SetValue(PlaceholderProperty, value); }
        }
    }
}