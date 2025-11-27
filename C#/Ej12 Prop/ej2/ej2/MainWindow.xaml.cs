using System.Windows;
using System.Windows.Media;

namespace ej2
{
    public partial class MainWindow : Window
    {
        // El Wrapper de la propiedad
        public Brush ColorDeFondoTexto
        {
            get { return (Brush)GetValue(ColorDeFondoTextoProperty); }
            set { SetValue(ColorDeFondoTextoProperty, value); }
        }

        // El registro de la DependencyProperty
        public static readonly DependencyProperty ColorDeFondoTextoProperty =
            DependencyProperty.Register(
                "ColorDeFondoTexto",         
                typeof(Brush),           
                typeof(MainWindow), 
                new PropertyMetadata(Brushes.White));

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ColorDeFondoTexto = Brushes.LightBlue;
        }
    }
}