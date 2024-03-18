// Faça um algoritmo para receber um número qualquer e informar na tela se é par ou ímpar.
namespace Exercicio20.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe um número");
            double numero = Convert.ToDouble(Console.ReadLine());

            if (numero % 2 == 0)
            {
                Console.WriteLine("Este número é um número PAR");
            }
            else
            {
                Console.WriteLine("Este número é um número ÍMPAR");
            }
            Console.ReadLine();
        }
    }
}
