using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebBlog.dao;
using WebBlog.Models;

namespace WebBlog.Areas.API.Controllers
{    
    [Area("Api")]
    [Route("/api/post")]
    [ApiController]
    public class ApiPostController : Controller
    {
        private PostDAO dao;

        public ApiPostController(PostDAO dAO)
        {
            this.dao = dAO;
        }

        [Route("lista")]
        [HttpGet]
        public IActionResult BuscaTodosPosts()
        {
            IList<Post> posts = dao.Lista();
            return Ok(posts);
        }

        [Route("{id}")]
        [HttpGet]
        public IActionResult BuscaPorId(int id)
        {
            return Ok(dao.Carregar(id));

        }

        [HttpDelete]
        [Route("{id}")]
        public IActionResult Remove(int id)
        {
            Post doBanco = dao.Carregar(id);
            if (doBanco == null)
            {
                return NotFound();
            }
            else
            {
                dao.Remove(id);
                return NoContent();
            }
            
        }


        [HttpPut]
        [Route("{id}")]
        public IActionResult Edita(int id, [FromBody]Post p)
        {
            Post doBanco = dao.Carregar(id);
            if (doBanco == null) 
            {
                return NotFound();
            }
            else
            {
                doBanco.Titulo = p.Titulo;
                doBanco.Resumo = p.Resumo;
                doBanco.Categoria = p.Categoria;
                dao.Atualiza(doBanco);
                return NoContent();

            }

        }

        [Route("novo")]
        [HttpPost]
        public IActionResult Adiciona([FromBody] Post p)
        {
            dao.Adiciona(p);
            return CreatedAtAction("BuscaPorId", new { id = p.id }, p);

        }


    }
}