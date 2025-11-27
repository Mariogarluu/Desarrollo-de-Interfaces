using System.Windows;
using System.Windows.Controls;

namespace ej2
{
    public partial class Ejercicio2 : Window
    {
        public Ejercicio2()
        {
            InitializeComponent();
        }

        private void TxtInput_SelectionChanged(object sender, RoutedEventArgs e)
        {
            txtOutput.Text = "Has seleccionado " + txtInput.SelectedText;
        }
    }
}