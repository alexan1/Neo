using System;
using System.Collections.Generic;
using System.Text;

namespace MenuLib
{
    public class Menu
    {
        public Menu()
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
        }
        public ICollection<Product> ProductMenu { get; set; }
        public IDictionary<int, string> ActionMenu { get; set; }

        public void Afficher()
        {

        }
        public void Ajouter()
        {

        }
        public void Payer()
        {

        }
        public void Supprimer()
        {

        }
        public void Quitter()
        {

        }
        public void Solde()
        {

        }
        public void Aide()
        {

        }
        public void Facture()
        {

        }
    }
}
