using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Monopoly
{
    public class AllerPrison : Case
    {
        public AllerPrison(string nom) : base(nom)
        {

        }
        public void Entrer(Joueur joueur)
        {

        }

        public override void Action(Joueur joueur)
        {
            Console.WriteLine("Vous êtes maintenant en prison.");
            joueur.Prison = false;
            joueur.Position = 30; 
        }
    }
}