using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Monopoly
{
    public abstract class Case
    {
        //Attributs
<<<<<<< HEAD
        protected int position;
=======
>>>>>>> gabriel
        protected string nom;
        protected bool hypothequer;

        //Constructeur
<<<<<<< HEAD
        public Case(int position, string nom)
        {
            hypothequer = false;
            this.position = position;
=======
        public Case(string nom)
        {
>>>>>>> gabriel
            this.nom = nom;
        }

        //Méthodes
<<<<<<< HEAD
        public abstract void Action();
=======
        public abstract void Action(Joueur joueur);

        public void Afficher()
        {
            Console.WriteLine("Vous avez atteri sur la case {0}", nom);
        }
        public void Transaction(Joueur debiteur, Joueur crediteur, int valeurTransaction)
        {
            if (debiteur == null)
            {
                crediteur.Argent = crediteur.Argent + valeurTransaction;
                Console.WriteLine("Vous avez maintenant {0}$", crediteur.Argent);
            }
            else
            {
                if (debiteur.Argent >= valeurTransaction)
                {
                    debiteur.Argent = debiteur.Argent - valeurTransaction;
                    if (crediteur != null)
                        crediteur.Argent = crediteur.Argent + valeurTransaction;
                    Console.WriteLine("Vous avez maintenant {0}$",debiteur.Argent);
                }
                else
                {
                    Console.WriteLine("Vous n'avez pas assez d'argent pour effectuer cette transaction.");
                }
            }
        }
        public void ActionSuivante(Joueur joueur)
        {
            
        }
>>>>>>> gabriel
    }
}