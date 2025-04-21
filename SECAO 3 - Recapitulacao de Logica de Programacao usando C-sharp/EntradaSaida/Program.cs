using System;

namespace EntradaSaida
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Coleta de dados, Pergunta e Resposta");
            System.Console.WriteLine("Entre com seu nome completo: ");
            string nome = Console.ReadLine();

            System.Console.WriteLine("Quantos quartos há na sua casa? ");
            int quartos = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Entre com o preço de um produto: ");
            double produto = double.Parse(Console.ReadLine());

            System.Console.WriteLine("");
            System.Console.WriteLine("-------------------------------------------");
            System.Console.WriteLine("COLETA DE DADOS (na mesma linha)");
            System.Console.WriteLine("Entre com seu último nome, idade e altura (separados por espaço): ");
            
            // Ler a linha e dividir em partes
            string[] vet = Console.ReadLine().Split(' ');
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