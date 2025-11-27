using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ej5
{
    /*
     * Diseña una clase MonitorEnergia que registre el consumo de energía y emita el evento
     * ConsumoExcesivoDetectado cuando el consumo supere un umbral establecido. Usa
     * EnergiaEventArgs para proporcionar el consumo actual y el umbral. Implementa las
     * clases ServicioNotificacion y ServicioAjusteAutomatizado:
     * • ServicioNotificacion envía una advertencia al usuario.
     * • ServicioAjusteAutomatizado ajusta automáticamente los dispositivos para
     * reducir el consumo. 
     */

    // 🔹 Clase EventArgs personalizada
    public class EnergiaEventArgs : EventArgs
    {
        public double ConsumoActual { get; }
        public double Umbral { get; }

        public EnergiaEventArgs(double consumoActual, double umbral)
        {
            ConsumoActual = consumoActual;
            Umbral = umbral;
        }
    }

    // 🔹 Clase principal que emite el evento
    public class MonitorEnergia
    {
        public event EventHandler<EnergiaEventArgs> ConsumoExcesivoDetectado;
        private readonly double umbral;

        public MonitorEnergia(double umbral)
        {
            this.umbral = umbral;
        }

        public void RegistrarConsumo(double consumo)
        {
            Console.WriteLine($"📊 Consumo actual: {consumo} kWh (Umbral: {umbral} kWh)");

            // Si se supera el umbral, lanzamos el evento
            if (consumo > umbral)
            {
                Console.WriteLine("⚠️  Consumo excesivo detectado.");
                ConsumoExcesivoDetectado?.Invoke(this, new EnergiaEventArgs(consumo, umbral));
            }
            else
            {
                Console.WriteLine("✅ Consumo dentro de los límites permitidos.");
            }
        }
    }

    // 🔹 Servicio que envía notificación al usuario
    public class ServicioNotificacion
    {
        public void EnviarAdvertencia(object sender, EnergiaEventArgs e)
        {
            Console.WriteLine($"📩 [NOTIFICACIÓN] Advertencia: Consumo de {e.ConsumoActual} kWh supera el umbral de {e.Umbral} kWh.");
        }
    }

    // 🔹 Servicio que ajusta automáticamente los dispositivos
    public class ServicioAjusteAutomatizado
    {
        public void AjustarDispositivos(object sender, EnergiaEventArgs e)
        {
            Console.WriteLine($"⚙️ [AJUSTE AUTOMÁTICO] Reducción de potencia iniciada para equilibrar el consumo.");
            Thread.Sleep(1000);
            Console.WriteLine($"🔋 Dispositivos ajustados correctamente. Nuevo consumo estimado: {e.Umbral * 0.95:F2} kWh.");
        }
    }

    // 🔹 Programa principal de prueba
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== SISTEMA DE MONITOREO DE ENERGÍA ===");

            // Creamos el monitor con un umbral predefinido
            MonitorEnergia monitor = new MonitorEnergia(100.0);
            ServicioNotificacion notificacion = new ServicioNotificacion();
            ServicioAjusteAutomatizado ajuste = new ServicioAjusteAutomatizado();

            // Suscribimos los servicios al evento
            monitor.ConsumoExcesivoDetectado += notificacion.EnviarAdvertencia;
            monitor.ConsumoExcesivoDetectado += ajuste.AjustarDispositivos;

            string opcion;
            do
            {
                Console.Write("\nIngrese el consumo actual en kWh (0 para salir): ");
                opcion = Console.ReadLine();

                if (double.TryParse(opcion, out double consumo) && consumo != 0)
                {
                    monitor.RegistrarConsumo(consumo);
                }

            } while (opcion != "0");

            Console.WriteLine("\nSistema finalizado. 🔌");
        }
    }
}
