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
        do
        {
            Console.Write("Ingresa un número: ");
            intento = int.Parse(Console.ReadLine());
            intentos++;

            if (intento < numeroSecreto)
            {
                Console.WriteLine("⬆️ El número es mayor");
            }
            else if (intento > numeroSecreto)
            {
                Console.WriteLine("⬇️ El número es menor");
            }
            else
            {
                Console.WriteLine("¡Correcto!");
                Console.WriteLine("Lo lograste en " + intentos + " intentos");
            }

        } while (intento != numeroSecreto);

        Console.WriteLine("Presiona una tecla para salir...");
        Console.ReadKey();
    }
}
        
    
