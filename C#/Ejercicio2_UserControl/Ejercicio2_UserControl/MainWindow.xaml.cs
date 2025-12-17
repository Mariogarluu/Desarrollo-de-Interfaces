using System.Windows;

namespace Ejercicio2_UserControl
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = this; // Necesario para los bindings
        }

        // DP Puntuacion (Ejercicio 5)
        public static readonly DependencyProperty PuntuacionProperty =
            DependencyProperty.Register("Puntuacion", typeof(int), typeof(MainWindow), new PropertyMetadata(50));

        public int Puntuacion
        {
            get { return (int)GetValue(PuntuacionProperty); }
            set { SetValue(PuntuacionProperty, value); }
        }
    }
}