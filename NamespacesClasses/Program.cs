using System;

namespace NamespacesClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            SimpleMath.Add(2, 3);
        }
    }

    class SimpleMath
    {
        public static void Add(int x, int y)
        {
            rez = x + y;
            Console.WriteLine(rez);
        }

        public static void Subtract(int x, int y)
        {
            rez = x - y;
            Console.WriteLine(rez);
        }

        public static void Multiply(int x, int y)
        {
            rez = x * y;
            Console.WriteLine(rez);
        }

        public static void Divide(float x, float y)
        {
            rez = x / y;
            Console.WriteLine(rez);
        }

    }
}
