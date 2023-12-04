using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fibonacci
{
    public class Fibonacci_3
    {
        // Escriba un programa que muestres los m primeros números de Fibonacci, donde m es un número
        // ingresado por el usuario:

        static int Fibonacci(int n)
        {
            if (n <= 1)
                return n;
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }

        public static void Menu()
        {
            Console.WriteLine("Ingrese un número entero:");
            int m = int.Parse(Console.ReadLine());
            for (int i = 0; i < m; i++)
            {
                Console.Write($"{Fibonacci(i)} ");
            }
        }
    }
}