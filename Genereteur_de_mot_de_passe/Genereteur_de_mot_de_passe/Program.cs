using System;
using FormationCS;

namespace Generateur_de_mo_de_passe // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int NB_MOT_DE_PASSE = 10;
            int longueurMotDePasse = Outils.DemanderNombre("Longueur du mot de passe :");
            Console.WriteLine();


            // Vous voulez un mot de passe avec :
            // 1 - uniquement des caractere en miniscule
            // 2 - des caracteres miniscule et majuscule
            // 3 - des caractere et des chiffres
            // 4 - caracteres, chiffres et carctere spéciaux

            int choixAlphabet = Outils.DemanderNombreEntre("Vous voulez un mot de passe avec :\n" +
                "1 - uniquement des caractere en miniscule\n" +
                "2 - des caracteres miniscule et majuscule\n" +
                "3 - des caractere et des chiffres\n" +
                "4 - caracteres, chiffres et carctere spéciaux\n" +
                $"Votre choix :      ", 1, 4);

            string miniscules = "azertyuiopqsdfghjklmwxcvbn";
            string majuscules = miniscules.ToUpper();
            string chiffres = "0123456789";
            string caracteresSpeciaux = "&#+-.";
            string alphabet= "";
            string motDePasse = "";
            Random rand = new Random();

            if (choixAlphabet == 1)
            {
                alphabet = miniscules;
            }
            else if (choixAlphabet == 2)
            {
                alphabet = miniscules + majuscules;
            }
            else if (choixAlphabet == 3)
            {
                alphabet = miniscules + majuscules + chiffres;
            }
            else if (choixAlphabet == 4)
            {
                alphabet = miniscules + majuscules + chiffres + caracteresSpeciaux;
            }



            int longueurAlphabet = alphabet.Length;


            for (int j = 0; j < NB_MOT_DE_PASSE; j++)
            {
                motDePasse = "";
                for (int i = 0; i < longueurMotDePasse; i++)
                {
                    int index = rand.Next(0, longueurAlphabet);
                    motDePasse += alphabet[index];

                }
                Console.WriteLine($"Mot de passe : {motDePasse}");

            }


            //Console.WriteLine(alphabet[index]);



        }
    }
}