using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Monopoly
{

    public class Jeu
    {
        public List<Joueur> joueurs;

        public Jeu()
        {
            joueurs = new List<Joueur>();
            Dice des = new Dice();

            Console.WriteLine("MONOPOLY");
            int nbjoueurs = ChoixNbJoueurs();

            for (int i = 0; i < nbjoueurs; i++)
            {
                Console.WriteLine("Au tour de {0} de brasser les des",joueurs[i].Nom);
                Console.WriteLine("Appuyer sur une touche pour brasser les des");
                Console.ReadKey();
                int resultat = des.Brasser();
                Console.WriteLine("Vous avez brasse un {0}",resultat);
                Console.WriteLine("Vous avez atteris sur la case {0}");
                Console.ReadKey();
            }
        }
        public int ChoixNbJoueurs()
        {
            Console.WriteLine("Choisir le nombre de joueurs de 2 à 4.");
            int nombre = Int32.Parse(Console.ReadLine());
            for (int i = 1; i <= nombre; i++)
            {
                Console.WriteLine("Entrez le nom du joueur {0}", i);
                string nom = Console.ReadLine();
                Joueur nouvjoueur = new Joueur(i ,nom, 1500, false);
                joueurs.Add(nouvjoueur);
            }
            Console.WriteLine("{0} Joueurs ont étés ajoutés.", nombre);
            Console.ReadKey();
            return nombre;
        }
        public void NouveauJoueur(Joueur joueur)
        {
            joueurs.Add(joueur);
        }
        public int DiceRollTest(int Joueur)
        {
            return 4;
        }

    }
}