using System;

namespace usandoSplit2
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Dados teste: Numero, Letra, Numero decial");
            //ReadLine lê strings, é preciso fazer uma conversão usando .Parse
            int n1 = int.Parse(Console.ReadLine());
            char ch = char.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine());

            System.Console.WriteLine("Dados teste: Nome Sexo Idade Altura");
            string[] vet = Console.ReadLine().Split(' ');
            string nome = vet[0];
            char sexo = char.Parse(vet[1]);
            int idade = int.Parse(vet[2]);
            double altura = double.Parse(vet[3]);
            
            System.Console.WriteLine($"Você digitou o nro: {n1}");
            System.Console.WriteLine($"Você digitou a letra: {ch}");
            System.Console.WriteLine($"Você digitou no nro: {n2}");
            
            System.Console.WriteLine($"Nome: {nome}");
            System.Console.WriteLine($"Sexo: {sexo}");
            System.Console.WriteLine($"Idade: {idade}");
            System.Console.WriteLine($"Altura: {altura}");
            
        }
    }
}