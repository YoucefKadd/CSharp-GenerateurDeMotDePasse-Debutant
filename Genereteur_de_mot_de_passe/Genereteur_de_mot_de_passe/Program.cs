using System;

namespace Generateur_de_mo_de_passe // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static int DemanderNombrePositifNonNul(string question)
        {
            return DemanderNombreEntre(question, 1, int.MaxValue);
        }
        static int DemanderNombreEntre(string question, int min, int max)
        {
            

                int nombre = DemanderNombre(question);
                if ((nombre >= min) && (nombre <= max))
                {
                    return nombre;
                }
                Console.WriteLine($"Erreur : le nombre doit être compris entre {min} et {max}");
                return DemanderNombreEntre(question, min, max);
        }
        static int DemanderNombre(String question)
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
                }
            }
        }
        static void Main(string[] args)
        {
           int longueurMotDePasse = DemanderNombre("Longueur du mot de passe :");
        }
    }
}