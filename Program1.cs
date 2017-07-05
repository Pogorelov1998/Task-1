using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Z1P
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2;
            n1 = n2 = 0;
            Console.Write("Введите два числа: ");
            n1 = Convert.ToInt32(Console.ReadLine());
            n2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Среднее арифметическое: ");
            Console.Write((n1 + n2) / 2.0);
            Console.Write("\nСреднее геометрическое: ");
            Console.Write(Math.Sqrt(n1*n2));
            Console.ReadKey();
        }
    }
}
