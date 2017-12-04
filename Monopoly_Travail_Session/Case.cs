using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Monopoly
{
    public abstract class Case
    {
        protected int Position;
        protected string Nom;

        public Case(int Position, string Nom)
        {
            this.Position = Position;
            this.Nom = Nom;
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