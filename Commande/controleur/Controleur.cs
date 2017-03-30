using GestionCommande.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionCommande.controleur
{
    public interface Controleur
    {

        void CreerCommande(Client client, ICollection<LigneCommande> ligneCmd);


        ICollection<Client> GetClients();

        ICollection<Produit> GetProduits();

        ICollection<Commande> GetCommandes();
        void CreerClient(string nom, string prenom, string mail);

        void CreerProduit(string designation, int prix);
    }
}
