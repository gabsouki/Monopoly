using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Monopoly
{
    public class Dice
    {
        public int Brasser()
        {
            Random aleatoire = new Random();
            int DeUnValeur = aleatoire.Next(1, 7); 
            int DeDeuxValeur = aleatoire.Next(1, 7);

            return DeUnValeur + DeDeuxValeur;
        }
        private bool VerifDouble(int Val1, int Val2)
        {
            if (Val1 == Val2)
                return true;
            else
                return false;
        }
    }
}