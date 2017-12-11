using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Monopoly
{
    public class Planche
    {
        monopoly[] planche;

        //Constructeur
        public Planche()
        {
            monopoly = new planche[40];
        }


        public void Initialiser()
        {
            //monopoly[0] = new Go();
            monopoly.Add(new Terrain("Avenue de la Méditerranée", 60, null, new int[] { 2, 10, 30, 90, 160, 250 }, 30, 50));
            monopoly.Add(new Terrain("Avenue de la Méditerranée", 60, null, new int[] { 2, 10, 30, 90, 160, 250 }, 30, 50));
            monopoly.Add(new Terrain("Avenue de la Méditerranée", 60, null, new int[] { 2, 10, 30, 90, 160, 250 }, 30, 50));
            //monopoly[2] = new Carte(3);
            monopoly.Add(new Terrain("Avenue de la Baltique",60,null,new int[] {4, 20, 60, 180, 320, 450},30,50));
            //monopoly[4] = new Evenement(5, "Impôt sur le revenu", 200);
            monopoly[5] = new Gare(6, "Chemin de fer Reading");
            monopoly[6] = new Terrain(7, "Avenue de l’Orient", 100, 50, 6, 50);
            monopoly[7] = new Carte(8);
            monopoly[8] = new Terrain(9, "Avenue Vermont", 100, 50, 6, 50);
            monopoly[9] = new Terrain(10, "Avenue Connecticut", 120, 50, 8, 60);
            monopoly[10] = new Prison(11);
            monopoly[11] = new Terrain(12, "Place St-Charles", 140, 100, 10, 70);
            monopoly[12] = new Service(13, "Compagnie d'électricité");
            monopoly[13] = new Terrain(14, "Avenue des États-Unis", 140, 100, 10, 70);
            monopoly[14] = new Terrain(15, "Avenue Virginie", 160, 100, 12, 80);
            monopoly[15] = new Gare(16, "Chemin de fer Pennsylvanie");
            monopoly[16] = new Terrain(17, "Place St-Jacques", 180, 100, 14, 90);
            monopoly[17] = new Carte(18);
            monopoly[18] = new Terrain(19, "Avenue Tennessee", 180, 100, 14, 90);
            monopoly[19] = new Terrain(20, "Avenue New York", 200, 100, 16, 100);
            monopoly[20] = new Stationnement(21);
            monopoly[21] = new Terrain(22, "Avenue Kentucky", 220, 150, 18, 110);
            monopoly[22] = new Carte(23);
            monopoly[23] = new Terrain(24, "Avenue Indiana", 220, 150, 18, 110);
            monopoly[24] = new Terrain(25, "Avenue Illinois", 240, 150, 20, 120);
            monopoly[25] = new Gare(26, "Chemin de fer B. & O.");
            monopoly[26] = new Terrain(27, "Avenue Atlantique", 260, 150, 22, 130);
            monopoly[27] = new Terrain(28, "Avenue Ventnor", 260, 150, 22, 130);
            monopoly[28] = new Service(29, "Aqueduc");
            monopoly[29] = new Terrain(30, "Jardins Marvin", 280, 150, 24, 140);
            monopoly[30] = new AllerPrison(31);
            monopoly[31] = new Terrain(32, "Avenue Pacifique", 300, 200, 26, 150);
            monopoly[32] = new Terrain(33, "Avenue Caroline du Nord", 300, 200, 26, 150);
            monopoly[33] = new Carte(34);
            monopoly[34] = new Terrain(35, "Avenue Pennsylvanie", 320, 200, 28, 160);
            monopoly[35] = new Gare(36, "Chemin de fer Petit Réseau");
            monopoly[36] = new Carte(37);
            monopoly[37] = new Terrain(38, "Place du Parc", 350, 200, 35, 175);
            monopoly[38] = new Evenement(39, "Taxes de luxe", 75);
            monopoly[39] = new Terrain(40, "Promenade", 400, 200, 50, 200);
*/
        }

        public void PasserGo()
        {
            throw new System.NotImplementedException();
        }
        public void Interaction(Joueur joueur)
        {
            monopoly[joueur.Position].Afficher();
            monopoly[joueur.Position].Action(joueur);
            monopoly[joueur.Position].ActionSuivante(joueur);
        }
    }
}