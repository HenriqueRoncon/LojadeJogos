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
        [RegularExpression(@"([0-9]{3}.[0-9]{3}.[0-9]{3}/[0-9]{2})|([0-9]{11})", ErrorMessage = "Insira um formato de CPF válido. Ex: 000.000.000/00")]

        public string CPF { get; set; }


        [Display(Name = "Data Nascimento")]
        [Required(ErrorMessage = "A data de nascimento é obrigatória.")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DataNasc
        {
            get { return this.dataNasc.HasValue ? this.dataNasc.Value : DateTime.Now; }
            set { this.dataNasc = value; }
        }
        private DateTime? dataNasc = null;

        [Required(ErrorMessage = "O email é obrigatório")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Digite um e-mail válido")]
        public string Email { get; set; }

        [Required(ErrorMessage = "O número do celular é obrigatório")]
        [RegularExpression(@"^\(?\d{2}\)?[\s-]?[\s9]?\d{4}-?\d{4}$",
            ErrorMessage = "Insira um formato de número válido. Ex (00) 00000-0000")]
        public string Celular { get; set; }
        [Display(Name = "Endereço")]

        [Required(ErrorMessage = "O endereço é obrigatório")]
        public string Endereco { get; set; }
    }
}