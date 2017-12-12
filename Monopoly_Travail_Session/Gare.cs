using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Monopoly
{
    public class Gare : Case
    {
        //Attributs
        protected int prix;
        protected string proprietaire;
        protected int location;
        protected int hypotheque;
        protected bool hypothequer;
       
        //Constructeur
        public Gare(string nom, int location) : base (nom)
        {
            prix = 200;
            this.location = location;
            hypotheque = 100;
            hypothequer = false;
        }
        //Méthode
        public override void Action(Joueur a)
        {
        if(hypothequer = false)
             Payer(a);
        }

        //Méthode
        public void Acheter(Joueur a)
        {
           if(a.Argent >= prix)
           {
             Console.WriteLine("Voulez-vous acheter "+nom+" pour "+prix+"$?\n O/N");
             if(Console.ReadLine().Equals("O")||Console.ReadLine().Equals("o"))
              { 
                a.Argent = a.Argent - prix;
                proprietaire = a.Identifiant;
                Console.WriteLine("Félicitation, vous êtes le nouveau propriétaire de "+nom+"! Il vous reste "+a.Argent+"$.");

              }
            else
                {
                  Console.WriteLine(+nom+ "est mis au Enchère!");
                }
             Console.ReadKey();
             Console.Clear();
           }
        }
        public void Hypothequer(Joueur a)
        {
           if(locataire.Equals(a.Identifiant))
                Console.WriteLine("Voulez-vous hypothèquer "+nom+" pour "+hypotheque+"$?\n O/N");
             if(Console.ReadLine().Equals("O")||Console.ReadLine().Equals("o"))
              { 
                a.Argent = a.Argent + hypotheque;
                hypothequer = true;
                Console.WriteLine("Vous avec hypothèquer "+nom+"! Vous avez maintenant "+a.Argent+"$.");

              }
            else
                Console.WriteLine(nom+ "n'a pas été hypothèquer.");
            Console.ReadKey();
            Console.Clear();

        }

        public virtual void Payer(Joueur a)
        {
            if(proprietaire.Equals(a.Identifiant))
                Console.WriteLine(nom+" est à vous! Vous n'avez rien à payer!");
            else
            {
                if(propritaire.Equals(null))
                {
                Acheter(a);
                }
                else
                {
                    Console.WriteLine("Vous devez payer "+prix+" à "+proprietaire+"!");
                    if(a.Argent<location)
                    {
                        do
                        {
                            foreach(Case el in monopoly)
                            {
                              if(el.proprietaire.Equals(a.Identifiant))
                                Hypothequer(a);
                            }
                        }while(a.Argent<location);
                    }
                    a.Argent = a.Argent - location;

                }
                
                
            }
        }
    }
}