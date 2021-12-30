using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace Assig_2_a_
{
    class Student
    {
        private int rollNo;
        private string name;
        private string courseJoined;
        private double feePaid = 0;
        private double dueAmount;
        private double totalFee;
        private string[] courseName = { "c#", "asp.net" };
        private double[] courseFees = { 2000, 3000 };
        public Student(int rollNo, string name, string courseJoined)
        {
            this.rollNo = rollNo;
            this.name = name;
            this.courseJoined = courseJoined;
        }
        public double DueAmount
        {
            get
            {
                return dueAmount;
            }
            set
            {
                dueAmount = value;
            }
        }
        public double TotalFee
        {
            get
            {
                return totalFee;
            }
            set
            {
                totalFee = value;
            }
        }
        public void payment(double amount)
        {
            feePaid += amount;
            if (courseJoined == courseName[0])
            {
                totalFee = 2000;
                dueAmount = totalFee - feePaid;
            }
            else if (courseJoined == courseName[1])
            {
                totalFee = 3000;
                dueAmount = totalFee - feePaid;
            }
        }
        public void print()
        {
            Console.WriteLine("\n" + totalFee);
            Console.WriteLine(dueAmount);
        }
    }
}
