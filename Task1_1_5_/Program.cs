using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_1_5_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину в метрах: ");
            double l = double.Parse(Console.ReadLine());
            double lr = Math.Ceiling(l);
            int r = (int)lr;
            Console.WriteLine("Округленная длина: " + r);
        }
    }
}
