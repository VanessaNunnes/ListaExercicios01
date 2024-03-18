// Crie um programa para calcular a média harmônica das notas de um Aluno
namespace Exercicio09.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá, Informe a primeira nota");
            double nota1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe a segunda nota");
            double nota2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe a terceira nota");
            double nota3 = Convert.ToDouble(Console.ReadLine());

            double mediaHarmonica = 3 / ((1/nota1) + (1/nota2) + (1/nota3));

            Console.WriteLine(mediaHarmonica.ToString("N3"));
            Console.ReadLine();


        }
    }
}
