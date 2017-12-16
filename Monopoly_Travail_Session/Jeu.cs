using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Monopoly
{
    public class Jeu
    {
        public Jeu()
        {
            Joueurs joueur = new Joueurs();
            //Planche cases = new Planche();
            Dice des = new Dice();

            Console.WriteLine("MONOPOLY");
            int nombreJoueurs = joueur.Ajouter();
            Planche.Initialiser();
            int doubles = 0;
            bool game = true;
            do
            {
                for (int i = 0; i <= nombreJoueurs; i++)
                {
                    Joueur joueurActuel = joueur.Liste(i);
                    if(joueurActuel.Faillite == true)
                    {
                        Console.WriteLine("{0} est en faillite. Le tour est au joueur suivant.", joueurActuel.Nom);
                    }
                    else if (joueurActuel.Prison == true)
                    {
                        Console.WriteLine("{0}, vous etes en prison, vous passez votre tour.", joueurActuel.Nom);
                        joueurActuel.Prison = false;
                    }
                    else
                    {
                        Console.WriteLine("Au tour de {0} de brasser les des.\n", joueurActuel.Nom);
                        Console.WriteLine("Appuyer sur une touche pour brasser les des.");
                        Console.ReadKey();
                        int deUn = Dice.Brasser();
                        int deDeux = Dice.Brasser();

                        Console.WriteLine("Vous avez obtenu {0} et {1}", deUn, deDeux);
                        if (deUn == deDeux)
                        {
                            if (doubles == 3)
                            {
                                Console.WriteLine("Vous avez brasse 3 doubles en ligne. Vous allez directement en prison sans passer go.");
                                joueurActuel.Prison = true;
                                joueurActuel.Position = 30;
                            }
                            else
                            {
                                i--;
                                doubles++;
                                Console.WriteLine("Vous avez brasse un double, vous devez jouer a nouveau apres ce tour.");
                            }
                        }
                        else
                        {
                            doubles = 0;
                        }
                        Console.ReadKey();
                        if(joueurActuel.Position+deUn+deDeux>=39)
                        {
                            int compteFin = 39 - joueurActuel.Position;
                            joueurActuel.Position = (deUn + deDeux) - compteFin;
                        }
                        else
                        {
                            joueurActuel.Position = deUn + deDeux;
                        }
                        Planche.Interaction(joueurActuel);
                    }
                }
                if (joueur.Faillites == nombreJoueurs-1)
                    game = false;
            } while (game == true);
        }
    }
}