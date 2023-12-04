using System.ComponentModel.Design;
using Fibonacci;

internal class Program
{
    private static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Menu Ejercicios Fibonacci");
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("1. Ejericio 1 Fibonacci");
            Console.WriteLine("2. Ejericio 2 Fibonacci");
            Console.WriteLine("3. Ejericio 3 Fibonacci");
            Console.WriteLine("4. Salir");
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Ingrese una opcion: ");
            var opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                   Fibonacci_1.Menu();
                   Console.ReadKey();
                    break;
                case "2":
                    Fibonacci_2.Menu();
                    Console.ReadKey();
                    break;
                case "3":
                    Fibonacci_3.Menu();
                    Console.ReadKey();
                    break;
                case "4":
                    return;
                default:
                    Console.WriteLine("Opcion no valida");
                    break;
            }

        }

    }
}