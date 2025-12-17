using System.Windows;
using System.Windows.Controls;

using System.Windows.Markup;
[assembly: XmlnsDefinition("http://miscontroles.com", "MiLibreriaWPF")]

namespace MiLibreriaWPF
{
    public class BotonRedondo : Button
    {
        static BotonRedondo()
        {
            // Vincula el estilo del Generic.xaml a este control
            DefaultStyleKeyProperty.OverrideMetadata(typeof(BotonRedondo), new FrameworkPropertyMetadata(typeof(BotonRedondo)));
        }
    }
}