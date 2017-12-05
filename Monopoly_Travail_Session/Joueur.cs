using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Monopoly
{
    public class Joueur
    {
        protected int position;
        protected string nom;
        protected int argent;
        protected bool faillite;

        public Joueur(int position, string nom,int argent, bool faillite)
        {
            this.position = position;
            this.nom = nom;
            this.argent = argent;
            this.faillite = faillite;
        }

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