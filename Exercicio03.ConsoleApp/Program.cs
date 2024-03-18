// Crie um programa para calcular o volume de um Cilindro V = pi * (raio * raio) * altura
namespace Exercicio03.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá, Informe o raio do cilindro(m)");
            double raio = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe a altura do cilindro(m)");
            double altura = Convert.ToDouble(Console.ReadLine());

            double pi = 3.14;

            double volume = pi * (raio * raio) * altura;

            Console.WriteLine("O volume do cilindro é de " + volume.ToString("N2") + "m³");
            Console.ReadLine();
        }
    }
}
