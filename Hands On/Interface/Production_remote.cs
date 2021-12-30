using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{
    class Production_remote : i_remote, IComparable<Production_remote>
    {

        public int DistanceTravelled { get; set; }
        public int NumberOfVictories { get; set; }



        public void Drive()
        {
            this.DistanceTravelled = 40;

        }

        public int CompareTo(Production_remote other)
        {
            return this.NumberOfVictories.CompareTo(other.NumberOfVictories);
        }

    }
}
