using System;
using System.Net.NetworkInformation;

namespace Exercicio2
{
    class Progam{

        static void Main(string[] args)
        {
            double r = double.Parse(Console.ReadLine());
            
            double raio = Math.PI * Math.Pow(r,2);

            System.Console.WriteLine($"A = {raio:f4}");
        }
    }
}