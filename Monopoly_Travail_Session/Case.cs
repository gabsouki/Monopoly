using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Monopoly
{
    public class Case
    {
        //Attributs
        protected string nom;
        //protected bool hypothequer;
        //protected int position;

        //Constructeur
        public Case(string nom)
        {
            this.nom = nom;
        }

        //Méthodes
        public virtual void Action(Joueur joueur)
        {
            
        }

        public void Afficher()
        {
            Console.WriteLine("Vous avez atteri sur la case {0}!", nom);
        }
        public void Transaction(Joueur payeur, int montant, Joueur receveur)
        {
            Transaction(payeur, montant);
            Transaction(montant, receveur);
        }
         public static void Transaction(Joueur payeur, int montant)
        {
            payeur.Argent = payeur.Argent - montant;
        }
        public void Transaction(int montant, Joueur receveur)
        {
            receveur.Argent = receveur.Argent + montant;
        }
    }
}