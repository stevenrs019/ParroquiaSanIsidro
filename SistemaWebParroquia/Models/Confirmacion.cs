using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaWebParroquia.Models
{
    public class Confirmacion
    {
        [Key]
        public int ID_confirmacion { get; set; }
        public int Personas { get; set; }
        public DateTime FechaConfirmacion { get; set; }
        public string LugarConfirmacion { get; set; }
        public string encargado { get; set; }
        public string padrino { get; set; }
        public string obispo { get; set; }
        public DateTime fechaBautizo { get; set; }
        public string lugarBautizo { get; set; }
        public int libro_C { get; set; }
        public int folio_C { get; set; }
        public int asiento_C { get; set; }
        public int libro_B { get; set; }
        public int folio_B { get; set; }
        public int asiento_B { get; set; }
    }
}
