using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebBlog.dao;
using WebBlog.Models;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace WebBlog.Areas.Admin.Controllers
{   
    [Area("Admin")]
    
    public class PostController : Controller
    {
        private PostDAO dAO;
        private List<Post> posts = new List<Post>();
        public  PostController(PostDAO dao)
        {
            this.dAO = dao;
        }
        public IActionResult Categoria([Bind(Prefix = "id")] string categoria)
        {
            
            List<Post> posts = dAO.BuscaPorCategoria(categoria);
            return View("Index", posts);

        }
        public IActionResult Remover(int id)
        {
            
            dAO.Remove(id);
            return RedirectToAction("Index");

        }
        public IActionResult Editar(int id)
        {
           
            Post p = dAO.Carregar(id);
            return View();
        }
        public IActionResult Altera(Post p)
        {
            if (ModelState.IsValid)
            {
                
                dAO.Atualiza(p);
                return RedirectToAction("Index");
            }
            else
            {
                return View("Novo", p);
            }
        }

        public IActionResult Publica(int id)
        {
           
            dAO.Publicar(id);
            return RedirectToAction("Index");
        }


        [HttpPost]
        public IActionResult Adiciona(Post p)
        {
            if (ModelState.IsValid)
            {
                
                dAO.Adiciona(p);
                return RedirectToAction("Index");
            }
            else
            {
                return View("Novo", p);
            }

            //this.posts.Add(p);
            //return View("Index",this.posts);

        }
        public IActionResult Novo()
        {
            var model = new Post();

            return View(model);
        }
        [HttpPost]
        public IActionResult CategoriaAutocomplete(string termoDigitado)
        {
            
            var model = dAO.ListaCategoriasQueContemTermo(termoDigitado);
            return View(model);
        }
        public IActionResult Index()
        {

            
            List<Post> posts = dAO.Lista();
            return View(posts);
            //Post p1 = new Post();
            //Post p2 = new Post();
            //Post p3 = new Post();
            //p1.Titulo = "Harry Potter";
            //p1.Resumo = "Pedra filosofal";
            //p1.Categoria = "Filme/Livro";
            //p2.Titulo = "Harry Potter";
            //p2.Resumo = "Pedra filosofal";
            //p2.Categoria = "Filme/Livro";
            //p3.Titulo = "Harry Potter";
            //p3.Resumo = "Pedra filosofal";
            //p3.Categoria = "Filme/Livro";
            //posts.Add(p1);
            //posts.Add(p2);
            //posts.Add(p3);
            //return View(posts);
        }
    }
}