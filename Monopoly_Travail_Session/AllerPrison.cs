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
            Console.WriteLine("\nVoulez-vous payer pour sortir de prison et jouer au prochain tour? O/N");
            string input = Console.ReadLine();
            if (input.Equals("O") || input.Equals("o"))
            {
                Case.Transaction(joueur, 50);
                joueur.Prison = false;
                joueur.Position = 10;
            }
            else
            {
                joueur.Prison = true;
                joueur.Position = 10;
            }
        }

        public override void Action(Joueur joueur)
        {
            Console.WriteLine("\nVous êtes maintenant en prison.");
            joueur.Prison = true;
            joueur.Position = 10; 
        }
    }
}