using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormationCS
{
    static class Outils
    {
        public static int DemanderNombrePositifNonNul(string question)
        {
            return DemanderNombreEntre(question, 1, int.MaxValue, "Erreur : le nombre doit etre positifet non nul");
        }
        public static int DemanderNombreEntre(string question, int min, int max, string messageErreurPersonalise = null)
        { // le string messageErreurPersonalise = null permet d'indiquer que c'est optionnel


            int nombre = DemanderNombre(question);
            if ((nombre >= min) && (nombre <= max))
            {
                return nombre;
            }
            if (messageErreurPersonalise == null)
            {
                Console.WriteLine($"Erreur : le nombre doit être compris entre {min} et {max}");
            }
            else
            {
                Console.WriteLine(messageErreurPersonalise); 
            }
            Console.WriteLine();
            return DemanderNombreEntre(question, min, max);
        }
        public static int DemanderNombre(String question)
        {
            while (true)
            {
                Console.Write(question);
                String reponse = Console.ReadLine();
                try
                {
                    int reponseInt = int.Parse(reponse);
                    return reponseInt;

                }
                catch
                {
                    Console.WriteLine("Erreur : vous devez rentrer un nombre !");
                    Console.WriteLine();
                }
            }
        }
    }
}
