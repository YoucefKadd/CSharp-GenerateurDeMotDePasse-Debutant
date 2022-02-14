using System;
using FormationCS;

namespace Generateur_de_mo_de_passe // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int longueurMotDePasse = Outils.DemanderNombre("Longueur du mot de passe :");

            string miniscules = "azertyuiopqsdfghjklmwxcvbn";
            string alphabet = miniscules;

            int l = alphabet.Length;  

            
            Random rand = new Random();
            int index = rand.Next(0, l);
            Console.WriteLine(alphabet[index]);


        }
    }
}