using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using WebBlog.dao;
using WebBlog.Infra;
using WebBlog.Models;

namespace WebBlog.dao
{
    public class PostDAO
    {
        private BlogContext context;

        public PostDAO(BlogContext context)
        {
            this.context = context;
        }
        public List<Post> Lista()
        {
            
                var lista = context.Posts.ToList();
                return lista;
           
        //using (SqlConnection connection = ConnectionFactory.CriaConexãoAberta())
        //using (SqlCommand command = connection.CreateCommand())
        //{
        //    command.CommandText = "SELECT * FROM POST";
        //    List<Post> posts = new List<Post>();
        //    IDataReader leitor = command.ExecuteReader();
        //    while (leitor.Read())
        //    {
        //        Post p = new Post();
        //        p.Titulo = Convert.ToString(leitor["Titulo"]);
        //        p.Resumo = Convert.ToString(leitor["Resumo"]);
        //        p.Categoria = Convert.ToString(leitor["Categoria"]);
        //        p.id = Convert.ToInt32(leitor["Id"]);
        //        posts.Add(p);

                //    }
                //    return posts;


                //}

        }

        public IList<string> ListaCategoriasQueContemTermo(string termo)
        {
             return context.Posts
                    .Where(p => p.Categoria.Contains(termo))
                    .Select(p => p.Categoria)
                    .Distinct()
                    .ToList();
            
        }
        public void Adiciona(Post p)
        {
            
                context.Posts.Add(p);
                context.SaveChanges();
            



            //using (SqlConnection connection = ConnectionFactory.CriaConexãoAberta())
            //using (SqlCommand command = connection.CreateCommand())
            //{
            //    command.CommandText = "INSERT INTO POST (TITULO,RESUMO,CATEGORIA) VALUES (@TITULO,@RESUMO,@CATEGORIA)";
            //    command.Parameters.Add(new SqlParameter("TITULO", p.Titulo));
            //    command.Parameters.Add(new SqlParameter("RESUMO", p.Resumo));
            //    command.Parameters.Add(new SqlParameter("CATEGORIA", p.Categoria));
            //    command.ExecuteNonQuery();
            //}

        }

        public List<Post> BuscaPorCategoria(string categoria)
        {
            
                return context.Posts.Where(
                    p => p.Categoria.Contains(categoria))
                    .ToList();
            
        }
        public void Remove(int id)
        {
            
                Post p = context.Posts.Find(id);
                context.Posts.Remove(p);
                context.SaveChanges();         


        }
        public Post Carregar(int id)
        {
            
                 Post p = context.Posts.Find(id);
                 return p;
                                                                      
            
        }
        public void Atualiza(Post p)
        {
            
                context.Entry(p).State = EntityState.Modified;

            
        }
        public  void Publicar(int id)
        {
            
                Post p = context.Posts.Find(id) ;
                p.Publicado = true;
                p.DataPublicacao = DateTime.Now;
                context.SaveChanges();
                
            
        }
        public IList<Post> BuscaPeloTermo(string termo)
        {
            
               return context.Posts.Where(p => (p.Titulo.Contains(termo)) || 
               (p.Resumo.Contains(termo))).ToList();
               

           
        }
        public IList<Post> ListaPublicados()
        {
            
                return context.Posts.Where(p => p.Publicado)
                    .OrderByDescending(p => p.DataPublicacao).ToList();
           
        }
    }

}

