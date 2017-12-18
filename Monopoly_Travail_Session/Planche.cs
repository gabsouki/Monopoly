using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Monopoly
{
    public static class Planche
    {
        //monopoly[] planche;
        public static List<Case> monopoly;

        //Constructeur
        /*public Planche()
        {
            monopoly = new List<Case>();
        }*/

        public static void Initialiser()
        {
            monopoly = new List<Case>();
            monopoly.Add(new Go("Go"));
            monopoly.Add(new Terrain("Mediterranean Avenue", 60, new int[] { 2, 10, 30, 90, 160, 250 }, 50));
            monopoly.Add(new Chest("Caisse commune"));
            monopoly.Add(new Terrain("Baltic Avenue", 60, new int[] { 4, 20, 60, 180, 320, 450 }, 50));
            monopoly.Add(new Autre("impot"));
            monopoly.Add(new Gare("Reading Railroad"));
            monopoly.Add(new Terrain("Oriental Avenue", 100, new int[] { 6, 30, 90, 270, 400, 550 }, 50));
            monopoly.Add(new Chance("Chance"));
            monopoly.Add(new Terrain("Vermont Avenue", 100, new int[] { 6, 30, 90, 270, 400, 550 }, 50));
            monopoly.Add(new Terrain("Connecticut Avenue", 120, new int[] { 8, 40, 100, 300, 450, 600 }, 50));
            monopoly.Add(new Prison("Visite en prison"));
            monopoly.Add(new Terrain("St. Charles Place", 140, new int[] { 10, 50, 150, 450, 625, 750 }, 100));
            monopoly.Add(new Service("Electric Company"));
            monopoly.Add(new Terrain("States Avenue", 140, new int[] { 10, 50, 150, 450, 625, 750 }, 100));
            monopoly.Add(new Terrain("Virginia Avenue", 160, new int[] { 12, 60, 180, 500, 700, 900 }, 100));
            monopoly.Add(new Gare("Pennsylvania Railroad"));
            monopoly.Add(new Terrain("St. James Place", 180, new int[] { 14, 70, 200, 550, 750, 950 }, 100));
            monopoly.Add(new Chest("Caisse commune"));
            monopoly.Add(new Terrain("Tennessee Avenue", 180, new int[] { 14, 70, 200, 550, 750, 950 }, 100));
            monopoly.Add(new Terrain("New York Avenue", 200, new int[] { 16, 80, 220, 600, 800, 1000 }, 100));
            monopoly.Add(new Autre("parking"));
            monopoly.Add(new Terrain("Kentucky Avenue", 220, new int[] { 18, 90, 250, 700, 875, 1050 }, 150));
            monopoly.Add(new Chance("Chance"));
            monopoly.Add(new Terrain("Indiana Avenue", 220, new int[] { 18, 90, 250, 700, 875, 1050 }, 150));
            monopoly.Add(new Terrain("Illinois Avenue", 240, new int[] { 20, 100, 300, 750, 925, 1100 }, 150));
            monopoly.Add(new Gare("B & O Railroad"));
            monopoly.Add(new Terrain("Atlantic Avenue", 260, new int[] { 22, 110, 330, 800, 975, 1150 }, 150));
            monopoly.Add(new Terrain("Ventnor Avenue", 260, new int[] { 22, 110, 330, 800, 975, 1150 }, 150));
            monopoly.Add(new Service("Water Works"));
            monopoly.Add(new Terrain("Marvin Gardens", 280, new int[] { 24, 120, 360, 850, 1025, 1200 }, 150));
            monopoly.Add(new AllerPrison("Allez en prison"));
            monopoly.Add(new Terrain("Pacific Avenue", 300, new int[] { 26, 130, 390, 900, 1100, 1275 }, 200));
            monopoly.Add(new Terrain("North Carolina Avenue", 300, new int[] { 26, 130, 390, 900, 1100, 1275 }, 200));
            monopoly.Add(new Chest("Caisse commune"));
            monopoly.Add(new Terrain("Pennsylvania Avenue", 320, new int[] { 28, 150, 450, 1000, 1200, 1400 }, 200));
            monopoly.Add(new Gare("Short Line Railroad"));
            monopoly.Add(new Chance("Chance"));
            monopoly.Add(new Terrain("Park Place", 350, new int[] { 35, 175, 500, 1100, 1300, 1500 }, 200));
            monopoly.Add(new Autre("taxe"));
            monopoly.Add(new Terrain("Boardwalk", 400, new int[] { 50, 200, 600, 1400, 1700, 2000 }, 200));
        }

        /*public void PasserGo()
        {
            throw new System.NotImplementedException();
        }*/
        public static void Interaction(Joueur joueur)
        {
            monopoly[joueur.Position].Afficher();
            monopoly[joueur.Position].Action(joueur);
            //monopoly[joueur.Position].ActionSuivante(joueur);
        }
    }
}