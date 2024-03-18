//Crie um programa para converter a temperatura da escala Celsius para a escala Fahrenheit

namespace Exercicio06.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá, informe a temperatura em graus Celsius");
            double celsius = Convert.ToDouble(Console.ReadLine());

            double fahrenheit = (1.8 * celsius) + 32;

            Console.WriteLine("A temperatura em graus fahrenheint é de " + fahrenheit + "°F");
            Console.ReadLine();
        }
    }
}
