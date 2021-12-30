using System;
using System.Collections;

namespace ArrayDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            int total=3;
            for (int i = 0; i < total; i++)
            {
                string name = Console.ReadLine();
                int age = Convert.ToInt32(Console.ReadLine());
                Person obj = new Person();
                list.Add(obj.ToString(name, age));
            }
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
            Console.ReadKey();
 
        }
    }
}
