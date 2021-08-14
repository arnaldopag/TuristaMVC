using Microsoft.AspNetCore.Mvc;
using atividade_II.Models;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;

namespace atividade_II.Controllers
{
    public class UsuarioController : Controller
    {
        public IActionResult Cadastro()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Cadastro(Usuario user)
        {
            UsuarioRepository cadastroUsuario = new UsuarioRepository();

            cadastroUsuario.inserir(user);

            ViewBag.Mensagem = "Cadastro Realizado com sucesso!!!";
            return View();
        }
    }
}