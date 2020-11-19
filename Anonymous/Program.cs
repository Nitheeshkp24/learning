using System;

namespace Anonymous
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var student = new { id = "1", name = "nitheesh", mark = "0" };
            Console.WriteLine(student.id);
            Console.WriteLine(student.name);
            Console.WriteLine(student.mark);
            var arr = new[]
            {
            
            new { Id = 1, FirstName = "James", LastName = "Bond" },
            new { Id = 2, FirstName = "Steve", LastName = "Jobs" },
            new { Id = 3, FirstName = "Bill", LastName = "Gates" }

            };
            Console.WriteLine(arr[0]);

        }
    }
}
