using System;

namespace TernaryOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 20;
            int y = 20;
            Console.WriteLine("Hello World!");
            var result = x > y ? "x is greater than y" : x < y ? "x is less than y" : x == y ? "x is equal to y" : "no result";
            Console.WriteLine(result);
        }
    }
}
