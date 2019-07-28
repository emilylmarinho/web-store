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
        [Required(ErrorMessage ="Campo obrigatório")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        public int TipoProdutoId { get; set; }

        [ForeignKey(nameof(TipoProdutoId))]
        public TipoProduto Tipo { get; set; }

        [Column(TypeName = "money")]
        [Required(ErrorMessage = "Campo obrigatório")]
        public decimal Valor { get; set; }

        [Column(TypeName = "varchar(300)")]
        [StringLength(300,ErrorMessage = "Limite de caracteres excedido")]
        public string Descricao { get; set; }


    }
}
