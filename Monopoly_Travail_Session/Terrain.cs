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
        public Terrain(string nom, int prix, Joueur proprietaire, int[] loyer, int hypotheque, int prixMaison) : base(nom, prix, proprietaire, loyer, hypotheque)
        {
            nbrMaison = 0;
            this.prixMaison = prixMaison;
        }
        public override void Action(Joueur a)
        {
        payer(a);
        }

        //Méthode
        public override void Payer(Joueur a)
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
                        }while(a.Argent<loyer[nbrMaison]);
                    }
                    foreach (Joueurs joueur in joueurs)
                    if(propriétaire.Equals(joueur.Identifiant))
                            {
                              Transaction(a, loyer[nbrMaison], joueur);
                              Console.WriteLine("Vous avez payé "+joueur.Identifiant+"! Vous avez maintenant "+a.Argent+"$ et il a "+joueur.Argent+"$.");
                            }
                }
                

                
            }
        }
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
                          Console.WriteLine("Aucune maison ne sera ajoutée");
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
                          Console.WriteLine("Aucun hotel ne sera ajouté");
                        }
                     Console.ReadKey();
                     Console.Clear();
                }
           }                   
        }
    }

}
