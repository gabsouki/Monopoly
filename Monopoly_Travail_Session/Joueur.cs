using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Monopoly
{
    public class Joueur
    {
        //Attributs
        protected int identifiant;
        protected int position;
        protected string nom;
        protected int argent;
        protected bool faillite;
        protected bool prison;
        protected int nbrCartePrison;
        int nbrGare;

        //Constructeurs
        public Joueur(int identifiant, string nom)
        {
            this.identifiant = identifiant;
            position = 0;
            this.nom = nom;
            argent = 1500;
            faillite = false;
            prison = false;
            nbrCartePrison = 0;
            nbrGare = 0;
        }

        //Méthodes
        /*public void Jouer()
            faillite = false;
            prison = false;
        }*/

        //Méthodes
        public bool Faillite
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
        public int NbrGare
        {
            get
            {
                return nbrGare;
            }
            set
            {
                nbrGare = value;
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
                position = value;
            }
        }
        public string Nom
        {
            get
            {
                return nom;
            }
        }
        public int NbrCartePrison
        {
            get
            {
                return nbrCartePrison;
            }
            set
            {
                nbrCartePrison = value;
            }
        }
    }
}