using System.Windows;
using System.Windows.Controls;

namespace ej4
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnConfirmar_Click(object sender, RoutedEventArgs e)
        {
            if (cmbFrutas.SelectedItem == null) return;

            string fruta = (cmbFrutas.SelectedItem as ComboBoxItem).Content.ToString();

            MessageBoxResult resultado = MessageBox.Show(
                $"¿Quieres confirmar tu selección de {fruta}?",
                "Confirmación",
                MessageBoxButton.YesNoCancel,
                MessageBoxImage.Question);

            switch (resultado)
            {
                case MessageBoxResult.Yes:
                    MessageBox.Show($"Has confirmado {fruta}.", "Confirmado", MessageBoxButton.OK, MessageBoxImage.Information);
                    break;
                case MessageBoxResult.No:
                    MessageBox.Show($"Has rechazado {fruta}.", "Rechazado");
                    break;
                case MessageBoxResult.Cancel:
                    MessageBox.Show("No se realizó ninguna acción.");
                    break;
            }
        }
    }
}