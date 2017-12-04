using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Monopoly
{
    public class Dice
    {
        protected int DeUn;
        protected int DeDeux;

        public Dice(int DeUn, int DeDeux)
        {
            this.DeUn = DeUn;
            this.DeDeux = DeDeux;
        }

        public void Brasser()
        {
            throw new System.NotImplementedException();
        }
        public void VerifDouble()
        {
            
        }
    }
}