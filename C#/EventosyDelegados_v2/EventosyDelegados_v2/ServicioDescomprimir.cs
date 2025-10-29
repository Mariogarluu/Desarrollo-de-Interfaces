using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventosyDelegados_v2
{
    public class ServicioDescomprimir
    {
        public void EnArchivoDescargado(object fuente, ArchivoEventArgs args)
        {
            Console.WriteLine($"[Descomprimir] Archivo {args.Archivo.Nombre} descomprimido correctamente.");
        }
    }
}
