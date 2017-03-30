using GestionCommande.model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionCommande.dao
{
    class CommandeDao
    {
        public ICollection<Commande> Commandes { get; }

        public CommandeDao()
        {
            this.Commandes = new Collection<Commande>();
        }

        public void AjouterCommande(Commande commande)
        {
            this.Commandes.Add(commande);
        }
    }
}
