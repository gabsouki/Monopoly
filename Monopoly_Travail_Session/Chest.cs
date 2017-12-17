using System;
namespace Monopoly
{
    public class Chest : Case
    {
        public Chest(string nom) : base(nom)
        {
        }
        public override void Action(Joueur joueur)
        {
            int random = 0;
            Console.WriteLine(Cartes.chest[random]);
            switch (random)
            {
                case 0:
                    //ACTION
                    break;
                case 1:
                    //Action
                    break;
            }
        }
    }
}