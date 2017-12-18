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
            //monopoly.Add(new Speciale("Go","go"));
            monopoly.Add(new Terrain("Mediterranean Avenue", 60, new int[] { 2, 10, 30, 90, 160, 250 }, 50));
            //monopoly.Add(new Chest("Caisse commune"));
            monopoly.Add(new Terrain("Baltic Avenue", 60, new int[] { 4, 20, 60, 180, 320, 450 }, 50));
<<<<<<< HEAD
            monopoly.Add(new Autre("impot"));
=======
            //monopoly.Add(new Impot("Impot sur le revenu"));
>>>>>>> a255fe1d4efd14f2bba833682c871df0f2fe76e8
            monopoly.Add(new Gare("Reading Railroad"));
            monopoly.Add(new Terrain("Oriental Avenue", 100, new int[] { 6, 30, 90, 270, 400, 550 }, 50));
            //monopoly.Add(new Chance("Chance"));
            monopoly.Add(new Terrain("Vermont Avenue", 100, new int[] { 6, 30, 90, 270, 400, 550 }, 50));
            monopoly.Add(new Terrain("Connecticut Avenue", 120, new int[] { 8, 40, 100, 300, 450, 600 }, 50));
            monopoly.Add(new Prison("Visite en prison"));
            monopoly.Add(new Terrain("St. Charles Place", 140, new int[] { 10, 50, 150, 450, 625, 750 }, 100));
            monopoly.Add(new Service("Electric Company"));
            monopoly.Add(new Terrain("States Avenue", 140, new int[] { 10, 50, 150, 450, 625, 750 }, 100));
            monopoly.Add(new Terrain("Virginia Avenue", 160, new int[] { 12, 60, 180, 500, 700, 900 }, 100));
            monopoly.Add(new Gare("Pennsylvania Railroad"));
            monopoly.Add(new Terrain("St. James Place", 180, new int[] { 14, 70, 200, 550, 750, 950 }, 100));
            //monopoly.Add(new Chest("Caisse commune"));
            monopoly.Add(new Terrain("Tennessee Avenue", 180, new int[] { 14, 70, 200, 550, 750, 950 }, 100));
            monopoly.Add(new Terrain("New York Avenue", 200, new int[] { 16, 80, 220, 600, 800, 1000 }, 100));
<<<<<<< HEAD
            monopoly.Add(new Autre("parking"));
=======
            //monopoly.Add(new Stationnement("Stationnement Gratuit"));
>>>>>>> a255fe1d4efd14f2bba833682c871df0f2fe76e8
            monopoly.Add(new Terrain("Kentucky Avenue", 220, new int[] { 18, 90, 250, 700, 875, 1050 }, 150));
            //monopoly.Add(new Chance("Chance"));
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
            //monopoly.Add(new Chest("Caisse commune"));
            monopoly.Add(new Terrain("Pennsylvania Avenue", 320, new int[] { 28, 150, 450, 1000, 1200, 1400 }, 200));
            monopoly.Add(new Gare("Short Line Railroad"));
            //monopoly.Add(new Chance("Chance"));
            monopoly.Add(new Terrain("Park Place", 350, new int[] { 35, 175, 500, 1100, 1300, 1500 }, 200));
<<<<<<< HEAD
            monopoly.Add(new Autre("taxe"));
=======
            //monopoly.Add(new Taxe("Taxe de luxe"));
