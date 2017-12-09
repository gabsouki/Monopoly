using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Monopoly
{
    public class Joueurs
    {
        List<Joueur> joueurs;
        protected int faillites;

        public Joueurs()
        {
            joueurs = new List<Joueur>();
            faillites = 0;
        }
        public int Ajouter()
        {
            Console.WriteLine("Choisir le nombre de joueurs de 2 à 4.");
            int nombre = Int32.Parse(Console.ReadLine());
            for (int i = 1; i <= nombre; i++)
            {
                Console.WriteLine("Entrez le nom du joueur {0}", i);
                string nom = Console.ReadLine();
                joueurs.Add(new Joueur(i, nom));
            }
            Console.WriteLine("{0} Joueurs ont étés ajoutés.", nombre);
            Console.WriteLine("Appuyez sur une touche pour commencer la partie.");
            Console.ReadKey();
            return nombre-1;
        }
        public Joueur Liste(int identifiant)
        {
            return joueurs[identifiant];
        }
        public void Faillite(Joueur joueur)
        {
            joueur.Faillite = true;
            faillites++;
        }
    }
}
