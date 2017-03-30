using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionCommande.model
{
    public class LigneCommande
    {
        [Key,Column(Order =1)]
        public int ProduitRefId { get; set; }
        [Key, Column(Order = 2)]
        public int CommandeRefId { get; set; }
        
        [ForeignKey("ProduitRefId")]
        public virtual Produit Produit { get; set; }

        [ForeignKey("CommandeRefId")]
        public virtual Commande Commande { get; set; }
        public int Quantite { get; set; }
    }
}
