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

        //Constructeur
        public Case(string nom)
        {
            this.nom = nom;
        }

        //Méthodes
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
    }
}