using System.Windows;

namespace ej4
{
    public partial class Ejercicio4 : Window
    {
        public Ejercicio4()
        {
            InitializeComponent();
        }

        private void BtnAccion_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hola, " + txtNombre.Text);
        }
    }
}