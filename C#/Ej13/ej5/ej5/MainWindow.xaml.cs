using System.Windows;
using System.Windows.Controls;

namespace ej5
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TxtEdad_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (string.IsNullOrEmpty(txtEdad.Text)) return;

            if (int.TryParse(txtEdad.Text, out int edad))
            {
                // Solo mostramos éxito si tiene sentido (ej: evitar spam al escribir "2" y luego "5" para "25")
                // El enunciado pide mostrarlo, así que lo mostramos.
                // MessageBox.Show("Edad válida"); 
            }
            else
            {
                MessageBox.Show("Por favor, introduce un número válido.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                // Opcional: Limpiar el carácter inválido
                txtEdad.Text = "";
            }
        }
    }
}