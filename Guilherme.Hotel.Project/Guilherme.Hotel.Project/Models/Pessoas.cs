using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Guilherme.Hotel.Project.Models {


    public class Pessoas {

        [Required(ErrorMessage = "O Código é obrigatório")]
        public int Id { get; set; }
        [Required(ErrorMessage = "O Nome é obrigatório")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "O Sobrenome é obrigatório")]
        public string Sobrenome { get; set; }
        [Required(ErrorMessage = "O CPF é obrigatório")]
        public string Cpf { get; set; }
        [Required(ErrorMessage = "O RG é obrigatório")]
        public string Rg { get; set; }
        [Required(ErrorMessage = "O Data de Nascimento é obrigatório")]
        public DateTime Nascismento { get; set; }
        [Required(ErrorMessage = "O Sexo é obrigatório")]
        public bool Sexo { get; set; }
        public string Email { get; set; }

    }




}