>>>>>>> a255fe1d4efd14f2bba833682c871df0f2fe76e8
            monopoly.Add(new Terrain("Boardwalk", 400, new int[] { 50, 200, 600, 1400, 1700, 2000 }, 200));


            /*
            monopoly[1] = new Terrain("Mediterranean Avenue", 60, null, new int[] { 2, 10, 30, 90, 160, 250 }, 30, 50);
            monopoly[3] = new Terrain("Baltic Avenue", 60, null, new int[] { 4, 20, 60, 180, 320, 450 }, 30, 50);
            monopoly[5] = new Gare(6, "Chemin de fer Reading");
            monopoly[6] = new Terrain("Oriental Avenue", 100, null, new int[] { 6, 30, 90, 270, 400, 550 }, 50, 50);
            monopoly[8] = new Terrain("Vermont Avenue", 100, null, new int[] { 6, 30, 90, 270, 400, 550 }, 50, 50);
            monopoly[9] = new Terrain("Connecticut Avenue", 120, null, new int[] { 8, 40, 100, 300, 450, 600 }, 60, 50);
            monopoly[11] = new Terrain("St. Charles Place", 140, null, new int[] { 10, 50, 150, 450, 625, 750 }, 70, 100);
            monopoly[13] = new Terrain("States Avenue", 140, null, new int[] { 10, 50, 150, 450, 625, 750 }, 70, 100);
            monopoly[14] = new Terrain("Virginia Avenue", 160, null, new int[] { 12, 60, 180, 500, 700, 900 }, 80, 100);
            monopoly[15] = new Gare(16, "Chemin de fer Pennsylvanie");
            monopoly[16] = new Terrain("St. James Place", 180, null, new int[] { 14, 70, 200, 550, 750, 950 }, 90, 100);
            monopoly[18] = new Terrain("Tennessee Avenue", 180, null, new int[] { 14, 70, 200, 550, 750, 950 }, 90, 100);
            monopoly[19] = new Terrain("New York Avenue", 200, null, new int[] { 16, 80, 220, 600, 800, 1000 }, 100, 100);
            monopoly[21] = new Terrain("Kentucky Avenue", 220, null, new int[] { 18, 90, 250, 700, 875, 1050 }, 110, 150);
            monopoly[23] = new Terrain("Indiana Avenue", 220, null, new int[] { 18, 90, 250, 700, 875, 1050 }, 110, 150);
            monopoly[24] = new Terrain("Illinois Avenue", 240, null, new int[] { 20, 100, 300, 750, 925, 1100 }, 120, 150);
            monopoly[25] = new Gare(26, "Chemin de fer B. & O.");
            monopoly[26] = new Terrain("Atlantic Avenue", 260, null, new int[] { 22, 110, 330, 800, 975, 1150 }, 130, 150);
            monopoly[27] = new Terrain("Ventnor Avenue", 260, null, new int[] { 22, 110, 330, 800, 975, 1150 }, 130, 150);
            monopoly[29] = new Terrain("Marvin Gardens", 280, null, new int[] { 24, 120, 360, 850, 1025, 1200 }, 140, 150);
            monopoly[31] = new Terrain("Pacific Avenue", 300, null, new int[] { 26, 130, 390, 900, 1100, 1275 }, 150, 200);
            monopoly[32] = new Terrain("North Carolina Avenue", 300, null, new int[] { 26, 130, 390, 900, 1100, 1275 }, 150, 200);
            monopoly[34] = new Terrain("Pennsylvania Avenue", 320, null, new int[] { 28, 150, 450, 1000, 1200, 1400 }, 160, 200);
            monopoly[35] = new Gare(36, "Chemin de fer Petit Réseau");
            monopoly[37] = new Terrain("Park Place", 350, null, new int[] { 35, 175, 500, 1100, 1300, 1500 }, 175, 200);
            monopoly[39] = new Terrain("Boardwalk", 400, null, new int[] { 50, 200, 600, 1400, 1700, 2000 }, 200, 200);

            /*
            monopoly.Add(new Terrain("Avenue de la Méditerranée", 60, null, new int[] { 2, 10, 30, 90, 160, 250 }, 30, 50)); 
            monopoly[4] = new Evenement(5, "Impôt sur le revenu", 200);
            monopoly[6] = new Terrain(7, "Avenue de l’Orient", 100, 50, 6, 50);
            monopoly[7] = new Carte(8);
            monopoly[8] = new Terrain(9, "Avenue Vermont", 100, 50, 6, 50);
            monopoly[9] = new Terrain(10, "Avenue Connecticut", 120, 50, 8, 60);
            monopoly[10] = new Prison(11);
            monopoly[11] = new Terrain(12, "Place St-Charles", 140, 100, 10, 70);
            monopoly[12] = new Service(13, "Compagnie d'électricité");
            monopoly[13] = new Terrain(14, "Avenue des États-Unis", 140, 100, 10, 70);
            monopoly[14] = new Terrain(15, "Avenue Virginie", 160, 100, 12, 80);

            monopoly[16] = new Terrain(17, "Place St-Jacques", 180, 100, 14, 90);
            monopoly[17] = new Carte(18);
            monopoly[18] = new Terrain(19, "Avenue Tennessee", 180, 100, 14, 90);
            monopoly[19] = new Terrain(20, "Avenue New York", 200, 100, 16, 100);
            monopoly[20] = new Stationnement(21);
            monopoly[21] = new Terrain(22, "Avenue Kentucky", 220, 150, 18, 110);
            monopoly[22] = new Carte(23);
            monopoly[23] = new Terrain(24, "Avenue Indiana", 220, 150, 18, 110);
            monopoly[24] = new Terrain(25, "Avenue Illinois", 240, 150, 20, 120);

            monopoly[26] = new Terrain(27, "Avenue Atlantique", 260, 150, 22, 130);
            monopoly[27] = new Terrain(28, "Avenue Ventnor", 260, 150, 22, 130);
            monopoly[28] = new Service(29, "Aqueduc");
            monopoly[29] = new Terrain(30, "Jardins Marvin", 280, 150, 24, 140);
            monopoly[30] = new AllerPrison(31);
            monopoly[31] = new Terrain(32, "Avenue Pacifique", 300, 200, 26, 150);
            monopoly[32] = new Terrain(33, "Avenue Caroline du Nord", 300, 200, 26, 150);
            monopoly[33] = new Carte(34);
            monopoly[34] = new Terrain(35, "Avenue Pennsylvanie", 320, 200, 28, 160);
            
            monopoly[36] = new Carte(37);
            monopoly[37] = new Terrain(38, "Place du Parc", 350, 200, 35, 175);
            monopoly[38] = new Evenement(39, "Taxes de luxe", 75);
            monopoly[39] = new Terrain(40, "Promenade", 400, 200, 50, 200);
            */
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