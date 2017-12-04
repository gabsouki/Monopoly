using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Monopoly
{
    public class Joueur
    {
        protected int Position;
        protected string Nom;
        protected int Argent;
        protected bool Faillite;

        public Joueur(int Position, string Nom,int Argent, bool Faillite)
        {
            this.Position = Position;
            this.Nom = Nom;
            this.Argent = Argent;
            this.Faillite = Faillite;
        }

        public void Jouer()
        {
            throw new System.NotImplementedException();
        }
    }
}