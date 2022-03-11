using System;

namespace Tjedan2
{
    internal class Program
    {
        static double rez;
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Add(2, 3);
            Subtract(2, 3);
            Multiply(2,3);
            Divide(2,3);    
            
        }

        private static void Add(int x, int y)
        {
            rez = x + y;
            Console.WriteLine(rez); }

        private static void Subtract(int x, int y)
        {
            rez = x - y;
            Console.WriteLine(rez);
        }

        private static void Multiply(int x, int y)
        {
            rez = x * y;
            Console.WriteLine(rez);
        }

        private static void Divide(float x, float y)
        {
            rez = x / y;
            Console.WriteLine(rez);
        }
    }
}
