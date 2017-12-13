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
        protected int hypotheque;
        protected bool hypothequer;
        protected int[] loyer;
       
        //Constructeur
        public Gare(string nom, int position) : base (nom, position)
        {
            prix = 200;
            hypotheque = 100;
            hypothequer = false;
            this.loyer = new int[] {0, 25, 50, 100, 200};
        }
        //Méthode
        public override void Action(Joueur a)
        {
        if(hypothequer = false)
             Payer(a);
        else
             Console.WriteLine(nom + " est hypothéqué.");
        }

        //Méthode
        public void Acheter(Joueur a)
        {
           if(a.Argent >= prix)
           {
             Console.WriteLine("Voulez-vous acheter "+nom+" pour "+prix+"$?\n O/N");
             if(Console.ReadLine().Equals("O")||Console.ReadLine().Equals("o"))
              { 
                Transaction(a, prix);
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
                Transaction(hypotheque, a);
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
                 a.NbrGare =a.NbrGare + 1;
                }
                else
                {
                    Console.WriteLine("Vous devez payer "+prix+" à "+proprietaire+"!");
                    if(a.Argent<loyer[a.NbrGare])
                    {
                        do
                        {
                            foreach(Case el in monopoly)
                            {
                              if(el.proprietaire.Equals(a.Identifiant))
                                Hypothequer(a);
                            }
                        }while(a.Argent<loyer[a.NbrGare]);
                    }
                    foreach (Joueurs joueur in joueurs)
                    if(propriétaire.Equals(joueur.Identifiant))
                            {
                              Transaction(a, loyer[a.NbrGare], joueur);
                              Console.WriteLine("Vous avez payé "+joueur.Identifiant+"! Vous avez maintenant "+a.Argent+"$ et il a "+joueur.Argent+"$.");
                            }
                }
                

                
            }
        }
    }
}