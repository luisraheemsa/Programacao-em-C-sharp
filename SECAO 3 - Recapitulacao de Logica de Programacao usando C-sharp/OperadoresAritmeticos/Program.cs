using System;

namespace OperadoresAritmeticos {
    class Program {
        static void Main(string[] args)
        {
            int n1 = 3 + 4 * 2; // 11
            int n2 = (3 + 4) * 2; // 14
            int n3 = 17 % 3; // 2
            double n4 = 10 / 8;
            double n5 = (double) 10 / 8;
            double n6 = 10.0 / 8; 

            System.Console.WriteLine(n1);
            System.Console.WriteLine(n2);
            System.Console.WriteLine(n3);
            System.Console.WriteLine(n4);
            System.Console.WriteLine(n5);
            System.Console.WriteLine(n6);
            System.Console.WriteLine("---------------------------------");

            double a = 1.0, b = -3.0, c = -4.0;

            double delta = Math.Pow(b, 2.0) - 4.0 * a * c;
            double x1 = (-b + Math.Sqrt(delta)) / (2.0 * a);
            double x2 = (-b - Math.Sqrt(delta)) / (2.0 * a);

            System.Console.WriteLine($"Delta: {delta}");
            System.Console.WriteLine($"X1: {x1}");
            System.Console.WriteLine($"X2: {x2}");

        }
    }
}