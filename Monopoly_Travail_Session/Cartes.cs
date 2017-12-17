using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Monopoly
{
    public class Cartes
    {
        public static List<string> chance;
        public static List<string> chest;

        public static void Initialiser()
        {
            List<string> chest = new List<string>();
            chest.Add("Passez Go bla bla");
            List<string> chance = new List<string>();
            chance.Add("Chance");
        }
    }
}