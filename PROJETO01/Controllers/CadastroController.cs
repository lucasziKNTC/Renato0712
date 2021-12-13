using Microsoft.AspNetCore.Mvc;
using PROJETO01.Dados.EntityFramework;
using PROJETO01.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PROJETO01.Controllers
{
    public class CadastroController : Controller
    {
 
 
            [HttpGet]
            public IActionResult Adicionar()
            {
                return View();
            }

            public IActionResult AdicionarConfirmacao(Cadastro cadastro)
            {
                var db = new Contexto();

                var obj = db.Cadastro.FirstOrDefault(f => f.Nome == cadastro.Nome);

                if (obj == null)
                {
                    db.Cadastro.Add(cadastro);
                }
                else
                {
                    obj: = cadastro.Nome;
                    db.Cadastro.Update(obj);
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

