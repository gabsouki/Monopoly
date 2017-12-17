using System;
namespace Monopoly
{
    public class Chance : Case
    {
        public Chance(string nom) : base(nom)
        {
        }
        public override void Action(Joueur joueur)
        {
            int random = 0;
            Console.WriteLine(Cartes.chance[random]);
            switch (random)
            {
                case 0:
                    Console.WriteLine("Allez en prison ne passer pas par GO et ne recevez pas 200$.");
                    Prison.Entrer(joueur);
                    break;
                case 1:
                    Console.WriteLine("Avancer à la case GO et réclamer 200$.");
                    joueur.Position = 0;
                    Transaction(200, joueur);
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
                // Autres Cartes
            }
        }
    }
}
