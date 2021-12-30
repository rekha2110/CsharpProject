using System;

namespace FileHandiling
{
    class Program
    {
        static void Main(string[] args)
        {
            Housefile houseFileObj = new Housefile();
            houseFileObj.CreatHouse();
            Console.ReadKey();
        }
    }
}
