using System.Windows;

namespace ej1
{
    public partial class MainWindow : Window
    {
        public double TamañoTexto
        {
            get { return (double)GetValue(TamañoTextoProperty); }
            set { SetValue(TamañoTextoProperty, value); }
        }

        public static readonly DependencyProperty TamañoTextoProperty =
            DependencyProperty.Register("TamañoTexto", typeof(double), typeof(MainWindow), new PropertyMetadata(12.0));

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            TamañoTexto += 2;
        }
    }
}