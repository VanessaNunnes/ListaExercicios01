//Crie um programa para converter a temperatura de graus Fahrenheit para graus Celsius
namespace Exercicio02.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá, informe a temperatura de graus Fahrenheit");
            double fahrenheit = Convert.ToDouble(Console.ReadLine());

            double celsius = (fahrenheit - 32) / 1.8;

            Console.WriteLine("A temperatura em graus celsius é de " + celsius + "°C");
            Console.ReadLine();
        }
    }
}
