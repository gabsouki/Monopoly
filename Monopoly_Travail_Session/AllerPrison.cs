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
        public static void Sortir(Joueur joueur)
        {
            Console.WriteLine("Voulez-vous payer pour sortir de prison et jouer au prochain tour? O/N");
            string input = Console.ReadLine();
            if (input.Equals("O") || input.Equals("o"))
            {
                Case.Transaction(joueur, 50);
                joueur.Prison = false;
                joueur.Position = 30;
            }
            else
            {
                joueur.Prison = true;
                joueur.Position = 30;
            }
        }

        public override void Action(Joueur joueur)
        {
            Console.WriteLine("Vous êtes maintenant en prison.");
            joueur.Prison = true;
            joueur.Position = 30; 
        }
    }
}