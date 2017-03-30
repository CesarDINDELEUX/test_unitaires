using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionCommande.model
{
    public class Produit
    {
        [Key]
        public int Id { get; set; }
        public string Designation { get; set; }
        public int Prix { get; set; }

    }
}
