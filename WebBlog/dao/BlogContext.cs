using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using WebBlog.Models;

namespace WebBlog.dao
{
    public class BlogContext : DbContext
    {
        
        public BlogContext(DbContextOptions<BlogContext> options) : base(options) { }

        public DbSet<Post>Posts { get; set; }

        public DbSet<Usuario> Usuarios { get; set; }

        
    }
}
