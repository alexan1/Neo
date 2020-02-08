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

            menu.Aide();


        }
    }
}
