using MenuLib;
using System;

namespace Neo1
{
    class Program
    {
        static void Main(string[] args)
        {
            var menu = new Menu();

            Console.WriteLine("Bienvenue au restaurant Belle bouchée\n");
            Console.WriteLine("Veuillez sélectionner une option\n");

            foreach(var item in menu.ActionMenu)
            {
                Console.Write(item.Key);
                Console.Write(". ");
                Console.WriteLine(item.Value);
            }

            var key = Console.ReadLine();

            if (Int32.TryParse(key, out int j))
            { 

                switch (j)
                {
                    case 1:
                        menu.Afficher();
                        break;
                    case 2:
                        menu.Ajouter();
                        break;
                    case 3:
                        menu.Supprimer();
                        break;
                    case 4:
                        menu.Payer();
                        break;
                    case 5:
                        menu.Solde();
                        break;
                    case 6:
                        menu.Ajouter();
                        break;
                    case 7:
                        menu.Aide();
                        break;
                    case 8:
                        menu.Quitter();
                        break;
                    default:
                        Console.WriteLine("No elements to the input");
                        break;
                }
            }


        }
    }
}
