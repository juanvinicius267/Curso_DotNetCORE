using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using WebBlog.dao;
using WebBlog.Models;

namespace WebBlog.Controllers
{
    public class UsuarioController : Controller
    {
        private UsuarioDAO dao;

        public UsuarioController(UsuarioDAO usuarioDAO)
        {
            this.dao = usuarioDAO;
        }
        public IActionResult Login()
        {
            return View(new LoginViewModel());
        }
        [HttpPost]
        public IActionResult Autentica(LoginViewModel lvm)
        {
            if (ModelState.IsValid)
            {


                Usuario doBanco = this.dao.BuscaUsuario(lvm.Login, lvm.Senha);
                if (doBanco != null)
                {
                    HttpContext.Session.SetString("usuario", JsonConvert.SerializeObject(doBanco));
                    return RedirectToAction("Index", "Post", new { area = "Admin" });
                    //return RedirectToAction("Login");
                }

                else
                {
                    ModelState.AddModelError("login.Invalido", "Credenciais incorretas");
                }
            }
            return View("Login");
        }
    }
}