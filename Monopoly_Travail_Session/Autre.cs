using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Monopoly
{
    public class Autre : Case
    {
        //Constructeur
       public Autre(string nom)
        {
            this.nom = nom;
        }

        //méthode
        public override void Action(Joueur a)
        {
            if(nom.Equals(impot))
            {
                Console.WriteLine("Vous êtes sur la case Impôt sur le Revenu! Vous devez payer 200$!");
                if (a.Argent < 200)
                {
                    do
                    {
                        foreach (Case el in Planche.monopoly)
                        {
                            if (proprietaire.Equals(a))
                                Hypothequer(a);
                        }
                    } while (a.Argent < 200);
                }
            
                Transaction(a, 200);
                Console.WriteLine("Vous avez maintenant " + a.Argent + "$");
            }
            if(nom.Equals(taxe))
            {
                Console.WriteLine("Vous êtes sur la case Taxes de luxe! Vous devez payer 100$!");
                if (a.Argent < 100)
                {
                    do
                    {
                        foreach (Case el in Planche.monopoly)
                        {
                            if (proprietaire.Equals(a))
                                Hypothequer(a);
                        }
                    } while (a.Argent < 100);
                }

                Transaction(a, 100);
                Console.WriteLine("Vous avez maintenant " + a.Argent + "$");
            }
            if(nom.Equals(parking))
            {
                Console.WriteLine("Vous êtes sur la case Stationnement Gratuit! Prenez une pause, vous la méritez!");
            }
        }
    }
}