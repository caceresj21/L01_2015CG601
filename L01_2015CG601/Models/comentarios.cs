using System.ComponentModel.DataAnnotations;
namespace L01_2015CG601.Models
{
    public class comentarios
    {


        [Key]
        public int comentarioId { get; set; }
        public int publicacionId { get; set; }
        public string comentario { get; set; }
        public int usuarioId { get; set; }
    }
}
