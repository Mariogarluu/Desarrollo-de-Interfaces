using System.Windows;

namespace ej3
{
    public partial class MainWindow : Window
    {
        public string TextoUsuario
        {
            get { return (string)GetValue(TextoUsuarioProperty); }
            set { SetValue(TextoUsuarioProperty, value); }
        }

        public static readonly DependencyProperty TextoUsuarioProperty =
            DependencyProperty.Register("TextoUsuario", typeof(string), typeof(MainWindow), new PropertyMetadata("Texto Inicial"));

        public MainWindow()
        {
            InitializeComponent();
        }
    }
}