using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Monopoly
{
    public class Prison : Case
    {
        
        public Prison(string nom) : base(nom)
        {
            
        }

        public override void Action(Joueur joueur)
        {
             Console.WriteLine("Vous visitez votre ami en prison pour fraude immobilière!!! Ne vous retrouvez pas dans la même situation...");           
        }
    }
}

