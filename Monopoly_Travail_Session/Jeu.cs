using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Monopoly
{

    public class Jeu
    {
        private List<Joueur> joueurs;

        public Jeu()
        {
            joueurs = new List<Joueur>();

            Console.WriteLine("MONOPOLY");
            int nbjoueurs = ChoixNbJoueurs();

            for (int i = 1; i <= nbjoueurs; i++)
            {
                
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