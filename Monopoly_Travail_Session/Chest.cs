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
                    Console.WriteLine("Payer la taxe scolaire de 150$");
                    Transaction(joueur, 150);
                    break;
                case 1:
                    Console.WriteLine("L'assurance-vie s'accumule, réclamez 100$");
                    Transaction(100, joueur);
                    break;
                case 2:
                    Console.WriteLine("Vous avez gagné le second prix à un concours de beauté, réclamez 10$");
                    Transaction(10, joueur);
                    break;
                case 3:
                    Console.WriteLine("Recevez 25$ pour vos service");
                    Transaction(25, joueur);
                    break;
                case 4:
                    Console.WriteLine("Payer 100$ à l'hopital");
                    Transaction(joueur, 100);
                    break;
               
                    //Autres cartes "Caisse commune"  
            }
        }
    }
}