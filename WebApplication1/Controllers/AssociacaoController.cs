using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class AssociacaoController : Controller
    {
        private ApplicationDbContext _context;
        public AssociacaoController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        //static List<TipoDeAssociacao> listaAssociacao = new List<TipoDeAssociacao>()
        //{
        //    new TipoDeAssociacao{id = 1,nome = "Normal",mensalidade = 150,periodo = 1},
        //    new TipoDeAssociacao{id = 1,nome = "Premium",mensalidade = 300,periodo = 2},
        //    new TipoDeAssociacao{id = 1,nome = "Ultra Mega Super",mensalidade = 400,periodo = 3},
        //};
        public ActionResult Index()
        {
            var associacaoIndexView = new TiposDeAssoList()
            {
                TipoAssos = _context.Associacoes.ToList()
            };
            return View(associacaoIndexView);
        }

        public ActionResult DetalhesAssos(int id)
        {

            if (id > _context.Associacoes.Count()) return HttpNotFound();
            TipoDeAssociacao associacaoDetalhes = _context.Associacoes.Find(id);

            return View(associacaoDetalhes);
        }
    }
}
