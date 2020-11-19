using System;

namespace Class
{
    class Program
    {
        static void Main(string[] args)
        {

            stringcon str = new stringcon();
            str.st();

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