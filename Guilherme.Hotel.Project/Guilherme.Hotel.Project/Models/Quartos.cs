using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Guilherme.Hotel.Project.Models {

    public class Quartos {

        public int Id { get; set; }
        public string Tipo { get; set; }
        public double Tamanho {get; set; }
        public int Capacidade { get; set; }
        public double Preco{ get; set; }
        public bool VistaPraia { get; set; }
        public int Andar { get; set; }
        public bool Disponivel { get; set; }


    }
}