using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Monopoly
{
    public class Terrain : Gare
    {
        //Attributs
        protected int nbrMaison;
        protected int prixMaison;

        //Constructeur
        public Terrain(string nom, int prix, int[] loyer, int prixMaison) : base(nom)
        {
            nbrMaison = 0;
            proprietaire = null;
            this.prix = prix;
            this.prixMaison = prixMaison;
            this.loyer = loyer;
            this.prix = prix;
        }

        //Méthodes
        public override void Action(Joueur a)
        {
            Payer(a);
        }
        public override void Payer(Joueur a)
        {
                if(acheter == false)
                {
                Acheter(a);
                acheter = true;
                }
                else
                {
                    if(proprietaire.Equals(a))
                        {
                        Console.WriteLine(nom+" est à vous! Vous n'avez rien à payer!");
                        }
                    else
                        {
                        Console.WriteLine("Vous devez payer "+prix+" à "+proprietaire.Nom+"!");
                        if(a.Argent<loyer[nbrMaison])
                        {
                            do
                            {
                                foreach(Case el in Planche.monopoly)
                                {
                                if(proprietaire.Equals(a))
                                    Hypothequer(a);
                                }
                            }while(a.Argent<loyer[nbrMaison]);
                        }

                    Transaction(a, loyer[a.NbrGare], proprietaire);
                    Console.WriteLine("Vous avez payé " + proprietaire.Nom + "! Vous avez maintenant " + a.Argent + "$");
                }
                Console.ReadKey();
            }
        }
        public void addMaison(Joueur a)
        {
            if(nbrMaison < 4)
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
                          Console.WriteLine("Aucune maison ne sera ajoutée");
                        }
                     Console.ReadKey();
                     Console.Clear();
                  }
            }
           else
           {
                if(nbrMaison == 4)
                {
                    Console.WriteLine("Voulez-vous ajouter un hotel sur "+nom+" pour "+prixMaison+"$?\n O/N");
                        if(Console.ReadLine().Equals("O")||Console.ReadLine().Equals("o"))
                        { 
                        Transaction(a, prixMaison);
                        nbrMaison++;
                        Console.WriteLine("Vous avez ajouter un hotel sur "+nom+"! Le terrain a maintenant un hotel! Il vous reste "+a.Argent+"$.");
                        }
                        else
                        {
                          Console.WriteLine("Aucun hotel ne sera ajouté");
                        }
                     Console.ReadKey();
                     Console.Clear();
                }
           }                   
        }
    }

}
