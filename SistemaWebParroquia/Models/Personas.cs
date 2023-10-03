using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaWebParroquia.Models
{
    public class Personas
    {
        [Key]
        [Display(Name = "Id")]
        public int ID_personas { get; set; }
        [Display(Name = "Nombre")]
        public string nombre { get; set; }
        [Display(Name = "Apellido1")]
        public string apellido1 { get; set; }
        [Display(Name = "Apellido2")]
        public string apellido2 { get; set; }
        [Display(Name = "Cédula")]
        public string cedula { get; set; }
        [Display(Name = "Padre")]
        public string padre { get; set; }
        [Display(Name = "Madre")]
        public string madre { get; set; }
        [Display(Name = "Abuelo Paterno")]
        public string Abuelo_Paterno { get; set; }
        [Display(Name = "Abuela Paterno")]
        public string Abuela_Paterno { get; set; }
        [Display(Name = "Abuelo Materno")]
        public string Abuelo_Materno { get; set; }
        [Display(Name = "Abuela Materno")]
        public string Abuela_Materno { get; set; }
        public string Padrino { get; set; }
        public string Madrina { get; set; }
        [Display(Name = "Fecha de Nacimiento")]
        public DateTime FechaNacimiento { get; set; }
        [Display(Name = "Lugar de Nacimiento")]
        public string Lugarnacimiento { get; set; }
        [Display(Name = "Bautizo")]
        public int bautizos { get; set; }
        [Display(Name = "Comunión")]
        public int comunion { get; set; }
        [Display(Name = "Confirmación")]
        public int confirmacion { get; set; }
        [Display(Name = "Matrimonio")]
        public int matrimonio { get; set; }
    }
}
