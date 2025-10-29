using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace EventosyDelegados_v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AsistenteDescarga asistente = new AsistenteDescarga();
            ServicioDescomprimir descomprimir = new ServicioDescomprimir();
            ServicioNotificacion notificacion = new ServicioNotificacion();

            // Suscribimos los receptores al evento
            asistente.ArchivoDescargado += descomprimir.EnArchivoDescargado;
            asistente.ArchivoDescargado += notificacion.EnArchivoDescargado;

            Archivo archivo = new Archivo("Manual_CSharp.pdf");
            asistente.Descargar(archivo);

            Console.ReadKey();
        }
    }
}
