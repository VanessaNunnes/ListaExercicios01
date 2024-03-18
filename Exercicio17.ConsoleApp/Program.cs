//Faça um algoritmo que leia os valores A, B, C e imprima na tela se a soma de A + B é menor que C.
namespace Exercicio17.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o valor A");
            double valorA = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe o valor B");
            double valorB = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe o valor C");
            double valorC = Convert.ToDouble(Console.ReadLine());

            if (valorA + valorB <= valorC)
            {
                Console.WriteLine("A soma dos valores A e B é menor que o valor C");
            }
            else
            {
                Console.WriteLine("A soma dos valores A e B é maior que o valor C");
            }
            Console.ReadLine();
        }
    }
}
