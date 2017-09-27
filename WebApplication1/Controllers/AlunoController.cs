using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class AlunoController : Controller
    {
        private ApplicationDbContext _context;
        public AlunoController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        //static List<Aluno> listaAluno = new List<Aluno>()
        //{
        //    new Aluno{id = 1,nome = "Pedro1",cpf = "784561238465"},
        //    new Aluno{id = 2,nome = "Pedro2",cpf = "784561238465"},
        //    new Aluno{id = 3,nome = "Pedro3",cpf = "784561238465"},
        //    new Aluno{id = 4,nome = "Pedro4",cpf = "784561238465"},
        //    new Aluno{id = 5,nome = "Pedro5",cpf = "784561238465"},
        //};
        public ActionResult Index()
        {
            var alunoIndexView = new AlunoList()
            {
                Alunos = _context.Alunos.ToList()
            };
            return View(alunoIndexView);
        }

        public ActionResult DetalhesAlunos(int id)
        {

            if (id > _context.Alunos.Count()) return HttpNotFound();
            Aluno alunoDetalhe = _context.Alunos.Find(id);

            return View(alunoDetalhe);
        }
    }
}