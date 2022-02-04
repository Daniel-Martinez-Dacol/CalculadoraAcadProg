using System;

namespace Calculadora.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Calculadora Top 1.0...");
            Console.WriteLine("\n-Digite 1 para somar\n-Digite 2 para subtrair\n-Digite 3 para multiplicar\n-Digite 4 para dividir\n-Digite (s) para fechar o programa.\n");
            string opcao = "";
            do
            {
               
                Console.WriteLine("Digite o primeiro numero: ");
                double val1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite o segundo numero: ");
                double val2 = double.Parse(Console.ReadLine());

                Console.Write("\nEscolha uma das opções: ");

                opcao = Console.ReadLine();

                double soma = val1 + val2;
                double sub = val1 - val2;
                double prod = val1 * val2;
                double div = val1 / val2;

                //Console.WriteLine($"O valor da soma foi: {soma} \nO valor da Subtração foi: {sub} \nO valor do produto foi {prod}");
                if (opcao == "1")
                {
                    Console.WriteLine($"O valor da soma foi: {soma}\n");
                }
                if (opcao == "2")
                {
                    Console.WriteLine($"O valor da subtração foi: {sub}\n");
                }
                if (opcao == "3")
                {
                    Console.WriteLine($"O valor do produto foi: {prod}\n");
                }
                if (opcao == "4")
                {
                    if (val2 != 0)
                    {

                        Console.WriteLine($"O valor da divisão foi: {div}\n");
                    }
                    else
                    {
                        Console.WriteLine("ERRO! Valor do denominador da divisão tem que ser  diferente de zero!!!");
                    }
                }





            } while (opcao == "1" || opcao == "2" || opcao == "3" || opcao == "4");

        }
    }
}
