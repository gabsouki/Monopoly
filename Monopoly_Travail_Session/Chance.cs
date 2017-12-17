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
                    Console.WriteLine("Payer la taxe des pauvres de 15$");
                    Transaction(joueur, 15);
                    break;
                case 4:
                    Console.WriteLine("Votre edifice et votre prêt prennent de la valeur, réclamez 150$");
                    joueur.Position = 0;
                    Transaction(joueur, 150);
                    break;
                    // Autres Cartes
            }
        }
    }
}
