using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{
    interface i_remote
    {
        int DistanceTravelled
        {
            get;
            set;
        }
        void Drive();
    }
}
