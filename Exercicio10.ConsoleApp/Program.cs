//Crie um programa para calcular a média ponderada de duas provas realizadas por um aluno
// mediaPonderada = (peso1 * nota1) + (peso2 * nota2) / peso1 + peso2
namespace Exercicio10.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá, Informe a primeira nota");
            double nota1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe o peso da primeira nota");
            double peso1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe a segunda nota");
            double nota2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe o peso da segunda nota");
            double peso2 = Convert.ToDouble(Console.ReadLine());

            double mediaPonderada = ((nota1 * peso1) + (nota2 * peso2)) / (peso1 + peso2);

            Console.WriteLine("A média ponderada é de: " + mediaPonderada.ToString("N2"));
            Console.ReadLine();

        }
    }
}
