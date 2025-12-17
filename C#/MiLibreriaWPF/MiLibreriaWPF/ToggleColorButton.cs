using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

using System.Windows.Markup;
[assembly: XmlnsDefinition("http://miscontroles.com", "MiLibreriaWPF")]

namespace MiLibreriaWPF
{
    [TemplatePart(Name = "PART_BordePrincipal", Type = typeof(Border))]
    public class ToggleColorButton : Button
    {
        private Border _bordePrincipal;
        private bool _esVerde = false;

        static ToggleColorButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ToggleColorButton), new FrameworkPropertyMetadata(typeof(ToggleColorButton)));
        }

        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();
            _bordePrincipal = GetTemplateChild("PART_BordePrincipal") as Border;
            this.Click += ToggleColorButton_Click;
        }

        private void ToggleColorButton_Click(object sender, RoutedEventArgs e)
        {
            if (_bordePrincipal != null)
            {
                _bordePrincipal.Background = _esVerde ? Brushes.Blue : Brushes.Green;
                _esVerde = !_esVerde;
            }
        }
    }
}