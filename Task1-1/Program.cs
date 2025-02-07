namespace Task1_1
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("a=");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("b=");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("c=");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine();
            int v = a;
            a = c;
            c = b;
            b = v;
            Console.WriteLine("a=" + a + " b=" + b + " c=" + c);
        }
    }
} 