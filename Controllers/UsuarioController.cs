using Microsoft.AspNetCore.Mvc;

namespace atividade_II.Controllers
{
    public class UsuarioController : Controller
    {
        public IActionResult Cadastro()
        {
            return View();
        }
    }
}