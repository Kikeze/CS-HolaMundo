using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolaMundo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hola Mundo!");
            //Console.WriteLine("Hola Alquien!");
            //Console.Read();

            int num1 = 13;
            int num2 = 5;
            int sum = num1 + num2;

            Console.WriteLine(num1);
            Console.WriteLine(num2);
            Console.WriteLine(sum);
            Console.WriteLine("La suma de " + num1 + " mas " + num2 + " es igual a " + sum);

            double d1 = 3.2;
            double d2 = 1.3;
            double sumd = d1 + d2;

            Console.WriteLine(d1);
            Console.WriteLine(d2);
            Console.WriteLine(sumd);
            Console.WriteLine("La suma de " + d1 + " mas " + d2 + " es igual a " + sumd);

            double sumx = d1 + num2;
            Console.WriteLine("La suma de " + d1 + " mas " + num2 + " es igual a " + sumx);

            Console.Read();
        }
    }
}
