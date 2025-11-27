using System.Windows;
using System.Windows.Documents;
using System.Windows.Media;

namespace ej6
{
    public partial class Ejercicio6 : Window
    {
        public Ejercicio6()
        {
            InitializeComponent();
            EstablecerTextoInicial();
        }

        private void EstablecerTextoInicial()
        {
            tbResultado.Inlines.Clear();
            tbResultado.Inlines.Add(new Span(new Run("Texto en negrita"))
            {
                FontWeight = FontWeights.Bold,
                Foreground = Brushes.Blue
            });
            tbResultado.Inlines.Add(new Run(" y "));
            tbResultado.Inlines.Add(new Run("texto en cursiva")
            {
                FontStyle = FontStyles.Italic,
                Foreground = Brushes.Red
            });
        }

        private void BtnActualizar_Click(object sender, RoutedEventArgs e)
        {
            tbResultado.Inlines.Clear();

            if (chkAlternativo.IsChecked == true)
            {
                Run runSubrayado = new Run("Una parte subrayada");
                runSubrayado.TextDecorations = TextDecorations.Underline;
                tbResultado.Inlines.Add(runSubrayado);

                tbResultado.Inlines.Add(new Run(" y una palabra en "));

                tbResultado.Inlines.Add(new Run("negrita")
                {
                    FontWeight = FontWeights.Bold
                });
            }
            else
            {
                tbResultado.Inlines.Add(new Run("Texto simple sin formato."));
            }
        }
    }
}