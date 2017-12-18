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
             Console.WriteLine("Vous réclamez 200$ à la banque.");           
        }
	}
}
