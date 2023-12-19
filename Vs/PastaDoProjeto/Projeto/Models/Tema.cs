using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projeto.Models
{
    public class Tema
    {
        public long TemaId { get; set; }
        public string Nome { get; set; }
        public string Cor { get; set; }
        public double ValorAluguel { get; set; }
    }
}