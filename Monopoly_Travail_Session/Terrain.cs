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
        protected bool hotel;
        protected int prixMaison;
        protected bool estHypotheque;

        //Constructeur
        public Terrain(int position, string nom, int prix, int prixMaison, int prixHotel, int location) : base(position, nom, prix, proprietaire, location)
        {
            nbrMaison = 0;
            this.prixMaison = prixMaison;
            this.prixHotel = prixHotel;
            hotel = false;
        }

        //Méthode
        public void ajouterMaison(Joueur a)
        {
            if(nbrMaison<4 && hotel = false)
            {
                  if(a.argent >= prixMaison)
                  {
                        Console.WriteLine("Voulez-vous ajouter une maison sur "+nom+" pour "+prixMaison+"$?\n O/N");
                        if(Console.ReadLine().Equals("O")||Console.ReadLine().Equals("o"))
                        { 
                         a.argent = a.argent - prixMaison;
                         nbrMaison ++;
                         Console.WriteLine("Vous avez ajouter une maison sur "+nom+"! Le terrain a maintenant "+nbrMaison+" maison(s). Il vous reste "+a.argent+"$.");
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
                if(a.argent>=prixHotel)
                {
                    Console.WriteLine("Voulez-vous ajouter un hotel sur "+nom+" pour "+prixHotel+"$?\n O/N");
                        if(Console.ReadLine().Equals("O")||Console.ReadLine().Equals("o"))
                        { 
                         a.argent = a.argent - prixHotel;
                         nbrMaison ++;
                         Console.WriteLine("Vous avez ajouter un hotel sur "+nom+"! Le terrain a maintenant un hotel! Il vous reste "+a.argent+"$.");
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
