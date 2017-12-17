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
                case 2:
                    Console.WriteLine("Avancer à la case GO et réclamer 200$.");
                    joueur.Position = 0;
                    Transaction(200, joueur);
                    break;
                case 3:
                    Console.WriteLine("Avancer à la case GO et réclamer 200$.");
                    joueur.Position = 0;
                    Transaction(200, joueur);
                    break;
                //Autres cartes "Caisse commune"  
            }
        }
    }
}