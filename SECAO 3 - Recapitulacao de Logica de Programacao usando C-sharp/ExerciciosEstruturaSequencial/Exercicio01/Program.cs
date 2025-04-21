using System;

namespace Exercicio1
{
    class Progam{

        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());

            int soma = n1 + n2;

            System.Console.WriteLine($"SOMA = {soma}");
        }
    }
}