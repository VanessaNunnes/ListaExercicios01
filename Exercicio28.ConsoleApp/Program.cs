// Escreva um programa que exiba a tabuada de multiplicação do 1 até o 10. Para isso, o programa deve gerar todas as combinações de multiplicação entre
// 1 e 10, exibindo o resultado de cada operação na tela. Desafio: Para cada número, tente separar em colunas.

namespace Exercicio28.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tabuada do 1 ao 10");
            int N = 1, i = 1;
            while (i <= 10 && N <= 10)
            {
                int result = N * i;
                Console.WriteLine($"{N} x {i} = {result}");
                i++;
                if (i == 11)
                {
                    Console.Write("\n");
                    i = 1;
                    N++;
                }
            }
            Console.ReadLine();
        }
    }
}
