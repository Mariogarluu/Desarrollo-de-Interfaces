using System;
using System.Globalization;
using System.Windows.Data;

namespace Ejercicio2_UserControl.Converters
{
    // Este traductor recibe un número y devuelve TRUE si es mayor que el parámetro que le pasemos
    public class EsMayorQueConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            // Verificamos que el valor sea un entero (la puntuación)
            if (value is int puntuacion && parameter != null)
            {
                // Convertimos el parámetro (el "75") a número
                int umbral = int.Parse(parameter.ToString());

                // Devolvemos VERDADERO si la puntuación supera el umbral
                return puntuacion > umbral;
            }
            return false;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}