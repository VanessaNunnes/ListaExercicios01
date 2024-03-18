//Escrever um algoritmo que gera e escreve os números ímpares entre 100 e 200.

namespace Exercicio22.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Números ímpares de 100 a 200");

            for (int i = 100; i < 200; i++) 
            {
                if (i % 2 == 1)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();
        }
    }
}
