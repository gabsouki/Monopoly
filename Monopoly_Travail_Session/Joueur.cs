using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Monopoly
{
    public class Joueur
    {
        //Attributs
        protected int position;
        protected string nom;
        protected int argent;
        protected bool faillite;

        //Constructeurs
        public Joueur(int position, string nom, bool faillite)
        {
            this.position = position;
            this.nom = nom;
            argent = 1500;
            this.faillite = faillite;
        }

        //Méthodes
        public void Jouer()
        {
            throw new System.NotImplementedException();
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