using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventosyDelegados_v2
{
    public class ArchivoEventArgs : EventArgs
    {
        public Archivo Archivo { get; }

        public ArchivoEventArgs(Archivo archivo)
        {
            Archivo = archivo;
        }
    }
}
