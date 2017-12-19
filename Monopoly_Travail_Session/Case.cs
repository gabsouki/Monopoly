using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Monopoly
{
    public abstract class Case
    {
        //Attributs
        protected string nom;
        protected Joueur proprietaire;

        //Constructeur
        public Case(string nom)
        {
            this.nom = nom;
        }

        //Méthodes
        public Joueur Proprietaire
            {
            get{return proprietaire;}
            }
        public abstract void Action(Joueur joueur);
        public void Afficher()
        {
            Console.WriteLine("\nVous avez atteri sur la case {0}!", nom);
        }
        public static void Transaction(Joueur payeur, int montant, Joueur receveur)
        {
                Transaction(payeur, montant);
                Transaction(montant, receveur);
        }
         public static void Transaction(Joueur payeur, int montant)
        {
                payeur.Argent = payeur.Argent - montant;
        }
        public static void Transaction(int montant, Joueur receveur)
        {
            receveur.Argent = receveur.Argent + montant;
        }
        public static void Transactions(Joueur payeur, int montant)
        {
            foreach(Joueur j in Joueurs.joueurs)
                {
                Transaction(payeur, montant, j);
                }
        }
        public static void Transactions(int montant, Joueur receveur)
        {
            foreach(Joueur j in Joueurs.joueurs)
                {
                Transaction(j, montant, receveur);
                }
        }
        public virtual void Hypothequer(Joueur a, ref bool faill)
            {
            }
    }
}