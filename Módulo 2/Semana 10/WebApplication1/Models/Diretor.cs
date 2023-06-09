using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Diretor
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="Campo obrigatório")]
        [MaxLength(100, ErrorMessage = "Este campo aceita até 100 caractéres.")]
        [MinLength(3, ErrorMessage = "O nome do diretor deve ter mais que 3 caractéres")]
        public string Nome { get; set; }


        [Required(ErrorMessage = "Campo obrigatório")]
        [MaxLength(100, ErrorMessage = "Este campo aceita até 100 caractéres.")]
        [MinLength(3, ErrorMessage = "O nome do diretor deve ter mais que 3 caractéres")]
        public string Telefone { get; set; }

    }
}
