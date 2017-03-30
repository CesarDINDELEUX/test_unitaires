using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionCommande.model
{
    public class Commande
    {
        [Key]
        public int Id { get; set; }
        public ICollection<LigneCommande> LignesCommande { get; set; }

        public Client Client { get; set; }
    }
}
