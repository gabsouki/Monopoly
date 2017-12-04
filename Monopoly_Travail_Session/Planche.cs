using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Monopoly
{
    public class Planche
    {
        public Planche()
        {
            throw new System.NotImplementedException();
        }

        public void Initialiser()
        {
            Case AveMedit = new Terrain(2,"Avenue Méditéranéenne",60,0,2,10,30,90,160,250,false);
            Case AveBalti = new Terrain(4,"Avenue Baltimore",60,0,4,20,60,180,320,450,false);
        }

        public void PasserGo()
        {
            throw new System.NotImplementedException();
        }
    }
}