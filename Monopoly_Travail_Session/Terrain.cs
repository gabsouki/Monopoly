using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Monopoly
{
    public class Terrain : Achetable
    {
        //Attributs
<<<<<<< HEAD
        protected int nbrMaison;
        protected int prixMaison;
        protected bool hotel;
        protected int prixMaison;
        protected bool Hypothequer;

        //Constructeur
        public Terrain(int position, string nom, int prix, int prixMaison, int location, int hypotheque) : base(position, nom)
        {
            this.prix = prix;
            nbrMaison = 0;
            this.prixMaison = prixMaison;
            hotel = false;
            this.hypotheque = hypotheque;
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
                if(a.argent>=prixHotel&&hotel=false)
                {
                    Console.WriteLine("Voulez-vous ajouter un hotel sur "+nom+" pour "+prixHotel+"$?\n O/N");
                        if(Console.ReadLine().Equals("O")||Console.ReadLine().Equals("o"))
                        { 
                         a.argent = a.argent - prix¸Maison;
                         hotel = true;
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
=======
        protected int immeubles;
        protected int prixImmeuble;

        //Constructeur
        public Terrain(string nom, int prix, Joueur proprietaire, int[] loyer, int hypotheque, int prixImmeuble) : base(nom, prix, proprietaire, loyer, hypotheque)
        {
            immeubles = 0;
            this.prixImmeuble = prixImmeuble;
>>>>>>> gabriel
        }
    }

<<<<<<< HEAD

=======
        public override void Action(Joueur joueur)
        {
            if(proprietaire != null)
            {
                Console.WriteLine("Cette propriete appartient a {0}.", proprietaire.Nom);
                Console.WriteLine("Vous devez lui versez un loyer de {0}.", loyer[immeubles]);
                Transaction(joueur, proprietaire, loyer[immeubles]);
            }
            else
            {
                Acheter(joueur);
            }
        }

        //Méthode
        /*public void ajouterMaison(Joueur a)
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
                if(a.argent>=prixHotel&&hotel=false)
                {
                    Console.WriteLine("Voulez-vous ajouter un hotel sur "+nom+" pour "+prixHotel+"$?\n O/N");
                        if(Console.ReadLine().Equals("O")||Console.ReadLine().Equals("o"))
                        { 
                         a.argent = a.argent - prix¸Maison;
                         hotel = true;
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
        }*/
    }


>>>>>>> gabriel
}
