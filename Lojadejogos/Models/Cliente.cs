using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace Lojadejogos.Models
{
    public class Cliente
    {
        [Required(ErrorMessage = "O nome é obrigatório")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O CPF é obrigatório")]
        public string CPF { get; set; }

        [Display(Name = "Data Nascimento")]
        public string DataNasc { get; set; }

        [Required(ErrorMessage = "O email é obrigatório")]
        public string Email { get; set; }

        [Required(ErrorMessage = "O número do celular é obrigatório")]
        public string Celular { get; set; }
        [Display(Name = "Endereço")]

        [Required(ErrorMessage = "O endereço é obrigatório")]
        public string Endereco { get; set; }
    }
}