using System.Windows;
using System.Windows.Controls;

namespace ej2
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (cmbCategoria.SelectedItem == null)
            {
                MessageBox.Show("Por favor selecciona una categoría primero.");
                return;
            }

            string accion = (sender as Button).Content.ToString();
            string categoria = (cmbCategoria.SelectedItem as ComboBoxItem).Content.ToString();

            MessageBox.Show($"Has realizado {accion} en la {categoria}.", "Información");
        }
    }
}