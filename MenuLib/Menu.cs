using System;
using System.Collections.Generic;
using System.Text;

namespace MenuLib
{
    public static class Menu
    {
        static Menu()
        {
            ActionMenu = new Dictionary<int, string>
            {
                {1, "Afficher le menu" },
                {2, "Ajouter un produit à la commande" },
                {3, "Supprimer un produit de la commande" },
                {4, "Payer la facture" },
                {5, "Afficher le solde de la facture" },
                {6, "Afficher l'inventaire de restaurant" },
                {7, "Aide" },
                {8, "Quitter" },
            };

            ProductMenu = new List<Product>
            {
                new Product(1, "Potage inspiration du marché", 5, 5),
                new Product(2, "Salade panachée aux noix de Grenoble", 7, 5),
                new Product(3, "Foie de canard",  15, 2),
                new Product(4, "Huîtres fraîches", 18, 7),
                new Product(5, "Royal chocolat", 5, 8),
                new Product(6, "Crème brûlée", 6, 2),
            };
        }
        public static ICollection<Product> ProductMenu { get; set; }
        public static IDictionary<int, string> ActionMenu { get; set; }

        public static void Afficher()
        {
            foreach (var item in ProductMenu)
            {
                Console.Write(item.Id);
                Console.Write(" ");
                Console.Write(item.Name);
                Console.Write(" $");
                Console.Write(item.Price);
                Console.Write(" ");
                Console.WriteLine(item.MaxQuantity);
            }
        }
        public static void Ajouter()
        {

        }
        public static void Supprimer()
        {

        }
        public static void Payer()
        {

        }
        public static void Solde()
        {

        }        
        public static void Facture()
        {

        }
        public static void Aide()
        {
            foreach (var item in ActionMenu)
            {
                Console.Write(item.Key);
                Console.Write(". ");
                Console.WriteLine(item.Value);                
            }
            Console.WriteLine(" ");
            var basket = new Basket();
            
            var key = Console.ReadKey().KeyChar.ToString();

            if (Int32.TryParse(key, out int j))
            {
                switch (j)
                {
                    case 1:
                        Afficher();
                        break;
                    case 2:
                        basket.AddItem();
                        //Ajouter();
                        break;
                    case 3:
                        Supprimer();
                        break;
                    case 4:
                        Payer();
                        break;
                    case 5:
                        Solde();
                        break;
                    case 6:
                        Ajouter();
                        break;
                    case 7:
                        Aide();
                        break;
                    case 8:
                        Quitter();
                        break;
                    default:
                        Console.WriteLine("No elements to the input");
                        break;
                }
            }

        }
        public static void Quitter()
        {
            Environment.Exit(0);
        }
    }
}
