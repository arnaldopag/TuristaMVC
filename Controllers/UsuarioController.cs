using atividade_II.Models;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace atividade_II.Controllers
{
    public class UsuarioController : Controller
    {



        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(Usuario user)
        {

            var ur = new UsuarioRepository();
            var usuarioEncontrado = ur.ValidarLogin(user);

            if (usuarioEncontrado == null)
            {
                ViewBag.Mensagem = "Falha no login";
                return View();
            }
            else
            {

                //iremos gravar na sessao - nossas credenciais
                HttpContext.Session.SetInt32("IdUsuario", usuarioEncontrado.Id);
                HttpContext.Session.SetString("NomeUsuario", usuarioEncontrado.Nome);

                return RedirectToAction("Lista", "Usuario"); //action,controller
            }

        }

        public IActionResult Logout()
        {
          
            HttpContext.Session.Clear();
            return View("Login");
        }

        public IActionResult Editar(int Id)
        {

            if (HttpContext.Session.GetInt32("IdUsuario") == null)
            {
                return RedirectToAction("Login", "Usuario");
            }

            var ur = new UsuarioRepository();
            var userLocalizado = ur.BuscarPorId(Id);
            return View(userLocalizado);
        }

        [HttpPost]
        public IActionResult Editar(Usuario user)
        {

            var ur = new UsuarioRepository();
            ur.Alterar(user);
            return RedirectToAction("Lista", "Usuario");
        }

        public IActionResult Remover(int Id)
        {

            if (HttpContext.Session.GetInt32("IdUsuario") == null)
            {
                return RedirectToAction("Login", "Usuario");
            }

            var ur = new UsuarioRepository();
            var userLocalizado = ur.BuscarPorId(Id);
            ur.Excluir(userLocalizado);
            return RedirectToAction("Lista", "Usuario");

        }


        public IActionResult Lista()
        {

            if (HttpContext.Session.GetInt32("IdUsuario") == null)
            {
                return RedirectToAction("Login", "Usuario");
            }

            var ur = new UsuarioRepository();
            var listaDeUsuarios = ur.Listar();
            return View(listaDeUsuarios);
        }


        public IActionResult Cadastro()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastro(Usuario user)
        {

            var ur = new UsuarioRepository();
            ur.Inserir(user);
            ViewBag.Mensagem = "Cadastro realizado com sucesso!";
            return View();
        }

    }
}