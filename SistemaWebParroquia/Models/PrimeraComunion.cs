using System.ComponentModel.DataAnnotations;

namespace SistemaWebParroquia.Models
{
    public class PrimeraComunion
    {
        [Key]
        [Display(Name = "Id")]
        public int ID_comunion { get; set; }
        [Display(Name = "IdPersona")]
        public int Personas { get; set; }
        [Display(Name = "Fecha de Comunión")]
        public DateTime FechaComunion { get; set; }
        [Display(Name = "Lugar de Comunión")]
        public string LugarComunion { get; set; }
        [Display(Name = "Encargado")]
        public string encargado { get; set; }
        [Display(Name = "Fecha de Bautizo")]
        public DateTime FechaBautizo { get; set; }
        [Display(Name = "Lugar de Bautizo")]
        public string LugarBautizo { get; set; }
        [Display(Name = "Libro P")]
        public int libro_P { get; set; }
        [Display(Name = "Folio P")]
        public int folio_P { get; set; }
        [Display(Name = "Asiento P")]
        public int asiento_P { get; set; }
        [Display(Name = "Libro B")]
        public int libro_B { get; set; }
        [Display(Name = "Folio B")]
        public int folio_B { get; set; }
        [Display(Name = "Asiento B")]
        public int asiento_B { get; set; }

    }
}
