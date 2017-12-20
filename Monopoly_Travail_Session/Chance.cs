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
            Random random = new Random();
            int resultat = random.Next(0, 13);
            switch (resultat)
            {
                case 0:
                    Console.WriteLine("\nAvancez à l'avenue Illinois");
                    joueur.Position = 24;
                    Planche.Interaction(joueur);
                    break;
                case 1:
                    Console.WriteLine("\nVous êtes élu président du comité. Payez 50$ à chaque joueur.");
                    Transactions(joueur, 50);
                    break;
                case 2:
                    Console.WriteLine("\nAllez marcher sur la promenade. Avancez votre jeton sur la promenade.");
                    joueur.Position = 39;
                    Planche.Interaction(joueur);
                    break;
                case 3:
                    Console.WriteLine("\nLa banque vous paie une dividende de 50$");
                    Transaction(50, joueur);
                    break;
                case 4:
                    Console.WriteLine("\nAvancez votre jeton au chemin de fer le plus proche et payer le double de la location au propriétaire, à laquelle il a droit. Si le chemin de fer n'est pas vendu, vous pouvez l'acheter.");
                    if (joueur.Position < 5)
                    {
                        joueur.Position = 5;
                        Console.WriteLine("\nVous arrivez au chemin de fer Reading.");
                        Planche.Interaction(joueur);
                    }
                    else if (joueur.Position < 15 && joueur.Position >5)
                    {
                        joueur.Position = 15;
                        Console.WriteLine("\nVous arrivez au chemin de fer Pennsylvania.");
                        Planche.Interaction(joueur);
                    }
                    else if (joueur.Position < 25 && joueur.Position > 15)
                    {
                        joueur.Position = 25;
                        Console.WriteLine("\nVous arrivez au chemin de fer B. & O.");
                        Planche.Interaction(joueur);
                    }
                    else
                    {
                        joueur.Position = 35;
                        Console.WriteLine("\nVous arrivez au chemin de fer Short Line.");
                        Planche.Interaction(joueur);
                    }
                    break;
                case 5:
                    Console.WriteLine("\nAvancez votre jeton au chemin de faire le plus proche et payer le double de la location au propriétaire, à laquelle il a droit. Si le chemin de fer n'est pas vendu, vous pouvez l'acheter.");
                    if (joueur.Position < 5)
                    {
                        joueur.Position = 5;
                        Console.WriteLine("\nVous arrivez au chemin de fer Reading.");
                        Planche.Interaction(joueur);
                    }
                    else if (joueur.Position < 15 && joueur.Position > 5)
                    {
                        joueur.Position = 15;
                        Console.WriteLine("\nVous arrivez au chemin de fer Pennsylvania.");
                        Planche.Interaction(joueur);
                    }
                    else if (joueur.Position < 25 && joueur.Position > 15)
                    {
                        joueur.Position = 25;
                        Console.WriteLine("\nVous arrivez au chemin de fer B. & O.");
                        Planche.Interaction(joueur);
                    }
                    else
                    {
                        joueur.Position = 35;
                        Console.WriteLine("\nVous arrivez au chemin de fer Short Line.");
                        Planche.Interaction(joueur);
                    }
                    break;
                case 6:
                    Console.WriteLine("\nReculez de 3 espaces.");
                    joueur.Position = joueur.Position - 3;
                    Planche.Interaction(joueur);
                    break;
                case 7:
                    Console.WriteLine("\nAvancez à GO. Réclamez 200$");
                    joueur.Position = 0;
                    Planche.Interaction(joueur);
                    break;
                case 8:
                    Console.WriteLine("\nAllez en prison, ne passer pas par GO et ne recevez pas 200$.");
                    joueur.Prison = true;
                    joueur.Position = 10;
                    break;
                case 9:
                    Console.WriteLine("\nPayer la taxe des pauvres de 15$.");
                    Transaction(joueur, 15);
                    break;
                case 10:
                    Console.WriteLine("\nVotre édifice et votre prêt prennent de la valeur, réclamez 150$.");
                    Transaction(150, joueur);
                    break;
                case 11:
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
                case 12:
                    Console.WriteLine("\nSortez de la prison sans frais, cette carte peut être gardée en cas de besoin ou pour être vendue.");
                    joueur.NbrCartePrison++;
                    break;
                case 13:
                    Console.WriteLine("\nAvancez votre jeton au service public le plus près. S'il n'est pas vendu, vous pouvez l'acheter de la banque. S'il est vendu, lancez les dés et payer au propriétaire dix fois le montant indiqué par les dés.");
                    if (joueur.Position < 12)
                    {
                        joueur.Position = 12;
                        Console.WriteLine("\nVous arrivez au Electric Company.");
                        Planche.Interaction(joueur);
                    }
                    else
                    {
                        joueur.Position = 28;
                        Console.WriteLine("\nVous arrivez au Water Works");
                        Planche.Interaction(joueur);
                    }
                    break;

                    // Autres Cartes
            }
        }
    }
}
