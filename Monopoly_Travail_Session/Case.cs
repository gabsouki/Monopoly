using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Monopoly
{
    public abstract class Case
    {
        protected int position;
        protected string nom;

        public Case(int position, string nom)
        {
            this.position = position;
            this.nom = nom;
        }

        public void Acheter()
        {
            throw new System.NotImplementedException();
        }

        public void Hypothequer()
        {
            throw new System.NotImplementedException();
        }

        public void Payer()
        {
            throw new System.NotImplementedException();
        }
        public void Afficher()
        {
            
        }
    }
}