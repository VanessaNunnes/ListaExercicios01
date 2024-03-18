// Escreva um algoritmo que leia um valor inicial A e imprima a sequência de valores do cálculo de A! e o seu resultado. Ex: 5! = 5 X 4 X 3 X 2 X 1 = 120

namespace Exercicio25.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe um número");
            double N = Convert.ToDouble(Console.ReadLine());

            double fatorial = 1;

            Console.Write(N + "! = ");
            for (double i = N; i >= 1; i--)
            {
                fatorial *= i;
                Console.Write(i);
                if (i != 1)
                    Console.Write(" X ");
            }
            Console.WriteLine(" = " + fatorial);
            Console.ReadLine();
        }
    }
}
