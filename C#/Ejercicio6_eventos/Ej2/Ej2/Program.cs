using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej2
{
    internal class Program
    {
        /*
         * Diseña una clase ControlTemperatura que supervise la temperatura del invernadero y
         * emita el evento TemperaturaAlta cuando la temperatura exceda un umbral. Usa
         * TemperaturaEventArgs para transmitir la temperatura actual y el umbral. Crea las clases
         * ServicioAlerta y ServicioRegistroTemperatura para manejar este evento:
         * • ServicioAlerta enviará una alerta en consola.
         * • ServicioRegistroTemperatura registrará la temperatura en consola
        */

        static void Main(string[] args)
        {
            // Umbral de ejemplo
            double umbral = 30.0;

            var controlador = new ControlTemperatura(umbral);
            var alerta = new ServicioAlerta();
            var registro = new ServicioRegistroTemperatura();

            // Suscribirse al evento
            controlador.TemperaturaAlta += alerta.OnTemperaturaAlta;
            controlador.TemperaturaAlta += registro.OnTemperaturaAlta;

            // Simular lecturas
            double[] lecturas = { 25.3, 29.9, 30.0, 30.1, 35.7 };
            foreach (var temp in lecturas)
            {
                Console.WriteLine($"Lectura: {temp}°C");
                controlador.Supervisar(temp);
            }

            Console.WriteLine("Pulse una tecla para salir...");
            Console.ReadKey();
        }
    }

    // EventArgs que transporta la temperatura actual y el umbral
    public class TemperaturaEventArgs : EventArgs
    {
        public double TemperaturaActual { get; }
        public double Umbral { get; }

        public TemperaturaEventArgs(double temperaturaActual, double umbral)
        {
            TemperaturaActual = temperaturaActual;
            Umbral = umbral;
        }
    }

    // Clase que supervisa la temperatura y emite TemperaturaAlta cuando la temperatura excede el umbral
    public class ControlTemperatura
    {
        private readonly double _umbral;

        public event EventHandler<TemperaturaEventArgs> TemperaturaAlta;

        public ControlTemperatura(double umbral)
        {
            _umbral = umbral;
        }

        // Llamar con cada lectura de temperatura
        public void Supervisar(double temperatura)
        {
            if (temperatura > _umbral)
            {
                OnTemperaturaAlta(new TemperaturaEventArgs(temperatura, _umbral));
            }
        }

        protected virtual void OnTemperaturaAlta(TemperaturaEventArgs e)
        {
            TemperaturaAlta?.Invoke(this, e);
        }
    }

    // Servicio que envía una alerta por consola
    public class ServicioAlerta
    {
        public void OnTemperaturaAlta(object sender, TemperaturaEventArgs e)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"ALERTA: temperatura {e.TemperaturaActual}°C excede el umbral {e.Umbral}°C!");
            Console.ResetColor();
        }
    }

    // Servicio que registra la temperatura en consola
    public class ServicioRegistroTemperatura
    {
        public void OnTemperaturaAlta(object sender, TemperaturaEventArgs e)
        {
            Console.WriteLine($"Registro: {DateTime.Now:yyyy-MM-dd HH:mm:ss} - temperatura: {e.TemperaturaActual}°C (umbral {e.Umbral}°C)");
        }
    }
}
