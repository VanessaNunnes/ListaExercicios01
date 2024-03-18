//Crie um programa para calcular o volume de uma caixa retangular V = c * l * a
namespace ListaExercicios01.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá, informe o comprimento, largura e a altura da sua caixa para calcular o seu volume");

            Console.WriteLine("Informe o comprimento: ");
            double comprimento = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe a largura: ");
            double largura = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe a altura: ");
            double altura = Convert.ToDouble(Console.ReadLine());

            double volume = comprimento * largura * altura;

            Console.WriteLine("O volume da sua caixa é de " + volume.ToString("N2") + "m³");
            Console.ReadLine();

        }
    }
}
