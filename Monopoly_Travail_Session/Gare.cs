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
        protected Joueur proprietaire;
        protected bool estHypotheque;
        protected int[] loyer;
       
        //Constructeur
        public Gare(string nom, int prix, int[] loyer) : base (nom)
        {
            prix = 200;
            estHypotheque = false;
            proprietaire = null;
            this.loyer = new int[] {0, 25, 50, 100, 200};
        }
        //Méthode
        public override void Action(Joueur a)
        {
        if(estHypotheque == false)
             Payer(a);
        else
             Console.WriteLine(nom + " est hypothéqué.");
        }

        //Méthode
        public void Acheter(Joueur joueur)
        {
           if(joueur.Argent >= prix)
           {
             Console.WriteLine("Voulez-vous acheter "+nom+" pour "+prix+"$?\n O/N");
             if(Console.ReadLine().Equals("O")||Console.ReadLine().Equals("o"))
              { 
                Transaction(joueur, prix);
                proprietaire = joueur;
                Console.WriteLine("Félicitation, vous êtes le nouveau propriétaire de "+nom+"! Il vous reste "+joueur.Argent+"$.");

              }
            else
                {
                  Console.WriteLine(nom + "est mis au Enchère!");
                }
             Console.ReadKey();
             Console.Clear();
           }
        }
        public void Hypothequer(Joueur joueur)
        {
           if(proprietaire.Equals(joueur.Identifiant))
                Console.WriteLine("Voulez-vous hypothèquer "+nom+" pour "+ prix/2 +"$?\n O/N");
             if(Console.ReadLine().Equals("O")||Console.ReadLine().Equals("o"))
              { 
                Transaction(null, prix/2, joueur);
                estHypotheque = true;
                Console.WriteLine("Vous avec hypothèquer "+nom+"! Vous avez maintenant "+ joueur.Argent+"$.");
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
                if(proprietaire.Equals(null))
                {
                Acheter(a);
                a.NbrGare = a.NbrGare++;
                }
                else
                {
                    Console.WriteLine("Vous devez payer "+prix+" à "+proprietaire+"!");
                    if(a.Argent<loyer[a.NbrGare])
                    {
                        do
                        {
                            foreach(Case el in Planche.monopoly)
                            {
                              if(proprietaire.Equals(a))
                                Hypothequer(a);
                            }
                        }while(a.Argent<loyer[a.NbrGare]);
                    }

                    Transaction(a, loyer[a.NbrGare], proprietaire);
                    Console.WriteLine("Vous avez payé " + proprietaire.Nom + "! Vous avez maintenant " + a.Argent + "$");
                }
            }
        }
    }
}