﻿using System;

namespace EntradaDados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string s = Console.ReadLine();
            //string[] v = s.Split(' ');

            //Comando direto
            string[] v = Console.ReadLine().Split(' ');

            string a = v[0];
            string b = v[1];
            string c = v[2];
            
            Console.WriteLine($"Voce digitou: {a}");
            Console.WriteLine($"Voce digitou: {b}");
            Console.WriteLine($"Voce digitou: {c}");
        }
    }
}