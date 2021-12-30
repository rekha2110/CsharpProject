using System;
using System.Collections.Generic;
using System.Text;

namespace student_details
{
    class student
    {
        public int rollno;
        public string Name;
        public string course;
        private int feepaid;
        public student(int rollno,string Name,string course)
        {
            this.rollno = rollno;
            this.Name = Name;
            this.course = course;
        }
        public void Payment(int payment)
        {
            feepaid = feepaid + payment;
        }
        public void print()
        {
            Console.WriteLine(rollno);
            Console.WriteLine(Name);
            Console.WriteLine(course);
            Console.WriteLine(feepaid);
        }
    }
}
