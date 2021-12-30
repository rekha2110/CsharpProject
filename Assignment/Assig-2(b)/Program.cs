using System;

namespace Assig_2_b_
{
    class Program
    {
        static void Main(string[] args)
        {
            string fname;
            string lname;
            int id;
            int num;
            Console.WriteLine("GIVEN INPUTS");
            var line = Console.ReadLine();
            var lineData = line.Split(' ');
            fname = string.Copy(lineData[0]);
            lname = string.Copy(lineData[1]);
            id = int.Parse(lineData[2]);
            num = Convert.ToInt32(Console.ReadLine());
            var stringarray = Console.ReadLine().Split(' ');
            var scores = new int[num];
            for (int i = 0; i < num; i++)
            {
                scores[i] = int.Parse(stringarray[i]);
            }
            Student studentobj = new Student(fname, lname, id, scores);
            Console.WriteLine("\n EXPECTED OUTPUT");
            studentobj.printPerson();
            Console.WriteLine("GRADE: " + studentobj.calculate());
            Console.ReadKey();
        }
    }
}
