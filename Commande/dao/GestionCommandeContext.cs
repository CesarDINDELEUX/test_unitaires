using GestionCommande.model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionCommande.dao
{
    public class GestionCommandeContext:DbContext
    {
        public DbSet<Produit> Produits { get; set; }
        public DbSet<Client> Clients{ get; set; }
        public DbSet<Commande> Commandes { get; set; }
    }
}
