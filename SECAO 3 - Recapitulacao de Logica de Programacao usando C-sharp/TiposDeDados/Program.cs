using System;
using System.Globalization;
using System.Threading.Tasks.Dataflow;

namespace TiposDeDados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            sbyte x = 100;
            byte n1 = 126;
            int n2 = 1000;
            int n3 = 2147483647;
            long n4 = 2147483648L;

            char genero = 'F';
            int idade = 32;
            double saldo = 10.35784;
            string nome = "Maria";


            Console.WriteLine(x);//Escreve com quebra de linha
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            System.Console.WriteLine(n4);

            System.Console.WriteLine("-------------------------------");
            System.Console.Write("Bom dia! ");//Escreve sem quebra de linha
            System.Console.WriteLine("Boa tarde!");
            System.Console.WriteLine("Boa noite!");

            System.Console.WriteLine("-------------------------------");
            System.Console.WriteLine(genero);
            System.Console.WriteLine(idade);
            System.Console.WriteLine(saldo);
            System.Console.WriteLine(nome);
            System.Console.WriteLine("-------------------------------");

            System.Console.WriteLine(saldo.ToString("F2"));
            System.Console.WriteLine(saldo.ToString("f4"));

            System.Console.WriteLine("-------------------------------");

            //Tecnica de placeholder
            System.Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:f2} reais", nome, idade, saldo);

            //Tecnica da interpolacao
            System.Console.WriteLine($"{nome} tem {idade} anos e tem saldo igual a {saldo:f2} reais");

            //Tecnica de concatenacao de strings
            System.Console.WriteLine(nome + " tem " + idade + " anos e tem saldo igual a " + saldo.ToString("f2") + " reais");

            

        }
    }
}