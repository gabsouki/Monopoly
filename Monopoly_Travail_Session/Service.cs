using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Monopoly
{
    public class Service : Gare
    {
        public Service(int Position,string Nom, int Prix, int Proprietaire, int Location) : base(Position, Nom, Prix, Proprietaire, Location)
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