using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace firstStore.UI.Models
{
    public class LoginVM
    {
        [Required(ErrorMessage = "Campo obrigatório")]
        [StringLength(100,ErrorMessage ="Tamanho excedido")]
        [RegularExpression(@"([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)",ErrorMessage ="Email inválido")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Campo obrigatório")]
        [StringLength(100, ErrorMessage = "Tamanho excedido")]
        [DataType(DataType.Password)]
        public string Senha { get; set; }
        public bool Lembrar { get; set; }
        public string  ReturnUrl { get; set; }
    }
}
