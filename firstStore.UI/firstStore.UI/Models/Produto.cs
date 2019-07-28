using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace firstStore.UI.Models
{
    [Table(nameof(Produto))]
    public class Produto:Entity
    {
        [Column(TypeName = "varchar(100)")]
        [Required]
        public string Nome { get; set; }

        public int TipoProdutoId { get; set; }

        [ForeignKey(nameof(TipoProdutoId))]
        public TipoProduto Tipo { get; set; }

        [Column(TypeName = "money")]
        public decimal Valor { get; set; }


    }
}
