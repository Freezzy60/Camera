using System;
using System.Collections.Generic;
using System.Text;

namespace Camera
{
    public class Objective
    {
        public int BrennweiteMin { get; set; }

        public int BrennweiteMax { get; set; }

        public Objective(int brennweiteMin, int brennweiteMax)
        {
            BrennweiteMin = brennweiteMin;
            BrennweiteMax = brennweiteMax;
        }

        public string GetBrennweiteFromTo()
        {
            return ($"{BrennweiteMin} bis {BrennweiteMax}");
        }
       
        public override string ToString()
        {
            return "Objektiv: " + GetBrennweiteFromTo();
        }

    }




    
}
