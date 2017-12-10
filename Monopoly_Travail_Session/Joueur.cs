using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Monopoly
{
    public class Joueur
    {
        //Attributs
<<<<<<< HEAD
=======
        protected int identifiant;
>>>>>>> gabriel
        protected int position;
        protected string nom;
        protected int argent;
        protected bool faillite;
        protected bool prison;

        //Constructeurs
<<<<<<< HEAD
        public Joueur(int position, string nom, bool faillite)
=======
        public Joueur(int identifiant, string nom)
>>>>>>> gabriel
        {
            this.identifiant = identifiant;
            position = 0;
            this.nom = nom;
            argent = 1500;
<<<<<<< HEAD
            this.faillite = faillite;
        }

        //Méthodes
        public void Jouer()
=======
            faillite = false;
            prison = false;
        }

        //Méthodes
        public bool Faillite
>>>>>>> gabriel
        {
            get
            {
                return faillite;
            }
            set
            {
                faillite = value;
            }
        }
        public int Identifiant
        {
            get
            {
                return identifiant;
            }
        }
        public bool Prison
        {
            get
            {
                return prison;
            }
            set
            {
                prison = value;
            }
        }
        public int Argent
        {
            get
            {
                return argent;
            }
            set
            {
                argent = value;
            }
        }
        public int Position
        {
            get
            {
                return position;
            }
            set
            {
                    position = position + value;
            }
        }
        public string Nom
        {
            get
            {
                return nom;
            }
        }
    }
}