using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Monopoly
{
    public class Service : Case
    {
        public Service(int position,string nom, int prix, int proprietaire, int location) : base(nom)
        {
            throw new System.NotImplementedException();
        }

        public override void Action(Joueur joueur)
        {
            throw new NotImplementedException();
        }

        /*public override void Payer(Joueur a)
>>>>>>> gabriel
        {
                        if(proprietaire.Equals(a.nom))
                Console.WriteLine(nom+" est à vous! Vous n'avez rien à payer!");
            else
            {
                if(propritaire.Equals(null))
                    {
                    Acheter(a);
                    }
                else
                {
                    Console.WriteLine("Vous devez payer "+prix+" à "+proprietaire+"!");
                    if(a.argent>location)
                        a.argent = a.argent - location;
                    else
                    {
                        do
                            {
                             foreach(Case el in monopoly)
                                {
                                  if(el.proprietaire.Equals(a.nom))
                                  Hypothequer(a);
                                }
                             }while(a.argent<location);
                        Console.WriteLine("Vous avez maintenant assez d'argent pour payer!");
                        a.argent = a.argent - location;
                    }
                    
                }
                Console.ReadKey();
                Console.Clear();
            }
<<<<<<< HEAD
        }
=======
        }*/

    }
}