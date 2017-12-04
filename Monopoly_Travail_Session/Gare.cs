using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Monopoly
{
    public class Gare : Case
    {
        protected int prix;
        protected int proprietaire;
        protected int location;
       

        public Gare(int position, string nom, int prix, int proprietaire, int location) : base (position, nom)
        {
            this.prix = prix;
            this.proprietaire = proprietaire;
            this.location = location;
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
    }
}