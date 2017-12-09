using System;
using System.Collections.Generic;

namespace Monopoly
{
    public abstract class Achetable : Case
    {
        protected Joueur proprietaire;
        protected int prix;
        protected int[] loyer;
        protected int hypotheque;
        protected bool isHypotheque;

        public Achetable(string nom, int prix, Joueur proprietaire, int[] loyer, int hypotheque) : base (nom)
        {
            this.prix = prix;
            this.proprietaire = proprietaire;
            this.hypotheque = hypotheque;
            this.loyer = loyer;
        }
        public void Acheter(Joueur joueur)
        {
            if (joueur == proprietaire)
            {
                Console.WriteLine("Cette propriete vous appartient deja.");
            }
            else
            {
                Console.WriteLine("Cette propriete est disponible au prix de {0}, desirez-vous l'acheter?", prix);
                Console.WriteLine("Entrez \"O\" pour l'acheter, \"N\" pour passer votre tour.");
                string input = Console.ReadLine();
                if(input == "O")
                {
                    Transaction(joueur, null, prix);
                    Console.WriteLine("Vous etes maintenant proprietaire de {0}", nom);
                }
            }
        }
    }
}