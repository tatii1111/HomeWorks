using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_1_4_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите четырехзначное число: ");
            int a = int.Parse(Console.ReadLine());
            int b = a % 10;
            int c = a % 100;
            int d = a % 1000;
            int f = (d - c) / 100;
            a = a - d + b * 100 + c - b + f;
            Console.WriteLine("Измененное число: " + a);
        }
    }
}
