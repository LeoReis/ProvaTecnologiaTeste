using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class FaixaController : Controller
    {
        private ApplicationDbContext _context;
        public FaixaController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        //static List<Faixa> listaFaixa = new List<Faixa>()
        //{
        //    new Faixa{id = 1,nome = "branca",grau = "1"},
        //    new Faixa{id = 2,nome = "azul",grau = "2"},
        //    new Faixa{id = 3,nome = "verde",grau = "3"},
        //    new Faixa{id = 4,nome = "laranja",grau = "4"},
        //    new Faixa{id = 5,nome = "preta",grau = "5"},
        //};
        public ActionResult Index()
        {
            var faixaIndexView = new FaixaList()
            {
                Faixas = _context.Faixas.ToList()
            };
            return View(faixaIndexView);
        }

        public ActionResult DetalhesFaixa(int id)
        {

            if (id > _context.Faixas.Count()) return HttpNotFound();
            Faixa faixaDetalhes = _context.Faixas.Find(id);

            return View(faixaDetalhes);
        }
    }
}