using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Monopoly
{
    public class Terrain : Gare
    {
        //Attributs
        protected int maison;
        protected int prixMaison;

        //Constructeur
        public Terrain(string nom, int prix, Joueur proprietaire, int[] loyer, int hypotheque, int prixMaison) : base(nom, prix, proprietaire, loyer, hypotheque)
        {
            maison = 0;
            this.prixMaison = prixMaison;
        }
        public override void Action(Joueur a)
        {
        payer(a);
        }

        //Méthode
        public void addMaison(Joueur a)
        {
            if(nbrMaison<4 && hotel = false)
            {
                  if(a.Argent >= prixMaison)
                  {
                        Console.WriteLine("Voulez-vous ajouter une maison sur "+nom+" pour "+prixMaison+"$?\n O/N");
                        if(Console.ReadLine().Equals("O")||Console.ReadLine().Equals("o"))
                        { 
                        Transaction(a,prixMaison);
                         nbrMaison ++;
                         Console.WriteLine("Vous avez ajouter une maison sur "+nom+"! Le terrain a maintenant "+nbrMaison+" maison(s). Il vous reste "+a.Argent+"$.");
                        }
                        else
                        {
                          Console.WriteLine("Aucune maison ne sera rajoutée");
                        }
                     Console.ReadKey();
                     Console.Clear();
                  }
            }
           else
           {
                if(a.Argent>=prixMaison&&hotel=false)
                {
                    Console.WriteLine("Voulez-vous ajouter un hotel sur "+nom+" pour "+prixMaison+"$?\n O/N");
                        if(Console.ReadLine().Equals("O")||Console.ReadLine().Equals("o"))
                        { 
                        Transaction(a, prixMaison);
                         hotel = true;
                         Console.WriteLine("Vous avez ajouter un hotel sur "+nom+"! Le terrain a maintenant un hotel! Il vous reste "+a.Argent+"$.");
                        }
                        else
                        {
                          Console.WriteLine("Aucun hotel ne sera rajoutée");
                        }
                     Console.ReadKey();
                     Console.Clear();
                }
           }                   
        }
    }

}
