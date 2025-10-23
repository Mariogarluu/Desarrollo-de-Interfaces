using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_Delegados
{
    public class Exercise
    {
        public delegate bool ValidarNumero(int x);

        //Crear método para la validación 'Mayor A Cero'
        public static bool MayorACero(int x)
        {
            return x > 0;
        }

        public static void Main()
        {
            //Crear instancia del delegado con el nombre validate
            ValidarNumero validate = MayorACero;

            //Se imprime en consola el resultado
            Console.WriteLine(validate(-2));
        }
    }
}
