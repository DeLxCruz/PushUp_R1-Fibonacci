using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fibonacci
{
    public class Fibonacci_1
    {
        // Escriba un programa que reciba como entrada un número entero n, y entregue como salida el n-
        // ésimo número de Fibonacci:

        static int Fibonacci(int n)
        {
            if (n <= 1)
                return n;
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }

        public static void Menu()
        {
            Console.WriteLine("Ingrese un número entero:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("El número de Fibonacci es: " + Fibonacci(n));
        }
    }
}