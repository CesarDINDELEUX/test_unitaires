using GestionCommande.controleur;
using GestionCommande.dao;
using GestionCommande.model;
using GestionCommande.vue;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionCommande
{
    class ClassMain
    {
        static void Main(string[] args)
        {
            Controleur controleur = new CommandeControleur();
            MainVue vue = new MainVue(controleur);

            ICollection<Client> Clients = new Collection<Client>();
            vue.start();
        }
    }
}
