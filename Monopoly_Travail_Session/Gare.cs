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
<<<<<<< HEAD
        public Gare(int position, string nom, int location) : base (position, nom)
        {
            prix = 200;
            this.location = location;
            Hypotheque = 100;
            hypothequer = false;
        }

        //Méthode
        public void Acheter(Joueur a)
=======
        public Gare(int position, string nom, int location) : base (nom)
        {
            prix = 200;
            this.location = location;
            hypotheque = 100;
            hypothequer = false;
        }
        public override void Action(Joueur joueur)
>>>>>>> gabriel
        {
           if(a.argent >= prix)
           {
             Console.WriteLine("Voulez-vous acheter "+nom+" pour "+prix+"$?\n O/N");
             if(Console.ReadLine().Equals("O")||Console.ReadLine().Equals("o"))
              { 
                a.argent = a.argent - prix;
                proprietaire = a.nom;
                Console.WriteLine("Félicitation, vous êtes le nouveau propriétaire de "+nom+"! Il vous reste "+a.argent+"$.");

<<<<<<< HEAD
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
           if(locataire.Equals(a.nom))
                Console.WriteLine("Voulez-vous hypothèquer "+nom+" pour "+hypotheque+"$?\n O/N");
             if(Console.ReadLine().Equals("O")||Console.ReadLine().Equals("o"))
              { 
                a.argent = a.argent + hypotheque;
                hypothequer = true;
                Console.WriteLine("Vous avec hypothèquer "+nom+"! Vous avez maintenant "+a.argent+"$.");

              }
            else
                Console.WriteLine(nom+ "n'a pas été hypothèquer.");
            Console.ReadKey();
            Console.Clear();

        }

        public virtual void Payer(Joueur a)
        {
            if(proprietaire.Equals(a.nom))
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
                    if(a.argent>location)
                        a.argent = a.argent - location;
                    else
                    {
                        do
                        {
                            foreach(Case el in monopoly)
                            {
                              if(el.proprietaire.Equals(a.nom))
                                Hypothequer(a);
                            }
                        }while(a.argent<location);
                    }
                
                }
            }
        }
        public virtual void Action(Joueur a)
        {
            if(hypothequer = false)
             Payer(a);

        }

=======
        //Méthode
       /* public void Acheter(Joueur a)
        {
           if(a.argent >= prix)
           {
             Console.WriteLine("Voulez-vous acheter "+nom+" pour "+prix+"$?\n O/N");
             if(Console.ReadLine().Equals("O")||Console.ReadLine().Equals("o"))
              { 
                a.argent = a.argent - prix;
                proprietaire = a.nom;
                Console.WriteLine("Félicitation, vous êtes le nouveau propriétaire de "+nom+"! Il vous reste "+a.argent+"$.");

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
           if(locataire.Equals(a.nom))
                Console.WriteLine("Voulez-vous hypothèquer "+nom+" pour "+hypotheque+"$?\n O/N");
             if(Console.ReadLine().Equals("O")||Console.ReadLine().Equals("o"))
              { 
                a.argent = a.argent + hypotheque;
                hypothequer = true;
                Console.WriteLine("Vous avec hypothèquer "+nom+"! Vous avez maintenant "+a.argent+"$.");

              }
            else
                Console.WriteLine(nom+ "n'a pas été hypothèquer.");
            Console.ReadKey();
            Console.Clear();

        }

        public virtual void Payer(Joueur a)
        {
            if(proprietaire.Equals(a.nom))
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
                    if(a.argent>location)
                        a.argent = a.argent - location;
                    else
                    {
                        do
                        {
                            foreach(Case el in monopoly)
                            {
                              if(el.proprietaire.Equals(a.nom))
                                Hypothequer(a);
                            }
                        }while(a.argent<location);
                    }
                
                }
            }
        }*/
>>>>>>> gabriel
    }
}