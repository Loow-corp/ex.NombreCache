using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NombreCache
{
    class Program
    {
        static void Main(string[] args)
        {
            // déclaration
            int valeur, essai, nbre = 1;

            // saisie du nombre à chercher
            Console.Write("Entrez le nombre à chercher = ");
            valeur = int.Parse(Console.ReadLine());
            Console.Clear();

            // saisie du premier essai
            Console.Write("Entrez un essai = ");
            essai = int.Parse(Console.ReadLine());
            // boucle sur les essais
            while (essai != valeur)
            { 
                // test de l'essai par rapport à la valeur à chercher
                if (essai > valeur)
                {
                    Console.WriteLine("--> trop grand !");
                }
                else
                {
                    Console.WriteLine("--> trop petit !");
                }

                // saisie d'un nouvel essai
                Console.WriteLine("Entrez un essai = ");
                essai = int.Parse(Console.ReadLine());
               
                // compteur d'essai
                nbre++;
            }
           // valeur trouvée
            Console.WriteLine("Vous avez trouvé en "+nbre+" fois !");
            Console.ReadLine();
        }
    }
}