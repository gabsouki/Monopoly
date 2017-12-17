using System;
namespace Monopoly
{
    public class Stationnement : Case
    {
        public Stationnement(string nom) : base(nom)
        {
        }
        public override void Action(Joueur joueur)
        {
            Console.WriteLine("Félicitations pour votre stationnement gratuit.");
        }
    }
}
