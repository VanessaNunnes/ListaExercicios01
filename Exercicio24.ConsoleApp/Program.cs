// Escrever um algoritmo que leia um valor para uma variável N de 1 a 10 e calcule a tabuada de N. Mostre a tabuada na forma: 

namespace Exercicio24.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe qual a tabuada que vc deseja visualizar");
            int N = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i < 11; i++) 
            {
                int resultado = i * N;
                Console.WriteLine(i + " X " + N + " = " + resultado);
            }
            Console.ReadLine();
        }
    }
}
