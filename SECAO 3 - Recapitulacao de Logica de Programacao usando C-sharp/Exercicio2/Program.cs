using System;
using System.Runtime.ConstrainedExecution;


namespace Exercicio2
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Coleta de dados, Pergunta e Resposta");
            System.Console.WriteLine("Entre com sue nome completo: ");
            string nome = Console.ReadLine();

            System.Console.WriteLine("Quantos quartos em na sua casa? ");
            int quartos = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Entre com o preço de um produto: ");
            double produto = double.Parse(Console.ReadLine());

            System.Console.WriteLine("");
            System.Console.WriteLine("-------------------------------------------");
            System.Console.WriteLine("COLETA DE DADOS (na mesma linha)");
            System.Console.WriteLine("Entre com seu último nome, idade e altura: ");
            string ultimonome = vet[0];
            int idadelinha = int.Parse(vet[1]);
            double altura = double.Parse(vet[2]);

            System.Console.WriteLine($"{nome}");
            System.Console.WriteLine($"{quartos}");
            System.Console.WriteLine($"{produto}");

            System.Console.WriteLine($"{ultimonome}");
            System.Console.WriteLine($"{idadelinha}");
            System.Console.WriteLine($"{altura}");

        }
    }
}


