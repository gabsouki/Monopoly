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
        protected bool hypothequer;

        //Constructeur
        public Case(int position, string nom)
        {
            hypothequer = false;
            this.position = position;
            this.nom = nom;
        }

        //Méthodes
        public abstract void Action();
    }
}