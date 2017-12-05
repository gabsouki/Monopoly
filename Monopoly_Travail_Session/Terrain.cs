using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Monopoly
{
    public class Terrain : Gare
    {

        protected int locationMaison1;
        protected int locationMaison2;
        protected int locationMaison3;
        protected int locationMaison4;
        protected int locationHotel;
        protected bool estHypotheque;

        public Terrain(int position, string nom, int prix, int proprietaire, int location, int locationMaison1, int locationMaison2, int locationMaison3, int locationMaison4, int locationHotel, bool estHypotheque) : base(position, nom, prix, proprietaire, location)
        {
            this.locationMaison1 = locationMaison1;
            this.locationMaison2 = locationMaison2;
            this.locationMaison3 = locationMaison3;
            this.locationMaison4 = locationMaison4;
            this.locationHotel = locationHotel;
            this.estHypotheque = estHypotheque;
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