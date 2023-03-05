using System.ComponentModel.DataAnnotations;


namespace L01_2015CG601.Models
{
    public class calificaciones
    {
        [Key]
        public int calificacionId { get; set; }
        public int publicionId { get; set; }
        public int usuarioId { get; set; }
        public int calificacion { get; set; }
    }
}
