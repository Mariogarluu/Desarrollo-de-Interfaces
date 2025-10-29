using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace EventosyDelegados_v2
{
    public class AsistenteDescarga
    {
        //Metodo que simula la descarga esperando 4 segundos a través de un Thread
        public void Descargar(Archivo archivo)
        {
            Console.WriteLine($"Iniciando descarga de {archivo.Titulo}");
            Thread.Sleep(4000);
            Console.WriteLine($"Descarga de {archivo.Titulo} completada");
        }
    }
}
