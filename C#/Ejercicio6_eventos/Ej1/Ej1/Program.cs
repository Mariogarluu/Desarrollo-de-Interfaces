using System;
using System.Collections.Generic;
using System.Threading;

namespace Ej1
{
    internal class Program
    {
        /*
         * Implementa un sistema que notifique y registre cada venta realizada. Crea una clase
         * RegistroVentas que actúe como emisor del evento VentaRealizada, junto con el método
         * ProcesarVenta para simular el proceso de una venta. Esta clase emitirá el evento usando
         * una instancia de VentaEventArgs que contiene información sobre la venta (producto y
         * precio). Crea dos clases receptoras: ServicioRegistro y ServicioNotificacion:
         * • ServicioRegistro tiene un método RegistrarVenta que guarda los detalles de la
         * venta.
         * • ServicioNotificacion tiene un método EnviarNotificacionVenta que envía una
         * notificación al usuario.
         */

        static void Main(string[] args)
        {
            var registroVentas = new RegistroVentas();
            var servicioRegistro = new ServicioRegistro();
            var servicioNotificacion = new ServicioNotificacion();

            // Suscripción a evento
            registroVentas.VentaRealizada += servicioRegistro.RegistrarVenta;
            registroVentas.VentaRealizada += servicioNotificacion.EnviarNotificacionVenta;

            // Simular ventas
            registroVentas.ProcesarVenta("Camiseta", 19.99m);
            registroVentas.ProcesarVenta("Gorra", 9.50m);
            registroVentas.ProcesarVenta("Mochila", 45.00m);

            Console.WriteLine();
            Console.WriteLine("Ventas registradas en memoria:");
            foreach (var v in servicioRegistro.Ventas)
            {
                Console.WriteLine($"{v.Fecha:yyyy-MM-dd HH:mm:ss} - {v.Producto} - {v.Precio:C}");
            }

            Console.WriteLine("\nPulsa una tecla para salir...");
            Console.ReadKey();
        }
    }

    // Argumentos del evento con información de la venta
    public class VentaEventArgs : EventArgs
    {
        public string Producto { get; }
        public decimal Precio { get; }
        public DateTime Fecha { get; }

        public VentaEventArgs(string producto, decimal precio)
        {
            Producto = producto;
            Precio = precio;
            Fecha = DateTime.Now;
        }
    }

    // Emisor del evento
    public class RegistroVentas
    {
        public event EventHandler<VentaEventArgs> VentaRealizada;

        protected virtual void OnVentaRealizada(VentaEventArgs e)
        {
            VentaRealizada?.Invoke(this, e);
        }

        public void ProcesarVenta(string producto, decimal precio)
        {
            // Simular procesamiento
            Console.WriteLine($"Procesando venta: {producto} - {precio:C}");
            Thread.Sleep(200); 
            var args = new VentaEventArgs(producto, precio);
            OnVentaRealizada(args);
        }
    }

    // Receptor que guarda las ventas en memoria
    public class ServicioRegistro
    {
        private readonly List<VentaEventArgs> _ventas = new List<VentaEventArgs>();

        public void RegistrarVenta(object sender, VentaEventArgs e)
        {
            _ventas.Add(e);
            Console.WriteLine($"[Registro] Venta guardada: {e.Producto} - {e.Precio:C} ({e.Fecha:HH:mm:ss})");
        }

        public IReadOnlyList<VentaEventArgs> Ventas => _ventas.AsReadOnly();
    }

    // Receptor que envía notificaciones (aquí: consola)
    public class ServicioNotificacion
    {
        public void EnviarNotificacionVenta(object sender, VentaEventArgs e)
        {
            Console.WriteLine($"[Notificación] Se ha vendido '{e.Producto}' por {e.Precio:C}.");
        }
    }
}
