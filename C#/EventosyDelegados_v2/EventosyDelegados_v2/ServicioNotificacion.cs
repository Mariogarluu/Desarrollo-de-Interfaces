using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventosyDelegados_v2
{
    public class ServicioNotificacion
    {
        public void EnArchivoDescargado(object fuente, ArchivoEventArgs args)
        {
            Console.WriteLine($"[Notificación] Se ha completado la descarga del archivo: {args.Archivo.Nombre}");
        }
    }
}
