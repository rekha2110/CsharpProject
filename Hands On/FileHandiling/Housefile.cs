using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileHandiling
{
    class Housefile
    {
        public void CreatHouse()
        {
            //step 1 file creation
            FileStream filestreamobj = new FileStream("E:\\MyFile.txt", FileMode.Create, FileAccess.Write);
            //file write operation
            StreamWriter sw = new StreamWriter(filestreamobj);
            sw.WriteLine("Welcome");
            sw.Close();
            filestreamobj.Close();

        }
        public void ReadHouseDetails()
        {

        }
    }
}
