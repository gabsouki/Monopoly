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
                    if(proprietaire == a)
                        {
                        Console.WriteLine("\n"+nom+" est à vous! Vous n'avez rien à payer! Appuyez sur une touche pour continuer");
                        }
                    else
                        {
                        Console.WriteLine("\nVous devez payer " + prix+" à "+proprietaire.Nom+"!");
                        if(a.Argent<loyer[nbrMaison])
                        {
                            do
                            {
                                bool faill = true;
                                foreach(Case el in Planche.monopoly)
                                {
                                if(el.Proprietaire==a)
                                    el.Hypothequer(a, ref faill);
                                }
                                if(faill == true)
                                {
                                a.Faillite = true;
                                }
                                else
                                {
                                  a.Faillite = false;
                                }
                            }while(a.Argent<loyer[nbrMaison]);
                        }

                    Transaction(a, loyer[a.NbrGare], proprietaire);
                    Console.WriteLine("\nVous avez payé " + proprietaire.Nom + "! Vous avez maintenant " + a.Argent + "$");
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
                        Console.WriteLine("\nVoulez-vous ajouter une maison sur " + nom+" pour "+prixMaison+"$? O/N");
                        if(Console.ReadLine().Equals("O")||Console.ReadLine().Equals("o"))
                        { 
                        Transaction(a,prixMaison);
                         nbrMaison ++;
                         Console.WriteLine("\nVous avez ajouter une maison sur " + nom+"! Le terrain a maintenant "+nbrMaison+" maison(s). Il vous reste "+a.Argent+"$.");
                        }
                        else
                        {
                          Console.WriteLine("\nAucune maison ne sera ajoutée");
                        }
                     Console.ReadKey();
                     Console.Clear();
                  }
            }
           else
           {
                if(nbrMaison == 4)
                {
                    Console.WriteLine("\nVoulez-vous ajouter un hotel sur " + nom+" pour "+prixMaison+"$? O/N");
                        if(Console.ReadLine().Equals("O")||Console.ReadLine().Equals("o"))
                        { 
                        Transaction(a, prixMaison);
                        nbrMaison++;
                        Console.WriteLine("\nVous avez ajouter un hotel sur " + nom+"! Le terrain a maintenant un hotel! Il vous reste "+a.Argent+"$.");
                        }
                        else
                        {
                          Console.WriteLine("\nAucun hotel ne sera ajouté");
                        }
                     Console.ReadKey();
                     Console.Clear();
                }
           }                   
        }
    }

}
