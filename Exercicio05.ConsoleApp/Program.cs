//Crie um programa para calcular o volume de uma esfera V = (4/3) * pi * (raio * raio * raio)
namespace Exercicio05.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá, informe o raio da esfera");
            double raio = Convert.ToDouble(Console.ReadLine());

            double pi = 3.14;

            double volume = 1.33 * pi * (raio * raio * raio);

            Console.WriteLine("O volume da esfera é de " + volume.ToString("N2"));
            Console.ReadLine();
        }
    }
}
