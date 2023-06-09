using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    public class FilmeDiretor
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Filmes")]
        public int IdFilme { get; set; }
        public virtual Filme Filmes { get; set; }

        [ForeignKey("Diretores")]
        public int IdDiretor { get; set; }
        public virtual Diretor Diretores { get; set; }
    }
}
