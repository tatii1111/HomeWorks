using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_1_3_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Длина в дюймах ");
            double l = double.Parse(Console.ReadLine());
            double temp = l * 2.54;
            int m = (int)temp / 100;
            int sm = (int)temp - m * 100;
            double mm = ((double)temp * 10) - m * 1000 - sm * 10;
            mm = Math.Round(mm, 2);
            Console.WriteLine("результат " + m + " м " + sm + " см " + mm + " мм");
        }
    }
}
