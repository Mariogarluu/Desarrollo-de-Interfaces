using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace EventosyDelegados_v2
{
    public class AsistenteDescarga
    {
        // Usamos el delegado estándar de .NET con tipo genérico
        public event EventHandler<ArchivoEventArgs> ArchivoDescargado;

        protected virtual void OnArchivoDescargado(Archivo archivo)
        {
            ArchivoDescargado?.Invoke(this, new ArchivoEventArgs(archivo));
        }

        public void Descargar(Archivo archivo)
        {
            Console.WriteLine($"Descargando archivo: {archivo.Nombre}...");
            Thread.Sleep(2000);
            OnArchivoDescargado(archivo);
        }
    }
}
