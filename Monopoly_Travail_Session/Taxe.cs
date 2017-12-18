using System;
namespace Monopoly
{
    public class Taxe : Case
    {
        public Taxe(string nom) : base(nom)
        {
        }
        public override void Action(Joueur joueur)
        {
            //ACTION PAYER UNE TAXE FIXE
            Console.Write("OK");
        }
    }
}
