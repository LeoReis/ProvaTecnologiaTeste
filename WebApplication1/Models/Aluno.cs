using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Aluno
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string cpf { get; set; }
        public Faixa faixa { get; set; }
        public TipoDeAssociacao tipo { get; set; }
    }
}