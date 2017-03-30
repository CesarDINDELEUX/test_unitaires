using GestionCommande.model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionCommande.dao
{
    public class ClientDao
    {
        public ICollection<Client> Clients { get; set; }

        public ClientDao()
        {
            this.Clients = new Collection<Client>();
            this.Clients.Add(new Client() { Id = 1, Nom = "Banner", Prenom = "Bruce", Mail = "hulk@gmail.com", Commandes = new Collection<Commande>() });
            this.Clients.Add(new Client() { Id = 2, Nom = "Stark", Prenom = "Tony", Mail = "tony.stark@gmail.com", Commandes = new Collection<Commande>() });
            this.Clients.Add(new Client() { Id = 3, Nom = "", Prenom = "Thor", Mail = "thor@gmail.com", Commandes = new Collection<Commande>() });      
        }

    }
}
