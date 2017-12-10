using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Monopoly
{
    public class Dice
    {
        public int[]  Brasser()
        {
            int[] resultat = new int[2];
            Random aleatoire = new Random();
            //resultat[0] = aleatoire.Next(1, 7);
            //resultat[1] = aleatoire.Next(1, 7);
            resultat[0] = 2;
            resultat[1] = 1;
            return resultat;
        }
    }
}