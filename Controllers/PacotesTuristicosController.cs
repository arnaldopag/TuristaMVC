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
            //desenvolver o corpo do metodo
            return View();
        }

        [HttpPost]
        public IActionResult Editar(PacotesTuristicos pac)
        {
            //desenvolver o corpo do metodo
            return View();
        }

        public IActionResult Remover(int Id)
        {
            //desenvolver o corpo do metodo
            return View();
        }

        public IActionResult Lista()
        {
            //desenvolver o corpo do metodo
            return View();
        }

        public IActionResult Cadastro()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastro(PacotesTuristicos pac)
        {
            //desenvolver o corpo do metodo
            return View();
        }


    }
}