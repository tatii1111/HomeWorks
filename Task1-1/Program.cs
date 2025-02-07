namespace Task1_1
{
    internal class Program
    {
        static void Main()
        {
                Console.Write("a=");
                int a = Console.Read();
                Console.WriteLine();
                Console.Write("b=");
                int b = Console.Read();
                Console.WriteLine();
                Console.Write("c=");
                int c = Console.Read();
                Console.WriteLine();
                Console.WriteLine(a);
                Console.WriteLine("a=" + (a=c) + " b=" + (b=a) + " c=" + (c=b));
            }
        }
    }