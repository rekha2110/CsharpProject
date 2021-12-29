using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

namespace File_Handling
{
    public class Housefile
    {
        public void create()
        {
            FileStream fileobj = new FileStream("E:\networklog.txt", FileMode open , FileAccess write);
            StreamWriter sw = new StreamWriter(fileobj);
            sw.WriteLine("Welcome");

            Console.WriteLine("Enter the House name:");
            String house
        }
    }
}
