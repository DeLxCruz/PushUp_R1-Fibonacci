using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fibonacci
{
    public class Fibonacci_2
    {
        // Escriba un programa que reciba como entrada un número entero e indique si es o no un número
        // de Fibonacci:

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
            int i = 0;
            while (Fibonacci(i) < n)
            {
                i++;
            }
            if (Fibonacci(i) == n)
            {
                Console.WriteLine($"{n} es un número de Fibonacci.");
            }
            else
            {
                Console.WriteLine($"{n} no es un número de Fibonacci.");
            }
        }
    }
}