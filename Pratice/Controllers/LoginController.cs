using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Pratice.Models;
using System.Web;
using Microsoft.AspNetCore.Session;
using Microsoft.AspNetCore.Http;

namespace Pratice.Controllers
{
    public class LoginController : Controller
    {

        UsuarioModel User = new UsuarioModel();

        public IActionResult Index()
        {   
            var userInfo = HttpContext.Session.GetString("SessionUser");

            if (!string.IsNullOrEmpty(userInfo))
            {
                ViewBag.Error = "Você ja esta logado no sistema";
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return View();
            }
        }

        [HttpPost]
        public ActionResult Logar(string email, string senha)
        {
            if (string.IsNullOrEmpty(senha) || string.IsNullOrEmpty(email))
            {
                ViewBag.Error = "Usuario ou senha devem se preenchidos.";
                return View("Index");
            }
            else
            {
                string validacao = User.ValidaUsuario(email, senha);
                if (validacao == "True")
                {
                    string nome = User.RetornaDadosUsuario(email, senha).NomeUsuario;
                    HttpContext.Session.SetString("SessionUser", nome);
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ViewBag.Error = validacao;
                    return View("Index");
                }
            }
            
        }
        [HttpPost]
        public ActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Login");

        }

      
    }
}