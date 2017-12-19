using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Monopoly
{
    public class Go : Case
    {
        public Go(string nom) : base(nom)
        {
            
        }

        public override void Action(Joueur joueur)
        {
            Console.WriteLine("\nVous avez passé GO, vous avez réclamé 200$");
            joueur.Argent = joueur.Argent + 200;
        }
	}
}
