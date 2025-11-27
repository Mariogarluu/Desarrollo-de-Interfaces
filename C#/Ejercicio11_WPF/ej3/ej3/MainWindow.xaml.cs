using System.Windows;

namespace ej3
{
    public partial class Ejercicio3 : Window
    {
        public Ejercicio3()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {
            if (txtUser.Text == "admin" && txtPass.Password == "1234")
            {
                MessageBox.Show("Login correcto.");
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos.");
            }
        }
    }
}