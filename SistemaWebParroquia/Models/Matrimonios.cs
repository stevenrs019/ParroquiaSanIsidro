using System.ComponentModel.DataAnnotations;

namespace SistemaWebParroquia.Models
{
    public class Matrimonios
    {
        [Key]
        public int ID_matrimonio { get; set; }
        public int expediente { get; set; }
        public int expediente_registro { get; set; }
        public int Personas { get; set; } 
        public DateTime FechaMatrimonio { get; set; } 
        public string LugarMatrimonio { get; set; } 
        public string presbitero { get; set; } 
        public string padre_1 { get; set; } 
        public string madre_1 { get; set; } 
        public string padre_2 { get; set; } 
        public string madre_2 { get; set; } 
        public string nacionalidad_1 { get; set; } 
        public string nacionalidad_2 { get; set; } 
        public string profesion_1 { get; set; } 
        public string profesion_2 { get; set; } 
        public string religion_1 { get; set; } 
        public string religion_2 { get; set; } 
        public string nacion_1 { get; set; } 
        public string nacion_2 { get; set; } 
        public string feligres_1 { get; set; } 
        public string feligres_2 { get; set; } 
        public DateTime FechaBautizo1 { get; set; } 
        public DateTime FechaBautizo2 { get; set; } 
        public string LugarBautizo1 { get; set; } 
        public string LugarBautizo2 { get; set; } 
        public int libro_M { get; set; } 
        public int folio_M { get; set; } 
        public int asiento_M { get; set; } 
        public int libro_C1 { get; set; } 
        public int folio_C1 { get; set; } 
        public int asiento_C1 { get; set; }
        public int libro_C2 { get; set; }
        public int folio_C2 { get; set; }
        public int asiento_C2 { get; set; }
        public int libro_P1 { get; set; }
        public int folio_P1 { get; set; }
        public int asiento_P1 { get; set; }
        public int libro_P2 { get; set; }
        public int folio_P2 { get; set; }
        public int asiento_P2 { get; set; }
        public int libro_B1 { get; set; }
        public int folio_B1 { get; set; }
        public int asiento_B1 { get; set; }
        public int libro_B2 { get; set; }
        public int folio_B2 { get; set; }
        public int asiento_B2 { get; set; }




    }
}
