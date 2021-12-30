using System;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            var prd = new Production_remote();
            var exp = new Experimental_remote();
            TestTrack.race(prd);
            TestTrack.race(exp);


            TestTrack.race(prd);

            TestTrack.race(exp);

            Console.WriteLine("Distance Traveled by Production_remote " + prd.DistanceTravelled);
            Console.WriteLine("Distance Traveled by Emperiment_remote " + exp.DistanceTravelled);


            var p1 = new Production_remote();
            var p2 = new Production_remote();
            p1.NumberOfVictories = 5;
            p2.NumberOfVictories = 8;
            TestTrack.GetRankedCars(p1, p2);


        }
    }
    
}
