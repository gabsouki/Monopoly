using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Monopoly
{
    public class Terrain : Gare
    {
        protected int LocationMaison1;
        protected int LocationMaison2;
        protected int LocationMaison3;
        protected int LocationMaison4;
        protected int LocationHotel;
        protected bool EstHypotheque;

        public Terrain(int Position, string Nom, int Prix, int Proprietaire, int Location, int LocationMaison1, int LocationMaison2, int LocationMaison3, int LocationMaison4, int LocationHotel, bool EstHypotheque) : base(Position, Nom, Prix, Proprietaire, Location)
        {
            this.LocationMaison1 = LocationMaison1;
            this.LocationMaison2 = LocationMaison2;
            this.LocationMaison3 = LocationMaison3;
            this.LocationMaison4 = LocationMaison4;
            this.LocationHotel = LocationHotel;
            this.EstHypotheque = EstHypotheque;
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