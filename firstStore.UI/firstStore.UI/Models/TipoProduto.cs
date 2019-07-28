using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace firstStore.UI.Models
{
    [Table(nameof(TipoProduto))]
    public class TipoProduto : Entity
    {
        [Column(TypeName = "varchar(100)")]
        [Required]
        public string Nome { get; set; }

        public List<Produto> Produtos { get; set; } = new List<Produto>();
    }
}
