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
            Console.WriteLine("Vous vivez dans le grand luxe, vous devez payer une taxe de 100$");
            Transaction(joueur, 100);
        }
    }
}
