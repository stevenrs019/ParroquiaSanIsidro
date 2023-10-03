using System.ComponentModel.DataAnnotations;

namespace SistemaWebParroquia.Models
{
    public class Bautizo
    {
        [Key]
        [Display(Name = "Id")]
        public int ID_bautizos { get; set; }
        [Display(Name = "IdPersona")]
        public int Personas { get; set; }
        [Display(Name = "Fecha de Bautizo")]
        public DateTime FechaBautizo { get; set; }
        [Display(Name = "Lugar de Bautizo")]
        public string LugarBautizo { get; set; }
        [Display(Name = "Presbitero")]
        public string presbitero { get; set; }
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
        [Display(Name = "Padrinos")]
        public string Padrinos { get; set; }
        [Display(Name = "Madrina")]
        public string madrina { get; set; }
        [Display(Name = "Libro B")]
        public int libro_B { get; set; }
        [Display(Name = "Folio B")]
        public int folio_B { get; set; }
        [Display(Name = "Asiento B")]
        public int asiento_B { get; set; }

    }
}
