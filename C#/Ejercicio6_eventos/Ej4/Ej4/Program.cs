using System;
using System.Threading;

namespace Ej4
{
    /*
     * Crea un sistema de monitoreo para una casa inteligente que controle el estado de
     * puertas y ventanas. Diseña una clase SensorMonitoreo que emita el evento
     * AlertaIntruso cuando se detecta una puerta o ventana abierta fuera del horario
     * CFGS Desarrollo de Aplicaciones Multiplataforma
     * Módulo: Desarrollo de Interfaces
     * permitido. Usa IntrusoEventArgs para incluir detalles del sensor (nombre de la
     * puerta/ventana y la hora de detección). Crea dos servicios que respondan a este evento:
     * • ServicioAlarma activa una alarma.
     * • ServicioRegistroIncidencias guarda un registro en la base de datos.
     */

    // Clase que hereda de EventArgs
    public class IntrusoEventArgs : EventArgs
    {
        public string Sensor { get; }
        public DateTime HoraDeteccion { get; }

        public IntrusoEventArgs(string sensor, DateTime horaDeteccion)
        {
            Sensor = sensor;
            HoraDeteccion = horaDeteccion;
        }
    }

    // Clase principal del sistema de monitoreo
    public class SensorMonitoreo
    {
        // Evento
        public event EventHandler<IntrusoEventArgs> AlertaIntruso;

        // Método para simular detección de intruso
        public void DetectarIntruso(string sensor)
        {
            Console.WriteLine($"🔍 Verificando sensor: {sensor}...");

            Thread.Sleep(1000); // simulamos tiempo de detección

            DateTime hora = DateTime.Now;
            Console.WriteLine($"🚨 Intrusión detectada por {sensor} a las {hora:T}");

            // Lanzamos el evento con Invoke
            AlertaIntruso?.Invoke(this, new IntrusoEventArgs(sensor, hora));
        }
    }

    // Servicio que activa la alarma
    public class ServicioAlarma
    {
        public void ActivarAlarma(object sender, IntrusoEventArgs e)
        {
            Console.WriteLine($"🔔 [ALERTA] Alarma activada por {e.Sensor} a las {e.HoraDeteccion:T}");
        }
    }

    // Servicio que guarda el registro
    public class ServicioRegistroIncidencias
    {
        public void RegistrarIncidencia(object sender, IntrusoEventArgs e)
        {
            Console.WriteLine($"📝 [REGISTRO] Incidencia registrada: Sensor={e.Sensor}, Hora={e.HoraDeteccion}");
        }
    }

    // Programa principal con menú de prueba
    internal class Program
    {
        static void Main(string[] args)
        {
            SensorMonitoreo sensor = new SensorMonitoreo();
            ServicioAlarma alarma = new ServicioAlarma();
            ServicioRegistroIncidencias registro = new ServicioRegistroIncidencias();

            // Suscripción a eventos
            sensor.AlertaIntruso += alarma.ActivarAlarma;
            sensor.AlertaIntruso += registro.RegistrarIncidencia;

            string opcion;
            do
            {
                Console.WriteLine("\n=== SISTEMA DE MONITOREO ===");
                Console.WriteLine("1. Detectar intruso (Puerta Principal)");
                Console.WriteLine("2. Detectar intruso (Ventana Cocina)");
                Console.WriteLine("3. Detectar intruso (Puerta Garaje)");
                Console.WriteLine("0. Salir");
                Console.Write("Seleccione una opción: ");
                opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        sensor.DetectarIntruso("Puerta Principal");
                        break;
                    case "2":
                        sensor.DetectarIntruso("Ventana Cocina");
                        break;
                    case "3":
                        sensor.DetectarIntruso("Puerta Garaje");
                        break;
                }

            } while (opcion != "0");
        }
    }
}

