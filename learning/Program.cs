using System;

namespace learning
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            date dt = new date();
            dt.dat();
        }
    }
}
class date
{
    public void dat()
    {
        DateTime dt = new DateTime();
        Console.WriteLine(dt);
    }
}