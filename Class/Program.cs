using System;

namespace Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Newclass ob = new Newclass();
            string a = "Hello";
            string b = "World";

            ob.Display(a, b);
        }
        
    }
}
class Newclass
{
    public int MyProperty { get; set; }
    public void Display(string a,string b)
    {
        Console.WriteLine(a+" "+b);
    }
}