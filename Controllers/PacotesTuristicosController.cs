using atividade_II.Models;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace atividade_II.Controllers
{
    public class PacotesTuristicosController : Controller
    {

        public IActionResult Editar(int Id)
        {
            PacotesTuristicosRepository pt = new PacotesTuristicosRepository();
            PacotesTuristicos ptLocalizado = pt.BuscarPorId(Id);
            return View(ptLocalizado);

        }

        [HttpPost]
        public IActionResult Editar(PacotesTuristicos pac)
        {

            PacotesTuristicosRepository pt = new PacotesTuristicosRepository();
            pt.Alterar(pac);
            return RedirectToAction("Lista", "PacotesTuristicos");

        }

        public IActionResult Remover(int Id)
        {
            PacotesTuristicosRepository pt = new PacotesTuristicosRepository();
            PacotesTuristicos PacoteLocalizado = pt.BuscarPorId(Id);
            pt.Excluir(PacoteLocalizado);
            return RedirectToAction("Lista", "PacotesTuristicos");

        }

        public IActionResult Lista()
        {
            PacotesTuristicosRepository pt = new PacotesTuristicosRepository();
            List<PacotesTuristicos> listaDePacotes = pt.Listar();
            return View(listaDePacotes);
        }

        public IActionResult Cadastro()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastro(PacotesTuristicos pac)
        {
            PacotesTuristicosRepository pt = new PacotesTuristicosRepository();
            pt.Inserir(pac);
            ViewBag.Mensagem = "Cadastro realizado com sucesso!";
            return View();
        }

    }


}
