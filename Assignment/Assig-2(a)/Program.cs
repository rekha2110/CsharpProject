using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace Assig_2_a_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Student Id ");
            int studId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Student Name ");
            String studName = Console.ReadLine()
            ;
            Console.WriteLine("Enter the Course Name ");
            String courseType = Console.ReadLine();
            Console.WriteLine("Enter the Fees Paid ");
            double PaidFees = Convert.ToDouble(Console.ReadLine());
            Student studObj1 = new Student(studId, studName, courseType);
            studObj1.payment(PaidFees);
            studObj1.print();
        }
    }
}
