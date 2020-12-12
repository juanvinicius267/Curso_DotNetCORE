using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebBlog.dao;
using WebBlog.Models;

namespace WebBlog.Controllers
{
    public class HomeController : Controller
    {
        private PostDAO dao;

        public HomeController(PostDAO dao)
        {


            this.dao = dao;
        }
        
        public IActionResult Index()
        {
            
            IList<Post> publicados = dao.ListaPublicados();

            return View(publicados);
        }
        public IActionResult Busca(string termo)
        {
           
            IList<Post> lista = dao.BuscaPeloTermo(termo);
            return View("Index", lista);
        }
    }

}