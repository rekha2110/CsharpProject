using System;

namespace student_details
{
    class Program
    {
        static void Main(string[] args)
        {
            student stud = new student(1, "rekha", "c#");
            stud.Payment(1000);
            Console.ReadKey();
        }
    }
}
