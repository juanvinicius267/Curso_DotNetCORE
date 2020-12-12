using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace WebBlog.Infra
{
    public class ConnectionFactory
    {
        public static SqlConnection CriaConexãoAberta()
        {
            var builder = new ConfigurationBuilder()
                          .SetBasePath(Directory.GetCurrentDirectory())
                          .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                          .AddEnvironmentVariables();
            IConfiguration configuration = builder.Build();
            string stringConexão = configuration.GetConnectionString("Blog");
            SqlConnection conexao = new SqlConnection(stringConexão);
            conexao.Open();

            return conexao;
        }

        
    }
}
