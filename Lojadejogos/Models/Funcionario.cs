using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Lojadejogos.Models
{
    public class Funcionario
    {
        [Display(Name = "Código")]
        [Required(ErrorMessage = "O código é obrigatório")]
        public string Codigo { get; set; }

        [Required(ErrorMessage = "O nome é obrigatório")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O CPF é obrigatório")]
        public string CPF { get; set; }

        [Required(ErrorMessage = "O RG é obrigatório")]
        public string RG { get; set; }

        [Display(Name = "Data Nascimento")]
        [Required(ErrorMessage = "A data de nascimento é obrigatório")]

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DataNasc
        {
            get { return this.dataNasc.HasValue ? this.dataNasc.Value : DateTime.Now; }
            set { this.dataNasc = value; }
        }
        private DateTime? dataNasc = null;

        [Display(Name = "Endereço")]
        [Required(ErrorMessage = "O endereço é obrigatório")]
        public string Endereco { get; set; }

        [Required(ErrorMessage = "O celular é obrigatório")]
        public string Celular { get; set; }

        [Required(ErrorMessage = "O email é obrigatório")]
        public string Email { get; set; }

        [Required(ErrorMessage = "O cargo é obrigatório")]
        public string Cargo { get; set; }

    }
}
