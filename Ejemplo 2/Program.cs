using System;

class Program
{
    static void Main()
    {
        Random random = new Random();
        int numeroSecreto = random.Next(1, 101); // número entre 1 y 100
        int intento = 0;
        int intentos = 0;

        Console.WriteLine(" Adivina el número");
        Console.WriteLine("Estoy pensando en un número entre 1 y 100");
    }
}
