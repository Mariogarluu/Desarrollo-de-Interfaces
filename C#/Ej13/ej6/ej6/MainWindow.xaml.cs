using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace ej6
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CmbTemas_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cmbTemas.SelectedItem is ComboBoxItem item)
            {
                string tema = item.Tag.ToString();

                switch (tema)
                {
                    case "Claro":
                        ventanaPrincipal.Background = Brushes.White;
                        txtDemo.Foreground = Brushes.Black;
                        txtDemo.FontSize = 14;
                        break;
                    case "Oscuro":
                        ventanaPrincipal.Background = Brushes.Black;
                        txtDemo.Foreground = Brushes.White;
                        txtDemo.FontSize = 18;
                        break;
                    case "Azul":
                        ventanaPrincipal.Background = Brushes.Blue;
                        txtDemo.Foreground = Brushes.White;
                        txtDemo.FontSize = 16;
                        break;
                }
            }
        }
    }
}