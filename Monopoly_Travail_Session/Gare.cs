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
        protected bool estHypotheque;
        protected int[] loyer;
        protected bool acheter;
       
        //Constructeur
        public Gare(string nom) : base (nom)
        {
            prix = 200;
            estHypotheque = false;
            proprietaire = null;
            loyer = new int[] {0, 25, 50, 100, 200};
            acheter = false;
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
             Console.WriteLine("\n" + nom + " est hypothéqué.");
        }

        public void Acheter(Joueur joueur)
        {
           if(joueur.Argent >= prix)
           {
             Console.WriteLine("\nVoulez-vous acheter " + nom+" pour "+prix+"$?\n O/N");
             string input = Console.ReadLine();
             if(input.Equals("O") || input.Equals("o"))
              { 
                Transaction(joueur, prix);
                proprietaire = joueur;
                Console.WriteLine("\nFélicitation, vous êtes le nouveau propriétaire de " + nom+"! Il vous reste "+joueur.Argent+"$.");
                Console.WriteLine("\nAppuyer sur une touche pour continuer.");
                //Console.ReadKey();
              }
            
              else
              {
                  Console.WriteLine("\n" + nom + " est mis aux Enchères!");
                    Enchere();
              }
           }
           else
           {    
                    Console.WriteLine("\n Vous n'avez pas assez d'argent pour acheter cette propriété. Elle sera donc mise aux enchères.");
                    Enchere();
           }
             Console.ReadKey();
           
        }
        public override void Hypothequer(Joueur a, ref bool faill)
        {
           if(proprietaire == a)
           {
             Console.WriteLine("\nVoulez-vous hypothèquer " + nom+" pour "+ prix/2 +"$?\n O/N");
             string input = Console.ReadLine();
             if(input.Equals("O")||input.Equals("o"))
              { 
                Transaction(prix/2, a);
                estHypotheque = true;
                Console.WriteLine("\nVous avec hypothèquer " + nom+"! Vous avez maintenant "+ a.Argent+"$.");
              }
            else
            {

                Console.WriteLine(nom+ "n'a pas été hypothèqué.");
                faill = false;

                Console.WriteLine("\n" + nom + "n'a pas été hypothèqué.");

            }
            Console.ReadKey();
            Console.Clear();
            }
        }

        public virtual void Payer(Joueur a)
        {
            if(proprietaire == a)
                Console.WriteLine("\n" + nom + " est à vous! Vous n'avez rien à payer!");
            else
            {
                if (acheter == false)
                {
                Acheter(a);
                acheter = true;
                a.NbrGare = a.NbrGare++;
                }
                else
                {
                    Console.WriteLine("\nVous devez payer " + prix+" à "+proprietaire+"!");
                    if(a.Argent<loyer[a.NbrGare])
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
                        }while(a.Argent<loyer[a.NbrGare]);
                    }

                    Transaction(a, loyer[a.NbrGare], proprietaire);
                    Console.WriteLine("\nVous avez payé " + proprietaire.Nom + "! Vous avez maintenant " + a.Argent + "$");
                    Console.ReadKey();
                }


            }
        }
        public void Enchere()
        {
            Console.WriteLine("\nL'enchère dure 30 secondes. Le joueur ayant dit le plus gros montant après le chronomètre remporte le terrain. Attendez le début du chronomètre...");
            System.Threading.Thread.Sleep(10000);
            Console.WriteLine("\nC'est parti!");
            for(int i=30; i>=0; i--)
                {
                Console.WriteLine(i);
                System.Threading.Thread.Sleep(1000);
                //Console.Clear();
                }
            do
            {
                Console.WriteLine("\nFin de l'enchère!\r\nQuel est le nom du joueur qui a remporter l'enchère? Inscrire A pour annuler l'enchère.");
                string nomEnc = Console.ReadLine();
                if (nomEnc != "A" || nomEnc != "a")
                {
                    foreach (Joueur joueurEnc in Joueurs.joueurs)
                    {
                        if (nomEnc.Equals(joueurEnc.Nom))
                        {
                            Console.WriteLine("\nPour quel montant?");
                            int montantEnc = Int32.Parse(Console.ReadLine());
                            if (montantEnc <= joueurEnc.Argent)
                            {
                                Transaction(joueurEnc, montantEnc);
                                proprietaire = joueurEnc;
                                acheter = true;
                                Console.WriteLine("\nFélicitation " + nomEnc + ",vous êtes le nouveau propriétaire de " + nom + ". Appuyer sur un touche pour continuer.");
                            }
                            else
                            {
                                Console.WriteLine("\nLe joueur n'a pas assez d'argent pour payer. Le joueur d'avant remporte l'enchère.");
                            }
                        }
                    }
                }
                else
                {
                    Console.WriteLine("\nL'enchère est annulée!");
                    acheter = false;
                }
            }while (acheter == false);
        }
    }
}