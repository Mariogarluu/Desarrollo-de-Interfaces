using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej2
{
    public class Exercise
    {
        public delegate void ValidarNumero(int x);

        //Crear método para la validación 'Mayor A Cero'
        public static void MayorACero(int x)
        {
            Console.WriteLine(x>0);
        }

        public static void EsPar(int x)
        {
            Console.WriteLine( x % 2 == 0);
        }

        public static void Main()
        {
            //Crear instancia del delegado con el nombre validate
            ValidarNumero validate = MayorACero;

            validate += EsPar;
            //Se imprime en consola el resultado
            validate(3);
        }
    }
}


