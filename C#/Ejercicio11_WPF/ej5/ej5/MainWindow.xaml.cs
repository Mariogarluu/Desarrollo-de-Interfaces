using System.Windows;

namespace ej5
{
    public partial class Ejercicio5 : Window
    {
        public Ejercicio5()
        {
            InitializeComponent();
        }

        private void BtnPagar_Click(object sender, RoutedEventArgs e)
        {
            bool metodoSeleccionado = rbTarjeta.IsChecked == true ||
                                      rbPayPal.IsChecked == true ||
                                      rbTransferencia.IsChecked == true;

            if (metodoSeleccionado && pwdPin.Password == "1234")
            {
                MessageBox.Show("El pago se ha realizado con éxito.");
            }
            else
            {
                MessageBox.Show("Error: Verifique el método de pago o la contraseña.",
                                "Error de Pago", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}