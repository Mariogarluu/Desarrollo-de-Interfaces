using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace ej3
{
    public partial class Ejercicio3 : Window
    {
        public Ejercicio3()
        {
            InitializeComponent();
        }

        private void Button_MouseEnter(object sender, MouseEventArgs e)
        {
            if (sender is Button btn)
            {
                MessageBox.Show("Propiedad (Fondo): " + btn.Background.ToString());
            }
        }
    }
}