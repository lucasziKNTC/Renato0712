using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PROJETO01.Dados.EntityFramework;
using PROJETO01.Modelos;

namespace PROJETO01.Controllers
{
    public class CidadeController : Controller
    {
        public IActionResult Adicionar()
        {
            var db = new Contexto();
            ViewBag.Estados = db.Estado.ToList();
            return View();
        }

        [HttpPost]
        public IActionResult AdicionarConfirmacao(Cidade cidade)
        {

            var db = new Contexto();

            var obj = db.Cidade.FirstOrDefault(f => f.CidadeID == cidade.CidadeID);

            if (obj == null)
            {
                db.Cidade.Add(cidade);
            }
            else
            {
                obj.UF = cidade.UF;
                obj.Nome = cidade.Nome;
                db.Cidade.Update(obj);
            }

            db.SaveChanges();

            return RedirectToAction("Listar");

        }
        public IActionResult Listar()
        {

            //SELECT * FROM Estado
            var listaDeEstados = new Contexto().Cidade.ToList();

            return View(listaDeEstados);
        }


        [HttpGet]
        public IActionResult Editar(int CidadeId)
        {
            var db = new Contexto();
            var cidade = db.Cidade.FirstOrDefault(item => item.CidadeID == CidadeId);
            return View("Adicionar", cidade);
        }

        public IActionResult Excluir(int CidadeId)
        {
            var db = new Contexto();
            var cidade = db.Cidade.First(f => f.CidadeID == CidadeId);
            db.Cidade.Remove(cidade);
            db.SaveChanges();

            return RedirectToAction("Listar");
        }
    }
}