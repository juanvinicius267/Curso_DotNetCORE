using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebBlog.Models
{
    //[Table("Post")]
    public class Post
    {
        public  int id { get; set; }
        
        [Required(ErrorMessage = "Titulo Obrigatorio")]
        [Display(Name = "Titulo")]
        public string Titulo { get; set; }

        [StringLength(50)]
        public string Resumo { get; set; }

        public string Categoria { get; set; }

        public bool Publicado { get; set; }

        public DateTime? DataPublicacao { get; set; }

    }
}
