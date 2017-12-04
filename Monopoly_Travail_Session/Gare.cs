using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Monopoly
{
    public class Gare : Case
    {
        protected int Prix;
        protected int Proprietaire;
        protected int Location;
       

        public Gare(int Position, string Nom, int Prix, int Proprietaire, int Location) : base (Position, Nom)
        {
            this.Prix = Prix;
            this.Location = Location;
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