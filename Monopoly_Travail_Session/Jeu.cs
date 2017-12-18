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
                for (int i = 0; i <= nombreJoueurs-1; i++)
                {
                    Joueur joueurActuel = joueur.Liste(i);
                    if(joueurActuel.Faillite == true)
                    {
                        Console.WriteLine("{0} est en faillite. Le tour est au joueur suivant.", joueurActuel.Nom);
                    }
                    else if (joueurActuel.Prison == true)
                    {
                        Console.WriteLine("{0}, vous etes en prison.", joueurActuel.Nom);
                        Console.WriteLine("Voulez-vous payer pour sortir de prison? O/N");
                        string input = Console.ReadLine();
                        if(input.Equals("O") || input.Equals("o"))
                        {
                                Case.Transaction(joueurActuel,50);
                                joueurActuel.Prison = false;
                                joueurActuel.Position = 30;
                        }
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
                        //Console.ReadKey();
                        if(joueurActuel.Position+deUn+deDeux>=29)
                        {
                            int actuel = joueurActuel.Position;
                            joueurActuel.Position = (deUn + deDeux + actuel) - 29;
                            //Console.ReadKey();
                        }
                        else
                        {
                            joueurActuel.Position = deUn + deDeux + joueurActuel.Position;
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