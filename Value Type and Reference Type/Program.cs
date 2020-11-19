using System;

namespace Value_Type_and_Reference_Type
{
    class Program
    {
        static void Main(string[] args)
        { 
                int i = 100;

                Console.WriteLine(i);

                ChangeValue(i);

                Console.WriteLine(i);

            Student std1 = new Student();
            std1.StudentName = "Bill";

            ChangeReferenceType(std1);

            Console.WriteLine(std1.StudentName);

        }
        static void ChangeValue(int x)
        {
            x = 200;

            Console.WriteLine(x);
        }
        static void ChangeReferenceType(Student std2)
        {
            std2.StudentName = "Steve";
        }

    }
}
