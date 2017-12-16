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

        public void Sortir(Joueur joueur)
        {
            Transaction(joueur,50);
            joueur.Prison = false;
            joueur.Position = 30;
        }

        public override void Action(Joueur joueur)
        {
             Console.WriteLine("Voulez-vous payer pour sortir de prison?");
             string input = Console.ReadLine();
             if(input.Equals("O") || input.Equals("o"))
                {
                Sortir(joueur);
                }            
        }
    }
}

