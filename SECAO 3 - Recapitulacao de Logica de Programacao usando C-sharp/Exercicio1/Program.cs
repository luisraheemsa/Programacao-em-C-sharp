using System;
using System.Globalization;

namespace Exercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string produto1 = "Computador";
            string produto2 = "Mesa de escritório";
            
            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;

            System.Console.WriteLine();
            System.Console.WriteLine("Produtos:");
            System.Console.WriteLine($"{produto1}, cujo preço é $ {preco1}");
            System.Console.WriteLine($"{produto2}, cujo preço é $ {preco2}");
            
            System.Console.WriteLine();
            System.Console.WriteLine($"Registro: {idade} de idade, código {codigo} e gênero: {genero}");
            
            System.Console.WriteLine();
            System.Console.WriteLine($"Medida com oito casas decimais: {medida}");
            System.Console.WriteLine($"Arredondado (três casas decimais): {medida.ToString("f3")}");
            System.Console.WriteLine($"Separador decimal invariant culture: {medida.ToString("f3", CultureInfo.InstalledUICulture)}");

        }
    }
}