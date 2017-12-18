using System;
namespace Monopoly
{
    public class Impot : Case
    {
        public Impot(string nom) : base(nom)
        {
        }
        public override void Action(Joueur joueur)
        {
            //ACTION PAYER IMPOTS SELON LE JOUEUR.ARGENT 10% OU MONTANT FIXE
            Console.Write("OK");
        }
    }
}
