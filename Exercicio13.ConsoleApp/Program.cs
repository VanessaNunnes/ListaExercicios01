// A padaria Hotpão vende uma certa quantidade de pães franceses e uma quantidade de broas a cada dia. Cada pãozinho custa R$ 0,12
// e a broa custa R$ 1,50. Ao final do dia, o dono quer saber quanto arrecadou com a venda dos pães e broas (juntos),
// e quanto deve guardar numa conta de poupança (10% do total arrecadado). Você foi contratado para fazer os cálculos para o dono.
// Com base nestes fatos, faça um algoritmo para ler as quantidades de pães e de broas, e depois calcular os dados solicitados.

namespace Exercicio13.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe a qunatidade de pães vendidos no dia");
            double paes = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe a qunatidade de broas vendidas no dia");
            double broas = Convert.ToDouble(Console.ReadLine());

            double arrecadacao = (paes * 0.12) + (broas * 1.50);

            double poupanca = 0.1 * arrecadacao;

            Console.WriteLine("Você arrecadou " + arrecadacao.ToString("N2") + " com a venda dos pães e das broas");
            Console.WriteLine("E deve guardar " + poupanca.ToString("N2") + " na poupança");
            Console.ReadLine();
        }
    }
}
