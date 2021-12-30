using System;
using System.Collections.Generic;
using System.Collections;


namespace ListInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> obj = new List<int>();
            obj.Add(1);
            obj.Add(2);
            obj.Add(3);
            obj.Add(4);
            int result;
            foreach (int item in obj) 
            {
                result = ( item + 2) * 5;
                Console.WriteLine(result);
                Console.Write(" ");
            }
        }

            
            
        }
    }
}
