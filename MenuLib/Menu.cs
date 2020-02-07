using System;
using System.Collections.Generic;
using System.Text;

namespace MenuLib
{
    public class Menu
    {
        public Menu()
        {
            ActionMenu = new List<string>
            {
                "Supprimer", "Quitter", "Solde", "Aide", "Facture",
            };
        }
        public ICollection<Product> ProductMenu { get; set; }
        public ICollection<string> ActionMenu { get; set; }
    }
}
