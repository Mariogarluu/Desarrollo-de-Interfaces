using System.Windows;
using System.Windows.Controls;

namespace Ejercicio1User_Control.Controls
{
    public partial class CoordinateDisplay : UserControl
    {
        public CoordinateDisplay() { InitializeComponent(); }

        public static readonly DependencyProperty TituloProperty =
            DependencyProperty.Register("Titulo", typeof(string), typeof(CoordinateDisplay), new PropertyMetadata("Coordenadas"));
        public string Titulo
        {
            get { return (string)GetValue(TituloProperty); }
            set { SetValue(TituloProperty, value); }
        }

        // DP tipo double
        public static readonly DependencyProperty CoordenadaXProperty =
            DependencyProperty.Register("CoordenadaX", typeof(double), typeof(CoordinateDisplay), new PropertyMetadata(0.0));
        public double CoordenadaX
        {
            get { return (double)GetValue(CoordenadaXProperty); }
            set { SetValue(CoordenadaXProperty, value); }
        }

        public static readonly DependencyProperty CoordenadaYProperty =
            DependencyProperty.Register("CoordenadaY", typeof(double), typeof(CoordinateDisplay), new PropertyMetadata(0.0));
        public double CoordenadaY
        {
            get { return (double)GetValue(CoordenadaYProperty); }
            set { SetValue(CoordenadaYProperty, value); }
        }
    }
}