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
        public ActionResult Logar(UsuarioModel usuario)
        {
            if (string.IsNullOrEmpty(usuario.SenhaUsuario) || string.IsNullOrEmpty(usuario.NomeUsuario))
            {
                ViewBag.Error = "Usuario ou senha devem se preenchidos.";
                return View("Index");
            }
            else
            {
                string validacao = User.ValidaUsuario(usuario.NomeUsuario, usuario.SenhaUsuario);
                if (validacao == "True")
                {
                    HttpContext.Session.SetString("SessionUser", usuario.NomeUsuario);
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