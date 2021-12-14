using Microsoft.AspNetCore.Mvc;
using PROJETO01.Dados.EntityFramework;
using PROJETO01.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PROJETO01.Controllers
{
    public class MotoristaController : Controller
    {


        [HttpGet]
        public IActionResult Adicionar()
        {
            return View();
        }

        public IActionResult AdicionarConfirmacao(Motorista motorista)
        {
            var db = new Contexto();

            var obj = db.Motorista.FirstOrDefault(f => f.MotoristaId == motorista.MotoristaId);

            if (obj == null)
            {
                db.Motorista.Add(motorista);
            }
            else
            {
                obj.MotoristaId = motorista.MotoristaId;
                obj.Nome = motorista.Nome;
                obj.CidadeId = motorista.CidadeId;
                obj.Sexo = motorista.Sexo;
                obj.Telefone = motorista.Telefone;


                db.Motorista.Update(obj);
            }

            db.SaveChanges();

            return RedirectToAction("Listar");
        }

        [HttpGet]
        public IActionResult Editar(int MotoristaId)
        {
            var db = new Contexto();
            var motorista = db.Motorista.First(item => item.MotoristaId == MotoristaId);
            return View("Adicionar", motorista);
        }

        public IActionResult Listar()
        {

            //SELECT * FROM Estado
            var listaDeMotorista = new Contexto().Motorista.ToList();

            return View(listaDeMotorista);
        }

        public IActionResult Excluir(int MotoristaId)
        {
            var db = new Contexto();
            var Motorista = db.Motorista.First(f => f.MotoristaId == MotoristaId);
            db.Motorista.Remove(Motorista);
            db.SaveChanges();

            return RedirectToAction("Listar");
        }
    }
}

