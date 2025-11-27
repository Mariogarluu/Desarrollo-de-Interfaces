using System.Windows;
using System.Windows.Media;

namespace ej2
{
    public partial class Ejercicio2 : Window
    {
        private int intentos = 0;
        private const int MAX_INTENTOS = 2;

        public Ejercicio2()
        {
            InitializeComponent();
        }

        private void BtnCorregir_Click(object sender, RoutedEventArgs e)
        {
            // 1. Verificar si es correcto
            if (rbCSharp.IsChecked == true)
            {
                MessageBox.Show("¡Correcto! Has seleccionado C#.");
                FinalizarJuego(true);
                return;
            }

            // 2. Lógica de intentos fallidos
            intentos++;
            int restantes = MAX_INTENTOS - intentos;

            if (restantes > 0)
            {
                MessageBox.Show("Incorrecto.");
                txtIntentos.Text = $"Incorrecto. Te quedan {restantes} intento(s).";
            }
            else
            {
                MessageBox.Show("Has agotado tus intentos.");
                FinalizarJuego(false);
            }
        }

        private void FinalizarJuego(bool ganado)
        {
            btnCorregir.IsEnabled = false;
            rbJava.IsEnabled = false;
            rbPython.IsEnabled = false;
            rbCSharp.IsEnabled = false;
            rbJS.IsEnabled = false;

            if (ganado)
            {
                txtIntentos.Text = "¡Respuesta Correcta!";
                txtIntentos.Foreground = Brushes.Green;
            }
            else
            {
                txtIntentos.Text = "No te quedan intentos. La respuesta era C#.";
                txtIntentos.Foreground = Brushes.Red;
            }
        }
    }
}