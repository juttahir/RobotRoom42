using Domain.Interfaces.Repositories;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    public class LoginController : Controller
    {
        private readonly IUsuarioRepository _usuarioService;

        public LoginController(IUsuarioRepository usuarioService)
        {
            _usuarioService = usuarioService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Cadastro()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ObterUsuario(string email, string senha)
        {
            try
            {
                var user = _usuarioService.ObterUsuario(email, senha);
                if(user == null)
                {
                    ViewBag.ShowError = true;
                    return View("Index");
                }

                return RedirectToAction("Index", "Home");
            }
            catch(Exception ex)
            {
                return View("Index", ex);
            }
        }

        [HttpPost]
        public IActionResult SalvaUsuario(UsuarioModel usuario)
        {
            try
            {
                _usuarioService.SalvarUsuario(usuario);
                ViewBag.Sucesso = true;
                return View("Index");
            }
            catch (Exception ex)
            {
                return View("Cadastro", ex);
            }
        }
    }
}
