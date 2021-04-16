using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ExLivro.Models
{
    public class Livro
    {

        [Key]
        public long? LivroID { get; set; }

       
        [Required]
        public string Titulo { get; set; }
        [Required]
        public string Autor { get; set; }
      
        [Required]
        public string Editora { get; set; }
        [Display(Name = "Quantidade de Páginas")]
        [Required]
        public int QtdePag { get; set; }
        
        [Display(Name = "Capa Dura")]
        [Required]
        public bool CapaDura { get; set; }
        [Display(Name = "Ano Publicação")]
        [Required]
        public int AnoPub { get; set; }
        
        [Required]
        public float Valor { get; set; }
    }
}
