using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{
   
        static class TestTrack
        {

            public static void race(i_remote carObject)
            {
                carObject.Drive();

            }
            public static void GetRankedCars(Production_remote pVictory1, Production_remote pVictory2)
            {
                if (pVictory1.CompareTo(pVictory2) > 0)
                {
                    Console.WriteLine("Victory of P1 is " + pVictory1.NumberOfVictories);

                }
                else if (pVictory1.CompareTo(pVictory2) < 0)
                {
                    Console.WriteLine("Victory of P1 is " + pVictory2.NumberOfVictories);
                }
                else
                {
                    Console.WriteLine("Both are equal");
                }


            }
        }
    
}
