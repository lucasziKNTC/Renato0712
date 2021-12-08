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

        public IActionResult Index(int CodMotorista, int CodPassageiro, string EstadoID, string Cidade, string avaliacao)
        {
            var objeto = new Corrida();
            objeto.CodMotorista = CodMotorista;
            objeto.CodPassageiro = CodPassageiro;
            objeto.EstadoID = EstadoID;
            objeto.Cidade = Cidade;
            objeto.Avaliacao = avaliacao;
            return View(objeto);
        }

        [HttpGet]
        public IActionResult Adicionar()
        {
            return View();
        }

        public IActionResult AdicionarConfirmacao(Corrida corrida)
        {
            var db = new Contexto();

            var obj = db.Corrida.FirstOrDefault(f => f.CodMotorista == corrida.CodMotorista);

            if (obj == null)
            {
                db.Corrida.Add(corrida);
            }
            else
            {
                obj.CodMotorista = corrida.CodMotorista;
                db.Corrida.Update(obj);
            }

            db.SaveChanges();

            return RedirectToAction("Listar");
        }

        [HttpGet]
        public IActionResult Editar(string uf)
        {
            var db = new Contexto();
            var estado = db.Estado.First(item => item.UF == uf);
            return View("Adicionar", estado);
        }

        public IActionResult Listar()
        {

            //SELECT * FROM Estado
            var listaDeEstados = new Contexto().Estado.ToList();

            return View(listaDeEstados);
        }

        public IActionResult Excluir(string uf)
        {
            var db = new Contexto();
            var estado = db.Estado.First(f => f.UF == uf);
            db.Estado.Remove(estado);
            db.SaveChanges();

            return RedirectToAction("Listar");
        }
    }
}
