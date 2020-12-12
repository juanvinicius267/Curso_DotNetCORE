using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebBlog.Models;

namespace WebBlog.dao
{
    public class UsuarioDAO
    {
        private BlogContext context;

        public UsuarioDAO(BlogContext context)
        {
            this.context = context;
        }
        public Usuario BuscaUsuario(string login, string senha)
        {
            return context.Usuarios.Where(u => u.Nome.Equals(login)
            && u.Senha.Equals(senha)).FirstOrDefault<Usuario>();


        }
    }
}
