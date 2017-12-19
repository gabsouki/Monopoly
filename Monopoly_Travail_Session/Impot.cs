using System;
namespace Monopoly
{
    public class Impot : Case
    {
        public Impot(string nom) : base(nom)
        {
        }
        public override void Action(Joueur joueur)
        {
            Console.WriteLine("Vous êtes arrivé sur la case Impôt. Vous devez payer 200$.");
            if (joueur.Argent < 200)
            {
                do
                {
                    bool faill = true;
                    foreach (Case el in Planche.monopoly)
                    {
                        if (proprietaire.Equals(joueur))
                            Hypothequer(a, faill);
                    }
                    if (faill == true)
                    {
                        joueur.Faillite = true;
                    }
                    else
                    {
                        joueur.Faillite = false;
                    }
                } while (joueur.Argent < 200);
            }
            Transaction(joueur, 200);
        }
    }
}
