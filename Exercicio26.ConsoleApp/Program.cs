//Escreva um programa que leia um número e imprima a sequência de Fibonacci até esse número.

namespace Exercicio26.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, soma = 0, n1 = 1, n2 = 1;
            Console.WriteLine("digite o numero");
            num = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                soma = n1 + n2;
                n2 = n1;
                n1 = soma;
                Console.WriteLine(soma);
            }
            Console.ReadLine();
        }
    }
}
