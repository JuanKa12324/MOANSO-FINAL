using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("CALCULADORA BÁSICA");
        Console.WriteLine("1. Sumar");
        Console.WriteLine("2. Restar");
        Console.Write("Elige una opción: ");

        int opcion = int.Parse(Console.ReadLine());

        Console.Write("Ingresa el primer número: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Ingresa el segundo número: ");
        int num2 = int.Parse(Console.ReadLine());

        if (opcion == 1)
        {
            int resultado = num1 + num2;
            Console.WriteLine("Resultado de la suma: " + resultado);
        }
        else if (opcion == 2)
        {
            int resultado = num1 - num2;
            Console.WriteLine("Resultado de la resta: " + resultado);
        }
        else
        {
            Console.WriteLine("Opción no válida");
        }

        Console.WriteLine("Presiona una tecla para salir...");
        Console.ReadKey();
    }    
}
