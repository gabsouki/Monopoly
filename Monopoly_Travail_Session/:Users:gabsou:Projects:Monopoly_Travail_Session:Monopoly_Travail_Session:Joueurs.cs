using System;
using System.Collections.Generic;

namespace Monopoly
{
    public class Joueurs
    {
        List<Joueur> joueurs;

        protected int nombre;

        public void Ajouter()
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
        }
        public int Nombre
        {
            get
            {
                return nombre;
            }
        }
        public Joueur Liste(int identifiant)
        {
            return joueurs[identifiant];
        }
    }
}
