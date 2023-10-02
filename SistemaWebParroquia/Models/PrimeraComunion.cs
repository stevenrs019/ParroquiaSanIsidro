using System.ComponentModel.DataAnnotations;

namespace SistemaWebParroquia.Models
{
    public class PrimeraComunion
    {
        [Key]
        public int ID_comunion { get; set; }
        public int Personas { get; set; }
        public DateTime FechaComunion { get; set; }
        public string LugarComunion { get; set; }
        public string encargado { get; set; }
        public DateTime FechaBautizo { get; set; }
        public string LugarBautizo { get; set; }
        public int libro_P { get; set; }
        public int folio_P { get; set; }
        public int asiento_P { get; set; }
        public int libro_B { get; set; }
        public int folio_B { get; set; }
        public int asiento_B { get; set; }

    }
}
