

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace firstStore.UI.Models
{
    [Table("Usuario")]
    public  class Usuario:Entity
    {
        [Column(TypeName = "varchar(100)")]
        [Required(ErrorMessage = "Campo obrigatório")]
        public string Nome { get; set; }

        [Column(TypeName = "varchar(100)")]
        [Required(ErrorMessage = "Campo obrigatório")]
        public string Email { get; set; }

        [Column(TypeName = "varchar(100)")]
        [Required(ErrorMessage = "Campo obrigatório")]
        public string Senha { get; set; }

    }
}
