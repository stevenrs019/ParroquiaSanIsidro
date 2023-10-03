using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaWebParroquia.Models
{
    public class Confirmacion
    {
        [Key]
        [Display(Name = "Id")]
        public int ID_confirmacion { get; set; }
        [Display(Name = "IdPersona")]
        public int Personas { get; set; }
        [Display(Name = "Fecha de Confirmación")]
        public DateTime FechaConfirmacion { get; set; }
        [Display(Name = "Lugar de Confirmación")]
        public string LugarConfirmacion { get; set; }
        [Display(Name = "Ecargado")]
        public string encargado { get; set; }
        [Display(Name = "Padrino")]
        public string padrino { get; set; }
        [Display(Name = "Obispo")]
        public string obispo { get; set; }
        [Display(Name = "Fecha Bautizo")]
        public DateTime fechaBautizo { get; set; }
        [Display(Name = "Lugar Bautizo")]
        public string lugarBautizo { get; set; }
        [Display(Name = "Libro C")]
        public int libro_C { get; set; }
        [Display(Name = "Folio C")]
        public int folio_C { get; set; }
        [Display(Name = "Asiento C")]
        public int asiento_C { get; set; }
        [Display(Name = "Libro B")]
        public int libro_B { get; set; }
        [Display(Name = "Folio B")]
        public int folio_B { get; set; }
        [Display(Name = "Asiento B")]
        public int asiento_B { get; set; }
    }
}
