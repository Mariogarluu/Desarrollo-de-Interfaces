using System.Windows;

namespace ej4
{
    public partial class Ejercicio4 : Window
    {
        public Ejercicio4()
        {
            InitializeComponent();
        }

        private void BtnVerificar_Click(object sender, RoutedEventArgs e)
        {
            if (pwdInput.Password.Length > 6)
            {
                string nivel = rbBajo.IsChecked == true ? "Bajo" :
                               (rbMedio.IsChecked == true ? "Medio" : "Alto");

                MessageBox.Show($"Nivel: {nivel}\nContraseña: {pwdInput.Password}");
            }
            else
            {
                MessageBox.Show("Advertencia: La contraseña debe tener más de 6 caracteres.",
                                "Seguridad insuficiente", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
    }
}