using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Monopoly
{
    public class Dice
    {
        protected int deUn;
        protected int deDeux;
        
        public Dice(int deUn, int deDeux)
        {
            this.deUn = deUn;
            this.deDeux = deDeux;
        }

        public int Brasser()
        {
            Random lance1 = new Random();
            deUn = lance1.Next(1, 7);
            Console.WriteLine(deUn);
            Random lance2 = new Random();
            deDeux = lance2.Next(1, 7);
            Console.WriteLine(deDeux);
            int totalDe = deUn + deDeux;
            Console.WriteLine(totalDe);
            return totalDe;
        }
        public bool VerifDouble()
        {
            bool doubleDe = false;
            if (deUn == deDeux)
            {
                doubleDe = true;
                Console.WriteLine(doubleDe);
            }
            return doubleDe;

            /*
            int[] resultat = new int[2];
            Random aleatoire = new Random();
            //resultat[0] = aleatoire.Next(1, 7);
            //resultat[1] = aleatoire.Next(1, 7);
            resultat[0] = 2;
            resultat[1] = 1;
            return resultat;
            */
        }
    }
}