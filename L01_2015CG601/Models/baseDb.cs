using System.ComponentModel.DataAnnotations;
using System.Globalization;


namespace L01_2015CG601.Models
{
    public class baseDb
    {
        [Key]

        public int RolId { get; set; }
        public string rol { get; set; }
        public int usuarioId { get; set; }
        public int rolid { get; set; }
        public string nombreUsuario { get; set; }
        public string clave { get; set; }

        public string nombre { get; set; }

        public string apellido { get; set; }

        public int? publicacionId { get; set; }

        public string titulo { get; set; }

        public string descripcion { get; set; }
       

        public string comentario { get; set; }

        public int calificacion { get; set; }

        



    }
}
