using System;
using FormationCS;

namespace Generateur_de_mo_de_passe // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int longueurMotDePasse = Outils.DemanderNombre("Longueur du mot de passe :");

            string miniscules = "azertyuiopqsdfghjklmwxcvbn";
            string alphabet = miniscules;
            string motDePasse = "";
            int longueurAlphabet = alphabet.Length;
            Random rand = new Random();


            for (int i = 0; i < longueurMotDePasse; i++)
            {
                int index = rand.Next(0, longueurAlphabet);
                motDePasse += alphabet[index];

            }
            //Console.WriteLine(alphabet[index]);

            Console.WriteLine($"Mot de passe : {motDePasse}");


        }
    }
}