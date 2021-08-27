using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Lojadejogos.Models
{
    public class Jogo
    {
        [Display(Name = "Código")]
        [Required(ErrorMessage = "O código é obrigatório")]
        public string Codigo { get; set; }

        [Required(ErrorMessage = "O nome é obrigatório")]
        public string Nome { get; set; }

        [Display(Name = "Versão")]
        [Required(ErrorMessage = "A versão é obrigatório")]
        public string Versao { get; set; }

        [Required(ErrorMessage = "O desenvolvedor é obrigatório")]
        public string Desenvolvedor { get; set; }

        [Required(ErrorMessage = "O gênero é obrigatório")]
        [Display(Name = "Gênero")]
        public string Genero { get; set; }

        [Required(ErrorMessage = "A faixa etária é obrigatório")]
        [Display(Name = "Faixa Etária")]

        public string FaixaEtaria { get; set; }

        [Required(ErrorMessage = "A plataforma é obrigatório")]
        public string Plataforma { get; set; }

        [Required(ErrorMessage = "O ano de lançamento é obrigatório")]
        [Display(Name = "Ano de Lançamento")]
        public string AnoLanc { get; set; }

        [Required(ErrorMessage = "A sinopse é obrigatório")]
        public string Sinopse { get; set; }
    }
}