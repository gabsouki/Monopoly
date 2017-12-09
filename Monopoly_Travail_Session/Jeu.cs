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
            Planche cases = new Planche();
            Dice des = new Dice();

            Console.WriteLine("MONOPOLY");
            int nombreJoueurs = joueur.Ajouter();
            cases.Initialiser();
            int doubles = 0;
            do
            {
                for (int i = 0; i <= nombreJoueurs; i++)
                {
                    Joueur joueurActuel = joueur.Liste(i);
                    if (joueurActuel.Prison == true)
                    {
                        Console.WriteLine("{0}, vous etes en prison, vous passez votre tour.");
                        joueurActuel.Prison = false;
                    }
                    else
                    {
                        Console.WriteLine("Au tour de {0} de brasser les des.\n", joueurActuel.Nom);
                        Console.WriteLine("Appuyer sur une touche pour brasser les des.");
                        Console.ReadKey();
                        Console.WriteLine("Vous avez obtenu {0} et {1}", des.Brasser()[0], des.Brasser()[1]);
                        if (des.Brasser()[0] == des.Brasser()[1])
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
                        if(joueurActuel.Position+des.Brasser()[0]+des.Brasser()[1]>=39)
                        {
                            int compteFin = 39 - joueurActuel.Position;
                            joueurActuel.Position = (des.Brasser()[0] + des.Brasser()[1]) - compteFin;
                        }
                        else
                        {
                            joueurActuel.Position = des.Brasser()[0] + des.Brasser()[1];
                        }
                        cases.Interaction(joueurActuel);
                    }
                }
            } while (true);
        }
    }
}