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
        public Gare(string nom) : base (nom)
        {
            prix = 200;
            estHypotheque = false;
            proprietaire = null;
            loyer = new int[] {0, 25, 50, 100, 200};
        }

        //Accesseur
        public Joueur Proprietaire
       {
            get
            { 
            return proprietaire;
            }
        }

        //Méthodes
        public override void Action(Joueur a)
        {
        if(estHypotheque == false)
             Payer(a);
        else
             Console.WriteLine(nom + " est hypothéqué.");
        }

        public void Acheter(Joueur joueur)
        {
           if(joueur.Argent >= prix)
           {
             Console.WriteLine("Voulez-vous acheter "+nom+" pour "+prix+"$?\n O/N");
             string input = Console.ReadLine();
             if(input.Equals("O") || input.Equals("o"))
              { 
                Transaction(joueur, prix);
                proprietaire = joueur;
                Console.WriteLine("Félicitation, vous êtes le nouveau propriétaire de "+nom+"! Il vous reste "+joueur.Argent+"$.");
                Console.WriteLine("Appuyer sur une touche pour continuer.");
                //Console.ReadKey();
              }
            
              else
              {
                  Console.WriteLine(nom + "est mis aux Enchères!");
                    Enchere();
              }
             Console.ReadKey();
           }
        }
        public void Hypothequer(Joueur a)
        {
           if(proprietaire.Equals(a))
           {
             Console.WriteLine("Voulez-vous hypothèquer "+nom+" pour "+ prix/2 +"$?\n O/N");
             string input = Console.ReadLine();
             if(input.Equals("O")||input.Equals("o"))
              { 
                Transaction(null, prix/2, a);
                estHypotheque = true;
                Console.WriteLine("Vous avec hypothèquer "+nom+"! Vous avez maintenant "+ a.Argent+"$.");
              }
            else
            {
                Console.WriteLine(nom+ "n'a pas été hypothèqué.");
            }
            Console.ReadKey();
            Console.Clear();
            }
        }

        public virtual void Payer(Joueur a)
        {
            if(proprietaire == a)
                Console.WriteLine(nom+" est à vous! Vous n'avez rien à payer!");
            else
            {
                if (proprietaire == null)
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
                    Console.ReadKey();
                }


            }
        }
        public void Enchere()
        {
            Console.WriteLine("L'enchère dure 30 secondes. Le joueur ayant dit le plus gros montant après le chronomètre remporte le terrain.");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("C'est parti!");
            for(int i=30; i>=0; i--)
                {
                Console.WriteLine(i);
                System.Threading.Thread.Sleep(1000);
                Console.Clear();
                }
            do
            {
            Console.WriteLine("Fin de l'enchère! \n Quel est le nom du joueur qui a remporter l'enchère?");
            string nome = Console.ReadLine();
           foreach(Joueur a in Joueurs.joueurs)
            {
              if(nome.Equals(a.Nom))
                {
                      Console.WriteLine("Pour quel montant?");
                       int monte = Int32.Parse(Console.ReadLine());
                       if(monte<a.Argent)
                            {
                            Transaction(a, monte);
                             proprietaire = a;
                            }
                       else
                            Console.WriteLine("Le joueur n'a pas assez d'argent pour payer. Le joueur d'avant remporte l'enchère.");

                }
            }
            }while (proprietaire.Equals(null));
        }
    }
}