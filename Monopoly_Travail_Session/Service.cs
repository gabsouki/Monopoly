using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Monopoly
{
    public class Service : Gare
    {
        public Service(int position,string nom, int prix, int proprietaire, int location) : base(position, nom, prix, proprietaire, location)
        {
            throw new System.NotImplementedException();
        }

        public void Acheter()
        {
            throw new System.NotImplementedException();
        }

        public void Payer()
        {
            throw new System.NotImplementedException();
        }
    }
}