using GestionCommande.model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionCommande.dao
{
    class ProduitDao
    {
        public ICollection<Produit> Produits { get; }

        public ProduitDao()
        {
            this.Produits = new Collection<Produit>();
            Produit casque = new Produit() { Id = 1, Designation = "Casque", Prix = 15 };
            Produit marteau = new Produit() { Id = 2, Designation = "Marteau", Prix = 50 };
            Produit vodka = new Produit() { Id = 3, Designation = "Vodka", Prix = 10 };

            this.Produits.Add(casque);
            this.Produits.Add(marteau);
            this.Produits.Add(vodka);
        }
    }
}
