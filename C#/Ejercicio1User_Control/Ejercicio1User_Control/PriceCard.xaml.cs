using System.Windows;
using System.Windows.Controls;

namespace Ejercicio1User_Control.Controls
{
    public partial class PriceCard : UserControl
    {
        public PriceCard() { InitializeComponent(); }

        public static readonly DependencyProperty PrecioProperty =
            DependencyProperty.Register("Precio", typeof(string), typeof(PriceCard), new PropertyMetadata("€0.00"));
        public string Precio
        {
            get { return (string)GetValue(PrecioProperty); }
            set { SetValue(PrecioProperty, value); }
        }

        public static readonly DependencyProperty DescripcionProperty =
            DependencyProperty.Register("Descripcion", typeof(string), typeof(PriceCard), new PropertyMetadata(string.Empty));
        public string Descripcion
        {
            get { return (string)GetValue(DescripcionProperty); }
            set { SetValue(DescripcionProperty, value); }
        }
    }
}