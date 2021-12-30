using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{
    class Experimental_remote : i_remote
    {
        
            public int DistanceTravelled { get; set; }

            public void Drive()
            {
                this.DistanceTravelled = 30;

            }
        
    }
}
