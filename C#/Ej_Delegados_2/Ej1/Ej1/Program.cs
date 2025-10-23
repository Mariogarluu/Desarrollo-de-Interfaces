using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1
{
    internal class Program
    {
        public delegate int operacion(int x, int y); 

        public static int suma(int x, int y)
        {
            return x + y;
        }
        static void Main(string[] args)
        {
            operacion op = suma;

            Console.WriteLine(op(4, 5));
        }
    }
}
