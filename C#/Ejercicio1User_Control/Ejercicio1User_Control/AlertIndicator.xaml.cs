using System.Windows;
using System.Windows.Controls;

namespace Ejercicio1User_Control.Controls
{
    public partial class AlertIndicator : UserControl
    {
        public AlertIndicator() { InitializeComponent(); }

        public static readonly DependencyProperty MensajePrincipalProperty =
            DependencyProperty.Register("MensajePrincipal", typeof(string), typeof(AlertIndicator), new PropertyMetadata("Estado"));
        public string MensajePrincipal
        {
            get { return (string)GetValue(MensajePrincipalProperty); }
            set { SetValue(MensajePrincipalProperty, value); }
        }

        public static readonly DependencyProperty AlertaActivaProperty =
            DependencyProperty.Register("AlertaActiva", typeof(bool), typeof(AlertIndicator), new PropertyMetadata(false));
        public bool AlertaActiva
        {
            get { return (bool)GetValue(AlertaActivaProperty); }
            set { SetValue(AlertaActivaProperty, value); }
        }

        public static readonly DependencyProperty MensajeAdvertenciaProperty =
            DependencyProperty.Register("MensajeAdvertencia", typeof(string), typeof(AlertIndicator), new PropertyMetadata("¡Advertencia!"));
        public string MensajeAdvertencia
        {
            get { return (string)GetValue(MensajeAdvertenciaProperty); }
            set { SetValue(MensajeAdvertenciaProperty, value); }
        }
    }
}