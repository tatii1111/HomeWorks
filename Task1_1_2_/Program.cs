using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_1_2_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите угол в градусах, минута и секундах");
            int g = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int s = int.Parse(Console.ReadLine());
            double w = g;
            if (m < 0 | s < 0)
            {
                Console.WriteLine("Секунды и минуты необходимо вводить положительными");
            }
            else if (g < 0)
            {
                w = (g / 57.2957795130823) - s / 206264.806 - (m / 3437.75);
                Console.WriteLine("Ваш угол в радианах " + w);
            }

            else
            {
                w = s / 206264.806 + (m / 3437.75) + (g / 57.2957795130823);
                Console.WriteLine("Ваш угол в радианах " + w);
            }
        }
    }
}
