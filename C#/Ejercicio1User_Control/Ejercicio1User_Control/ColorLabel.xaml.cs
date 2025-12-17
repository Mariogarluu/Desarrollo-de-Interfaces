using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Ejercicio1User_Control.Controls
{
    public partial class ColorLabel : UserControl
    {
        public ColorLabel() { InitializeComponent(); }

        // DP: Texto
        public static readonly DependencyProperty TextoProperty =
            DependencyProperty.Register("Texto", typeof(string), typeof(ColorLabel), new PropertyMetadata(string.Empty));
        public string Texto
        {
            get { return (string)GetValue(TextoProperty); }
            set { SetValue(TextoProperty, value); }
        }

        // DP: ColorDeFondo (Usamos Brush para que XAML convierta strings como "Green" automáticamente)
        public static readonly DependencyProperty ColorDeFondoProperty =
            DependencyProperty.Register("ColorDeFondo", typeof(Brush), typeof(ColorLabel), new PropertyMetadata(Brushes.Transparent));
        public Brush ColorDeFondo
        {
            get { return (Brush)GetValue(ColorDeFondoProperty); }
            set { SetValue(ColorDeFondoProperty, value); }
        }
    }
}