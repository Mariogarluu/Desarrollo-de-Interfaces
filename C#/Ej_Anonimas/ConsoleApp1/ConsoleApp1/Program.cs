using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding.Exercise
{
    /*
     * Para el delegado ValidarEdades, se pide declarar un Método Anónimo que lo
     * implemente. Dicho método debe validar que la edad recibida por parámetro
     * corresponda a alguien mayor de edad. Es decir que ese número debe ser mayor a 18, en
     * cuyo caso el método deberá retornar el valor booleando True. Caso contrario retornara
     * un valor False.
     */
    public delegate bool ValidarEdades(int x);

    /*
     * Dada la solución del ejercicio anterior, se pide declarar un método con el
     * nombre ImprimirConsola. Este método debe imprimir en consola el resultado de
     * ejecutar la implementación validate del delegado. Es decir, que se debe "mudar" la linea
     * con la impresión en consola del Main al método ImprimirConsola, que además va a
     * recibir 2 parámetros. Uno de ellos será el método del delegado mediante el
     * objeto validate y el otro va a ser un int que contiene el valor de la edad que se debe
     * validar. De más esta decir, que este método se debe invocar desde el Main pasandole
     * los parámetros que correspondan al delegado y a la edad, cuyo valor debe ser 19.
     */
    public class Exercise
    {
        public delegate bool ValidarEdades(int x);

        public static void Main()
        {
            ValidarEdades validate = (x) => x >= 18;
            ImprimirConsola(validate, 19);
        }

        public static void ImprimirConsola(ValidarEdades validar, int edad)
        {
            Console.WriteLine(validar(edad));
        }
    }
}
