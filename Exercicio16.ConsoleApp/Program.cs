//Faça um algoritmo para ler o salário de um funcionário e aumentá-lo em 15%. Após o aumento, desconte 8% de impostos.
//Imprima o salário inicial, o salário com o aumento e o salário final.

namespace Exercicio16.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o valor do seu salário");
            double salario = Convert.ToDouble(Console.ReadLine());

            double aumento = 0.15 * salario;
            double salario_final = salario + aumento - (0.08 * salario);
            double salario_com_aumento = salario + aumento;

            Console.WriteLine("O seu salário inicial é de: " + salario);
            Console.WriteLine("O seu salário com aumento é de: " + salario_com_aumento);
            Console.WriteLine("O seu salário final é de: " + salario_final);
            Console.ReadLine();

        }
    }
}
