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
            System.Threading.Thread.Sleep(250);
            Random lance = new Random();
            int de = lance.Next(1, 7);
            System.Threading.Thread.Sleep(250);
            return de;
        }
     }
}