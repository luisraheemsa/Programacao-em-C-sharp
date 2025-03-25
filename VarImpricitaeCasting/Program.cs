using System;

namespace VarImplicitaCasting 
{
    class Program 
    {
        static void Main(string[] args)
        {
            float x = 4.5f;
            double y = x;

            System.Console.WriteLine(y);
            System.Console.WriteLine("-----------------------");
            
            double a; //8 bytes
            float b; // 4 bytes
            int c; // valor inteiro

            a = 5.1;
            //b = a; pode perder informacao
            b = (float)a; //casting

            System.Console.WriteLine(a);
            System.Console.WriteLine(b);
            System.Console.WriteLine("-----------------------");

            c = (int)a; // a variavel vai perder informacao.
            System.Console.WriteLine(c);
            System.Console.WriteLine("-----------------------");

            int d = 5;
            int e = 2;

            double resultado = d / e;

            System.Console.WriteLine(resultado);

            double resultado2 = (double) d / e;

            System.Console.WriteLine(resultado2);


        }
    }
}