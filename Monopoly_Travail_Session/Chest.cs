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
            Random random = new Random();
            int resultat = random.Next(0, 16);
            switch (resultat)
            {
                case 0:
                    Console.WriteLine("\nAllez en prison ne passer pas par GO et ne recevez pas 200$.");
                    joueur.Prison = true;
                    joueur.Position = 30;
                    break;
                case 1:
                    Console.WriteLine("\nFrais du medecin, payez 50$.");
                    Transaction(joueur, 50);
                    break;
                case 2:
                    Console.WriteLine("\nAvancer à la case GO et réclamer 200$.");
                    joueur.Position = 0;
                    Transaction(200, joueur);
                    break;
                case 3:
                    Console.WriteLine("\nPayer la taxe des pauvres de 15$.");
                    Transaction(joueur, 15);
                    break;
                case 4:
                    Console.WriteLine("\nVotre édifice et votre prêt prennent de la valeur, réclamez 150$.");
                    Transaction(150, joueur);
                    break;
                case 5:
                    Console.WriteLine("\nLe fonds de noël s'accumule, réclamez 100$.");
                    Transaction(100, joueur);
                    break;
                case 6:
                    Console.WriteLine("\nErreur de la banque en votre faveur réclamez 200$.");
                    Transaction(200, joueur);
                    break;
                case 7:
                    Console.WriteLine("\nPayez la taxe scolaire de 150$.");
                    Transaction(joueur, 150);
                    break;
                case 8:
                    Console.WriteLine("\nVous avez gagné le second prix à un concours de beauté, réclamez 10$.");
                    Transaction(10, joueur);
                    break;
                case 9:
                    Console.WriteLine("\nL'assurance-vie s'accumule, réclamez 100$.");
                    Transaction(100, joueur);
                    break;
                case 10:
                    Console.WriteLine("\nRecevez 25$ pour vos services.");
                    Transaction(25, joueur);
                    break;
                case 11:
                    Console.WriteLine("\nPayer 100$ à l'hopital.");
                    Transaction(joueur, 100);
                    break;
                case 12:
                    Console.WriteLine("\nRemboursement de l'impôt sur le revenu, réclamez 20$.");
                    Transaction(20, joueur);
                    break;
                case 13:
                    Console.WriteLine("\nVous obtenez 45$ pour la vente d'actions.");
                    Transaction(45, joueur);
                    break;
                case 14:
                    Console.WriteLine("\nVous héritez de 100$.");
                    Transaction(100, joueur);
                    break;
                case 15:
                    Console.WriteLine("\nSortez de la prison sans frais, cette carte peut être gardée en cas de besoin ou pour être vendue.");
                    joueur.NbrCartePrison++;
                    break;
                case 16:
                    Console.WriteLine("\nOuverture de l'opéra, réclamez 50$ de chaque joueur.");
                    Transactions(50, joueur);
                    break;
                //Autres cartes "Caisse commune"  
            }
        }
    }
}