using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Monopoly
{
    public class Dice
    {
        //protected int deUn;
        //protected int deDeux;
        
        public Dice(int deUn, int deDeux)
        {
            //this.deUn = deUn;
            //this.deDeux = deDeux;
        }

        public static int Brasser()
        {
            Random lance1 = new Random();
            int deUn = lance1.Next(1, 7);
            Random lance2 = new Random();
            int deDeux = lance2.Next(1, 7);
            int totalDe = deUn + deDeux;
            return totalDe;
        }
        /*
        public static bool VerifDouble()
        {
            bool doubleDe = false;
            if (deUn == deDeux)
            {
                doubleDe = true;
                Console.WriteLine(doubleDe);
            }
            return doubleDe;
        }
        */
    }
    }
}