using System.Windows;

namespace ej5
{
    public partial class Ejercicio5 : Window
    {
        private bool isUpdating = false;

        public Ejercicio5()
        {
            InitializeComponent();
        }

        private void ChkTodos_Click(object sender, RoutedEventArgs e)
        {
            if (isUpdating) return;

            isUpdating = true;
            bool newState = chkTodos.IsChecked == true;

            chkDI.IsChecked = newState;
            chkSGE.IsChecked = newState;
            chkAD.IsChecked = newState;

            isUpdating = false;
        }

        private void SubCheck_Click(object sender, RoutedEventArgs e)
        {
            if (isUpdating) return;

            isUpdating = true;
            int checkedCount = 0;
            if (chkDI.IsChecked == true) checkedCount++;
            if (chkSGE.IsChecked == true) checkedCount++;
            if (chkAD.IsChecked == true) checkedCount++;

            if (checkedCount == 3)
            {
                chkTodos.IsChecked = true;
            }
            else if (checkedCount == 0)
            {
                chkTodos.IsChecked = false;
            }
            else
            {
                chkTodos.IsChecked = null;
            }
            isUpdating = false;
        }
    }
}