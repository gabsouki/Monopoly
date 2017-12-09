using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Monopoly
{
    public class Planche

    {
<<<<<<< HEAD


=======
        //Attribut
        monopoly[] planche;

        //Constructeur
>>>>>>> bc195a0... Début de service et tableau Planche
        public Planche()
        {
            planche = new monopoly[40]; 
        }

        public void Initialiser()
        {
<<<<<<< HEAD
            Case aveMedit = new Terrain(2,"Avenue Méditéranéenne",60,0,2,10,30,90,160,250,false);
            Case aveBalti = new Terrain(4,"Avenue Baltimore",60,0,4,20,60,180,320,450,false);
=======
            monopoly[0];
>>>>>>> bc195a0... Début de service et tableau Planche
        }

        public void PasserGo()
        {
            throw new System.NotImplementedException();
        }
    }
}