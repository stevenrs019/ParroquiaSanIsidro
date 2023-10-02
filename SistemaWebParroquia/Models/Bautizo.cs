using System.ComponentModel.DataAnnotations;

namespace SistemaWebParroquia.Models
{
    public class Bautizo
    {
        [Key]
        public int ID_bautizos { get; set; }
        public int Personas { get; set; }
        public DateTime FechaBautizo { get; set; }
        public string LugarBautizo { get; set; }
        public string presbitero { get; set; }
        public string padre { get; set; }
        public string madre { get; set; }
        public string Abuelo_Paterno { get; set; }
        public string Abuela_Paterno { get; set; }
        public string Abuelo_Materno { get; set; }
        public string Abuela_Materno { get; set; }
        public string Padrinos { get; set; }
        public string madrina { get; set; }
        public int libro_B { get; set; }
        public int folio_B { get; set; }
        public int asiento_B { get; set; }

    }
}
