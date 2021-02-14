using System;
using System.Globalization;
namespace Uri_1005
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, m, p1, p2;

            p1 = 3.5;

            p2 = 7.5;

            Console.WriteLine();
            Console.Write("Digite a primeira nota : ");
            a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.Write("Digite a segunda nota : ");
            b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            m = (a *p1 + b*p2)/(p1+p2);

            Console.WriteLine();
            Console.WriteLine("Média = "+m.ToString("F5", CultureInfo.InvariantCulture));
            
        }
    }
}
