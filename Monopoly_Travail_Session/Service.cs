using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Monopoly
{
    public class Service : Gare
    {
        Dice des = new Dice();

        public Service(string nom) : base(nom)
        {
            prix = 150;
            proprietaire = null;
        }

        public override void Action(Joueur joueur)
        {
            Payer(joueur);
        }

        public override void Payer(Joueur joueur)
        {
            if(proprietaire == joueur)
                Console.WriteLine(nom+" est à vous! Vous n'avez rien à payer!");
            else
            {
                if(proprietaire == null)
                    {
                        Acheter(joueur);
                    }
                else
                {
                    Console.WriteLine("Brassez les dés pour connaître le loyer à payer");
                    int deUn = Dice.Brasser();
                    int deDeux = Dice.Brasser();
                    Console.WriteLine("Vous avez obtenu {0} et {1}", deUn, deDeux);
                    int loyerService = (deUn + deDeux) * 10;
                    Console.WriteLine("Vous devez payer "+loyerService+" à "+proprietaire.Nom+"!");
                    if(joueur.Argent>loyerService)
                        joueur.Argent = joueur.Argent - loyerService;
                    else
                    {
                        do
                            {
                     bool faill = true;
                    foreach (Case el in Planche.monopoly)
                    {
                        if (proprietaire.Equals(joueur))
                            Hypothequer(joueur, ref faill);
                    }
                    if (faill == true)
                    {
                        joueur.Faillite = true;
                    }
                    else
                    {
                        joueur.Faillite = false;
                    }
                        }while(joueur.Argent<loyerService);
                        Console.WriteLine("Vous avez maintenant assez d'argent pour payer!");
                        joueur.Argent = joueur.Argent - loyerService;
                    }
                }
                Console.ReadKey();
            }
        }
    }
}