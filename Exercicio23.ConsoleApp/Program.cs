//Desenvolver um algoritmo que efetue a soma de todos os números ímpares que são múltiplos de três e que se encontram no conjunto dos números de 1 até 500.

namespace Exercicio23.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Números ímpares e múltiplos de três de 1 a 500");

            int soma = 0;

            for (int i = 1; i < 500; i++)
            {
                if (i % 2 == 1 && i % 3 == 0)
                {
                    Console.WriteLine(i);
                    soma += i;
                }
            }
            Console.WriteLine("Soma dos números é " + soma);
            Console.ReadLine();
        }
    }
}
