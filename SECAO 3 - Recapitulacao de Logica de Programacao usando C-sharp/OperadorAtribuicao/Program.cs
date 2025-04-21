using System;
using System.Threading.Tasks.Dataflow;

namespace OperadorAtribuicao{
    class Program {
        static void Main(string[] args){

            int a = 10; //a recebe 10
            System.Console.WriteLine(a);

            a += 2;
            System.Console.WriteLine(a);

            a -= 2;
            System.Console.WriteLine(a);

            a*= 3;
            System.Console.WriteLine(a);

            System.Console.WriteLine("------------------");

            string s = "ABC";
            System.Console.WriteLine(s);

            s += "DEF";
            System.Console.WriteLine(s);

            System.Console.WriteLine("------------------");

            int b = 10;
            b++;
            System.Console.WriteLine(b);

            b--;
            System.Console.WriteLine(b);

            System.Console.WriteLine("------------------");

            int c = 10;
            int d = c++; // d primeiro recebe o valor de c para depois incremetar
            System.Console.WriteLine(c);
            System.Console.WriteLine(d);
            
            System.Console.WriteLine("------------------");

            int e = 10;
            int f = ++e; //Primeiro incrementa o valor da variavel e, depois atribui a variavel f
            System.Console.WriteLine(e);
            System.Console.WriteLine(f);
        }
    }
}
