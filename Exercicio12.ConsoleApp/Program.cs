//A imobiliária Imóbilis vende apenas terrenos retangulares. Faça um algoritmo para ler as dimensões de um terreno
//e depois exibir a área do terreno. area = comprimento * largura

namespace Exercicio12.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá, bem-vindo(a)");
            Console.WriteLine("Informe as dimensões do seu terreno para calcularmos a sua área");

            Console.WriteLine("Informe o comprimento do terreno");
            double comprimento = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe a largura do terreno");
            double largura = Convert.ToDouble(Console.ReadLine());

            double area = comprimento * largura;

            Console.WriteLine("A área do seu terreno é de: " + area.ToString("N2") + "m²");
            Console.ReadLine();
        }
    }
}
