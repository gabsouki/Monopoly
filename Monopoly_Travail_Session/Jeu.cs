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
                for (int i = 0; i <= nombreJoueurs - 1; i++)
                {
                    Joueur joueurActuel = joueur.Liste(i);
                    if (joueurActuel.Faillite == true)
                    {
                        Console.WriteLine("\n{0} est en faillite. Le tour est au joueur suivant.", joueurActuel.Nom);
                    }
                    else if (joueurActuel.Prison == true)
                    {
                        Console.WriteLine("\n---------------------------------------");
                        Console.WriteLine("\nAu tour de {0}, mais vous êtes en prison.", joueurActuel.Nom);
                        if (joueurActuel.NbrCartePrison >= 1)
                        {
                            Console.WriteLine("\nVoulez-vous utiliser votre carte pour sortir de prison et jouer au prochain tour? O/N");
                            string input1 = Console.ReadLine();
                            if (input1.Equals("O") || input1.Equals("o"))
                            {
                                joueurActuel.NbrCartePrison--;
                                joueurActuel.Prison = false;
                                joueurActuel.Position = 10;
                            }

                            else if (input1.Equals("N") || input1.Equals("N"))
                            {
                                AllerPrison.Sortir(joueurActuel);
                            }
                        }
                        else
                        {
                            Console.WriteLine("\nEst-ce qu'un joueur veux vous vendre une carte chance ou caisse commune pour sortir de prison O/N");
                            string input1 = Console.ReadLine();
                            if (input1.Equals("O") || input1.Equals("o"))
                            {
                                Console.WriteLine("\nQuel est le nom du joueur qui veut vous vendre la carte vous permettant de sortir de prison ?");
                                string nomPrison = Console.ReadLine();
                                foreach (Joueur joueurPrison in Joueurs.joueurs)
                                {
                                    if (nomPrison.Equals(joueurPrison.Nom))
                                    {
                                        if (joueurPrison.NbrCartePrison >= 1)
                                        {
                                            Console.WriteLine("\nPour quel montant?");
                                            int montantPrison = Int32.Parse(Console.ReadLine());
                                            if (montantPrison <= joueurActuel.Argent)
                                            {
                                                Case.Transaction(joueurActuel, montantPrison, joueurPrison);
                                                joueurPrison.NbrCartePrison--;
                                                AllerPrison.Sortir(joueurActuel);
                                            }
                                            else
                                            {
                                                Console.WriteLine("\nvous n'avez pas assez d'argent pour payer la carte lui permetteant de sortir de prison.");
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine("\nCe joueur ne possède pas de carte vous permettant de sortir de prison. Surveillez le pour le reste de la partie!");
                                            AllerPrison.Sortir(joueurActuel);
                                        }
                                    }
                                }
                            }
                            else
                            {
                                AllerPrison.Sortir(joueurActuel);
                            }
                            
                        }
                    }
                    else
                    {
                        Console.WriteLine("\n---------------------------------------");
                        Console.WriteLine("\nAu tour de {0} de brasser les dés.", joueurActuel.Nom);
                        Console.WriteLine("\nAppuyer sur une touche pour brasser les dés.");
                        Console.ReadKey();

                        int deUn = Dice.Brasser();
                        int deDeux = Dice.Brasser();

                        Console.WriteLine("\nVous avez obtenu {0} et {1}", deUn, deDeux);
                        if (deUn == deDeux)
                        {
                            if (doubles == 2)
                            {
                                Console.WriteLine("\nVous avez brasse 3 doubles de suite. Vous allez directement en prison sans passer par GO.");
                                System.Threading.Thread.Sleep(500);
                                Console.WriteLine("\nVous êtes maintenant en prison.");
                                joueurActuel.Prison = true;
                                joueurActuel.Position = 10;
                                doubles = 0;
                                continue;
                            }
                            else
                            {
                                i--;
                                doubles++;
                                Console.WriteLine("\nVous avez brassé un double, vous devez jouer à nouveau après ce tour.");
                            }
                        }
                        else
                        {
                            doubles = 0;
                        }
                        //Console.ReadKey();
                        if (joueurActuel.Position + deUn + deDeux >= 39)
                        {
                            int actuel = joueurActuel.Position;
                            joueurActuel.Position = (deUn + deDeux + actuel) - 39;
                            //Console.ReadKey();
                        }
                        else
                        {
                            joueurActuel.Position = deUn + deDeux + joueurActuel.Position;
                        }
                        Planche.Interaction(joueurActuel);
                    }
                }
                if (joueur.Faillites == nombreJoueurs - 1)
                {
                game = false;
                }
            } while (game == true);
        }
    }
}