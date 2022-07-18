using Microsoft.EntityFrameworkCore;

namespace PAA_2022_EF_Intro.Models
{
    public class EFContext : DbContext
    {
        // 1. Crear atributo que almacene la cadena de conexión a la BD
        private const string ConnectionString = "server=localhost;port=3306;database=musica_db;user=root;password=;Connect Timeout=5;";

        // ToDo: Para revisar con calma, la inclusión y/o modificaciones que se deban hacer
        // para configurar la instancia inicial de MySQL en conexión al proyecto
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(ConnectionString,
                new MySqlServerVersion(new Version(8, 0, 11)));
        }

        // 2. Definir qué clases son modelos desde la base de datos
        public DbSet<Album> Albumes { get; set; }
        public DbSet<Cancion> Canciones { get; set; }

        // 3. Configurar los modelos 
        // ToDo: Establecer las relaciones y restricciones de la tabla
        // * Definir clave primaria * Establecer las relaciones
        // * Definir cuáles son obligatorios


    }
}
