using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class TipoDeAssociacao
    {
        public int id { get; set; }
        public string nome { get; set; }
        public int periodo { get; set; }
        public int mensalidade { get; set; }
    }
}