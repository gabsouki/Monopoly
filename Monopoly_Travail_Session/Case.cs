using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Monopoly
{
    public abstract class Case
    {
        //Attributs
        protected int position;
        protected string nom;

        //Constructeur
        public Case(int position, string nom)
        {
            this.position = position;
            this.nom = nom;
        }

        //Méthodes
        public abstract void Acheter();
        public abstract void Hypothequer();
        public abstract void Payer();
        public abstract void Afficher();
        public abstract void Action();
    }
}