using System;

namespace DynamicVariable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            dynamic vari = 200;
            Console.WriteLine(vari.GetType());
            vari = DateTime.Now;
            Console.WriteLine(vari.GetType());
        }
    }
}
