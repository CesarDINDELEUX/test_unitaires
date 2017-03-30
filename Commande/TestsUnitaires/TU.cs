using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionCommande.controleur;
using GestionCommande.model;
using GestionCommande.dao;
using GestionCommande.vue;
using System.Collections.ObjectModel;

namespace GestionCommande.TestsUnitaires
{
    [TestClass]
    public class TU

    {
        /// <summary>
        /// Test de la fonction CreerClient
        /// </summary>
        [TestMethod]
        public void CreerClientOK() 
        {
            Controleur controller = new CommandeControleur();
            ClientDao client = new ClientDao();
            int un = client.Clients.Count();
            controller.CreerClient("DINDELEUX", "César", "cesar.dindeleux@gmail.com");
            Assert.AreEqual(controller.GetClients().Last().Id, un + 1); // Vérifier que l'ID est bien augmenté de 1.
            Assert.AreEqual(controller.GetClients().Last().Nom, "DINDELEUX"); // Vérifier que le nom est bien inséré et correct
            Assert.AreEqual(controller.GetClients().Last().Prenom, "César"); // Vérifier que le prénom est bien inséré et correct
            Assert.AreEqual(controller.GetClients().Last().Mail, "cesar.dindeleux@gmail.com"); // Vérifier que le mail est bien inséré et correct
            Assert.AreEqual(controller.GetClients().Last().Commandes.Count(), 0); // Vérifier qu'à la création, ses commandes soient bien vides.
        }

        /// <summary>
        /// Test de la fonction CreerProduit
        /// </summary>
        [TestMethod]
        public void CreerProduitOK()
        {
            Controleur controller = new CommandeControleur();
            ProduitDao produit  = new ProduitDao();
            int un = produit.Produits.Count();
            controller.CreerProduit("Nintendo Switch", 299);
            Assert.AreEqual(controller.GetProduits().Last().Id, un + 1); // Vérifier que l'ID est bien augmenté de 1.
            Assert.AreEqual(controller.GetProduits().Last().Designation, "Nintendo Switch"); // Vérifier que la désignation est bien insérée et correcte
            Assert.AreEqual(controller.GetProduits().Last().Prix, 299); // Vérifier que le prix est bien inséré et correct
        }


        /// <summary>
        /// Test de la fonction CreerCommande
        /// </summary>
        [TestMethod]
        public void CreerCommandeOK()
        {
            Controleur controller = new CommandeControleur();
            Client c1 = controller.GetClients().Last();
            Produit produit = controller.GetProduits().Last();
            LigneCommande ligneCMD = new LigneCommande() { Produit = controller.GetProduits().Last(), Quantite = 17 };
            ICollection<LigneCommande> CommandeComplete = new Collection<LigneCommande>();
            CommandeComplete.Add(ligneCMD);

            //AJOUTER LE TEST DE LA COMMANDE.


            controller.CreerCommande(c1, CommandeComplete);
            Assert.AreEqual(controller.GetCommandes().Last().Client, c1); // Vérifier que la commande prend bien en compte un client
            Assert.AreEqual(controller.GetCommandes().Last().LignesCommande, CommandeComplete); // Vérifier que la commande prend bien en compte la collection de ligne de cmd.
         }

    }
}
