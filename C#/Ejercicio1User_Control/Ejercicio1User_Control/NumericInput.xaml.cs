using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Ejercicio1User_Control.Controls
{
    public partial class NumericInput : UserControl
    {
        public NumericInput() { InitializeComponent(); }

        // DP: Valor (TwoWay para poder obtener el dato desde fuera)
        public static readonly DependencyProperty ValorProperty =
            DependencyProperty.Register("Valor", typeof(string), typeof(NumericInput),
                new FrameworkPropertyMetadata(string.Empty, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));
        public string Valor
        {
            get { return (string)GetValue(ValorProperty); }
            set { SetValue(ValorProperty, value); }
        }

        // DP: MaxLength
        public static readonly DependencyProperty MaxLengthProperty =
            DependencyProperty.Register("MaxLength", typeof(int), typeof(NumericInput), new PropertyMetadata(0));
        public int MaxLength
        {
            get { return (int)GetValue(MaxLengthProperty); }
            set { SetValue(MaxLengthProperty, value); }
        }

        // Validación: Solo permitir números
        private void TextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }
    }
}