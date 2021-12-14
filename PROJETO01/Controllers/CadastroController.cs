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

            var obj = db.Cadastro.FirstOrDefault(f => f.PessoaId == cadastro.PessoaId);

            if (obj == null)
            {
                db.Cadastro.Add(cadastro);
            }
            else
            {
                obj.Nome = cadastro.Nome;
                obj.PessoaId = cadastro.PessoaId;
                obj.Endereço = cadastro.Endereço;
                obj.Cpf = cadastro.Cpf;
                obj.Cep = cadastro.Cep;
                obj.Numero = cadastro.Numero;
                obj.Bairro = cadastro.Nome;
                obj.Complemento = cadastro.Complemento;
                db.Cadastro.Update(obj);
            }

            db.SaveChanges();

            return RedirectToAction("Listar");
        }

        [HttpGet]
        public IActionResult Editar(int PessoaId)
        {
            var db = new Contexto();
            var estado = db.Cadastro.First(item => item.PessoaId == PessoaId);
            return View("Adicionar", estado);
        }

        public IActionResult Listar()
        {

            //SELECT * FROM Estado
            var listaDeCadastro = new Contexto().Cadastro.ToList();

            return View(listaDeCadastro);
        }

        public IActionResult Excluir(int PessoaId)
        {
            var db = new Contexto();
            var Cadastro = db.Cadastro.First(f => f.PessoaId == PessoaId);
            db.Cadastro.Remove(Cadastro);
            db.SaveChanges();

            return RedirectToAction("Listar");
        }
    }
}

