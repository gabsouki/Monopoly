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
            Console.WriteLine("Vous êtes arrivé sur la case Impôt. Vous devez payer 200$.");
            Transaction(joueur, 200);
        }
    }
}
