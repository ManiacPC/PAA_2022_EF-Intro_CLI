using System.ComponentModel.DataAnnotations.Schema;

namespace PAA_2022_EF_Intro.Models
{
    [Table("Album")] // Indicar la tabla al que pertenecerá la clase POCO
    public class Album
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public DateTime Lanzamiento { get; set; }
        public bool? TopSeller { get; set; }
        public string Productora { get; set; }

        // Relaciones
        public virtual ICollection<Cancion> Canciones { get; set; }
    }
}
