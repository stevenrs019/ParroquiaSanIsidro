using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaWebParroquia.Models
{
    public class Personas
    {
        [Key]
        public int ID_personas { get; set; }
        public string nombre { get; set; }
        public string apellido1 { get; set; }
        public string apellido2 { get; set; }
        public string cedula { get; set; }
        public string padre { get; set; }
        public string madre { get; set; }
        public string Abuelo_Paterno { get; set; }
        public string Abuela_Paterno { get; set; }
        public string Abuelo_Materno { get; set; }
        public string Abuela_Materno { get; set; }
        public string Padrino { get; set; }
        public string Madrina { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Lugarnacimiento { get; set; }
        public int bautizos { get; set; }
        public int comunion { get; set; }
        public int confirmacion { get; set; }
        public int matrimonio { get; set; }
    }
}
