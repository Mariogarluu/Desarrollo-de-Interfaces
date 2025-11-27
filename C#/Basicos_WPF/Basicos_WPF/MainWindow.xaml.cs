using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Basicos_WPF
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        // Botón 1: Mostrar el Grid (Ejercicio 3)
        private void MostrarGrid_Click(object sender, RoutedEventArgs e)
        {
            GridEjercicio3.Visibility = Visibility.Visible;
            TextoCentrado.Visibility = Visibility.Collapsed;
        }

        // Botón 2: Mostrar el "Hola Mundo" (Ejercicio 1)
        private void MostrarTexto_Click(object sender, RoutedEventArgs e)
        {
            TextoCentrado.Visibility = Visibility.Visible;
            GridEjercicio3.Visibility = Visibility.Collapsed;
        }
    }
}