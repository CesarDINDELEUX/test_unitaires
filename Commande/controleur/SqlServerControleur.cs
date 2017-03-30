using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionCommande.model;
using GestionCommande.dao;

namespace GestionCommande.controleur
{
    public class SqlServerControleur : Controleur
    {
        private GestionCommandeContext ctx;
        public SqlServerControleur()
        {
            ctx = new GestionCommandeContext();
        }
        public void CreerCommande(Client client, ICollection<LigneCommande> ligneCmd)
        {
            Commande cmd = new Commande { Id = ctx.Commandes.Count() + 1, Client = client, LignesCommande = ligneCmd };
            foreach (LigneCommande ligne in ligneCmd)
            {
                ligne.Commande = cmd;
            }
            client.Commandes.Add(cmd);
            ctx.Commandes.Add(cmd);
            ctx.Entry(client).State = System.Data.Entity.EntityState.Modified;
            ctx.SaveChanges();
        }

        public void CreerClient(string prenom, string nom, string mail)
        {
            Client NouveauClient = new Client { Id = ctx.Clients.Count() + 1, Prenom = prenom, Nom = nom, Mail = mail };
            ctx.Clients.Add(NouveauClient);
            ctx.SaveChanges();
        }

        public void CreerProduit(string designation, int prix)
        {
            Produit NouveauProduit = new Produit { Id = ctx.Produits.Count() + 1, Designation = designation, Prix = prix};
            ctx.Produits.Add(NouveauProduit);
            ctx.SaveChanges();
        }

        public ICollection<Client> GetClients()
        {
            return ctx.Clients.ToList();
        }

        public ICollection<Commande> GetCommandes()
        {
            return ctx.Commandes.ToList();
        }

        public ICollection<Produit> GetProduits()
        {
            return ctx.Produits.ToList();
        }



    }
}
