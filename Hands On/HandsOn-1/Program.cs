using System;

namespace HandsOn_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string date1 = Console.ReadLine();
            CultureInfo provider = new CultureInfo("en-US");
            try
            {
                DateTime dateobj = DateTime.Parse(date1, provider);
                AppoinmentSchedular.schedule(date1);
                Console.WriteLine(AppoinmentSchedular.afternoon(dateobj));
                Console.WriteLine("You have an Appoinment on " + AppoinmentSchedular.description(dateobj));

            }
            catch (Exception e)
            {
                Console.WriteLine("Excep :");
            }
        }
    }



}
