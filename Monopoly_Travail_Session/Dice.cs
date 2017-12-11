using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Monopoly
{
    public class Dice
    {

        public static int Brasser()
        {
            Random lance = new Random();
            int de = lance.Next(1, 7);
            return de;
        }
     }
}