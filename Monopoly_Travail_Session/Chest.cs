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
            int resultat = random.Next(0, 11);
            switch (resultat)
            {
                case 0:
                    Console.WriteLine("\nPayer la taxe scolaire de 150$.");
                    Transaction(joueur, 150);
                    break;
                case 1:
                    Console.WriteLine("\nL'assurance-vie s'accumule, réclamez 100$.");
                    Transaction(100, joueur);
                    break;
                case 2:
                    Console.WriteLine("\nVous avez gagné le second prix à un concours de beauté, réclamez 10$.");
                    Transaction(10, joueur);
                    break;
                case 3:
                    Console.WriteLine("\nRecevez 25$ pour vos service.");
                    Transaction(25, joueur);
                    break;
                case 4:
                    Console.WriteLine("\nPayer 100$ à l'hopital.");
                    Transaction(joueur, 100);
                    break;
                case 5:
                    Console.WriteLine("\nReculez de 3 espaces.");
                    joueur.Position = joueur.Position - 3;
                    Planche.Interaction(joueur);
                    break;
                case 6:
                    Console.WriteLine("\nAvancez à GO.");
                    joueur.Position = 0;
                    Planche.Interaction(joueur);
                    break;
                case 7:
                    Console.WriteLine("\nAllez en prison, ne passer pas par GO et ne recevez pas 200$.");
                    joueur.Prison = true;
                    joueur.Position = 10;
                    break;
                case 8:
                    Console.WriteLine("\nPayer la taxe des pauvres de 15$.");
                    Transaction(joueur, 15);
                    break;
                case 9:
                    Console.WriteLine("\nVotre édifice et votre prêt prennent de la valeur, réclamez 150$.");
                    Transaction(150, joueur);
                    break;
                case 10:
                    Console.WriteLine("\nVoyagez par le chemin de fer Reading. Si vous passez go réclamez 200$.");
                    if (joueur.Position < 5)
                    {
                        joueur.Position = 5;
                        Console.WriteLine("\nVous ne passez pas par GO, vous ne réclamez pas 200$.");
                        Planche.Interaction(joueur);
                    }
                    else
                    {
                        joueur.Position = 5;
                        Console.WriteLine("\nVous passez par GO, vous réclamez 200$.");
                        Transaction(200, joueur);
                        Planche.Interaction(joueur);
                    }
                    break;
                case 11:
                    Console.WriteLine("\nSortez de la prison sans frais, cette carte peut être gardée en cas de besoin ou pour être vendue.");
                    joueur.NbrCartePrison++;
                    break;
                



                    //Autres cartes "Caisse commune"  
            }
        }
    }
}