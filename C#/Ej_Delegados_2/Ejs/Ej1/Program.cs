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
        public delegate int Transformar(int x);

        /*
         * Declara un delegado llamado Operacion que acepte dos enteros y devuelva un entero. 
         * Luego, crea un método llamado Sumar que sume dos números y lo llame desde el Main.
         */
        public static int suma(int x, int y)
        {
            return x + y;
        }

        /*
         * Añade un segundo método llamado Restar que reste dos números. Asigna ambos
         * métodos al delegado y llama a cada uno desde el Main.
         */
        public static int resta(int x, int y)
        {
            return x - y;
        }

        /*
         * Crea un tercer método llamado Multiplicar. Asigna los tres métodos al mismo delegado 
         * y llama a todos en el Main.
         */
        public static int multiplicar(int x, int y)
        {
            return x * y;
        }

        /*
         * Agrega un método Dividir. Usa el delegado para llamar a todos los métodos, pero 
         * maneja el caso de la división por cero.
         */
        public static int dividir(int x, int y)
        {
            if (y == 0)
            {
                Console.WriteLine("Error: División por cero.");
                return 0;
            }
            return x / y;
        }

        /*
         * Crea un método que reciba un delegado y dos enteros, y llame al delegado, imprimiendo 
         * el resultado. Utiliza este método con los métodos Sumar, Restar, y Multiplicar.
         */
        public static void ejecutarOperacion(operacion op, int x, int y)
        {
            int resultado = op(x, y);
            Console.WriteLine("El resultado es: " + resultado);
        }

        /*
         * Crea un delegado llamado Operar que acepte dos enteros y devuelva un entero. Define
         * tres métodos: Suma, Resta y Multiplicacion. Asigna estos métodos a un delegado y usa 
         * un bucle para llamar a cada uno, imprimiendo el nombre del método junto con el 
         * resultado.
         */
        public static void Operar()
        {
            operacion op;

            op = suma;
            Console.WriteLine("Suma: " + op(4, 5));

            op = resta;
            Console.WriteLine("Resta: " + op(6, 5));

            op = multiplicar;
            Console.WriteLine("Multiplicación: " + op(4, 5));

            op = dividir;
            Console.WriteLine("División: " + op(20, 4));
        }

        /*
         * Modifica el ejercicio anterior para que los métodos reciban un array de enteros y 
         * devuelvan la suma de todos los elementos y en el caso del método Multiplicar, devuelva 
         * la multiplicación de todos los elementos del array. Se descarta para este ejercicio el 
         * método Restar. Usa el delegado para llamar a cada método, imprimiendo el resultado.
         */
        public static int SumarArray(int[] numeros)
        {
            int suma = 0;
            foreach (int num in numeros)
            {
                suma += num;
            }
            return suma;
        }
        public static int MultiplicarArray(int[] numeros)
        {
            int producto = 1;
            foreach (int num in numeros)
            {
                producto *= num;
            }
            return producto;
        }

        /*
         * Crea un delegado llamado Transformar que acepte un entero y devuelva un entero. 
         * Define tres métodos: Doblar, Triplicar y Cuadrado. Asigna estos métodos a un delegado 
         * y usa un bucle para transformar un número dado y mostrar el resultado de cada método.
         */
        public static int Doblar(int x)
        {
            return x * 2;
        }

        public static int Triplicar(int x)
        {
            return x * 3;
        }

        public static int Cuadrado(int x)
        {
            return x * x;
        }

        /*
         * Crea un delegado llamado OperacionCallback que acepte dos enteros y devuelva un 
         * entero. Define un método llamado EjecutarOperacion que acepte un delegado y dos 
         * enteros, realice la operación usando el delegado y devuelva el resultado. Luego, 
         * implementa los métodos Suma, Resta y Multiplicar y usa EjecutarOperacion para 
         * ejecutar cada uno de ellos.
         */
        public static int EjecutarOperacion(operacion op, int x, int y)
        {
            return op(x, y);
        }

        /*
         * Crea un delegado llamado Calculo que acepte un número y devuelva un número. Define 
         * métodos para calcular la raíz cuadrada y el logaritmo de un número. Implementa un 
         * método que acepte un delegado y un número, y maneje posibles excepciones que 
         * puedan surgir (como la raíz cuadrada de un número negativo). Imprime el resultado o 
         * un mensaje de error.
         */
        public static double RaizCuadrada(double x)
        {
            if (x < 0)
            {
                throw new ArgumentException("No se puede calcular la raíz cuadrada de un número negativo.");
            }
            return Math.Sqrt(x);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Suma: " + EjecutarOperacion(suma, 4, 5));
            Console.WriteLine("Resta: " + EjecutarOperacion(resta, 6, 5));
            Console.WriteLine("Multiplicación: " + EjecutarOperacion(multiplicar, 4, 5));
            Console.WriteLine("División: " + EjecutarOperacion(dividir, 20, 4));
            Operar();
            int[] numeros = { 1, 2, 3, 4, 5 };
            Console.WriteLine("Suma del array: " + SumarArray(numeros));
            Console.WriteLine("Multiplicación del array: " + MultiplicarArray(numeros));
            Transformar transformar;
            transformar = Doblar;
            Console.WriteLine("Doblar: " + transformar(5));
            transformar = Triplicar;
            Console.WriteLine("Triplicar: " + transformar(5));
            transformar = Cuadrado;
            Console.WriteLine("Cuadrado: " + transformar(5));
            try
            {
                Console.WriteLine("Raíz cuadrada de 16: " + RaizCuadrada(16));
                Console.WriteLine("Raíz cuadrada de -4: " + RaizCuadrada(-4));
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}
