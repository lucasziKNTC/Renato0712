using Microsoft.AspNetCore.Mvc;
using PROJETO01.Dados.EntityFramework;
using PROJETO01.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PROJETO01.Controllers
{
    public class CorridaController : Controller
    {


        [HttpGet]
        public IActionResult Adicionar()
        {
            return View();
        }

        public IActionResult AdicionarConfirmacao(Corrida corrida)
        {
            var db = new Contexto();

            var obj = db.Corrida.FirstOrDefault(f => f.IdSolicitacao == corrida.IdSolicitacao);

            if (obj == null)
            {
                db.Corrida.Add(corrida);
            }
            else
            {
                obj.MotoristaId = corrida.MotoristaId;
                obj.PessoaId = corrida.PessoaId;
                obj.Avaliacao = corrida.Avaliacao;
                obj.IdSolicitacao = corrida.IdSolicitacao;
                obj.MotoristaId = corrida.IdSolicitacao;
                db.Corrida.Update(obj);
            }

            db.SaveChanges();

            return RedirectToAction("Listar");
        }

        [HttpGet]
        public IActionResult Editar(int IdSolicitação)
        {
            var db = new Contexto();
            var corrida = db.Corrida.First(item => item.IdSolicitacao == IdSolicitação);
            return View("Adicionar", corrida);
        }

        public IActionResult Listar()
        {

            //SELECT * FROM Estado
            var listaDeSolicitação = new Contexto().Corrida.ToList();

            return View(listaDeSolicitação);
        }

        public IActionResult Excluir(int IdSolicitação)
        {
            var db = new Contexto();
            var Corrida = db.Corrida.First(f => f.IdSolicitacao == IdSolicitação);
            db.Corrida.Remove(Corrida);
            db.SaveChanges();

            return RedirectToAction("Listar");
        }
    }
}
