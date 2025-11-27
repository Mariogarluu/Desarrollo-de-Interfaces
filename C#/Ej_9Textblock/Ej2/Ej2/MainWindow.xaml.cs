using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Ej2
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Grid grid = new Grid();
            Button boton = new Button { FontWeight = FontWeights.Bold, Width = 200, Height = 80 };
            WrapPanel panel = new WrapPanel();

            panel.Children.Add(new TextBlock { Text = "Verde", Foreground = Brushes.Green, Margin = new Thickness(5) });
            panel.Children.Add(new TextBlock { Text = "Azul", Foreground = Brushes.Blue, Margin = new Thickness(5) });
            panel.Children.Add(new TextBlock { Text = "Normal", Margin = new Thickness(5) });

            boton.Content = panel;
            grid.Children.Add(boton);
            Content = grid;
        }
    }
}