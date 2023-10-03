using System.ComponentModel.DataAnnotations;

namespace SistemaWebParroquia.Models
{
    public class Matrimonios
    {
        [Key]
        [Display(Name = "Id")]
        public int ID_matrimonio { get; set; }
        [Display(Name = "IdPersona")]
        public int Personas { get; set; }
        [Display(Name = "Expediente")]
        public int expediente { get; set; }
        [Display(Name = "Expediente de Registro")]
        public int expediente_registro { get; set; }
        [Display(Name = "Fecha de Matrimonio")]
        public DateTime FechaMatrimonio { get; set; }
        [Display(Name = "Lugar de Matrimonio")]
        public string LugarMatrimonio { get; set; }
        [Display(Name = "Presbitero")]
        public string presbitero { get; set; }
        [Display(Name = "Padre 1")]
        public string padre_1 { get; set; }
        [Display(Name = "Madre 1")]
        public string madre_1 { get; set; }
        [Display(Name = "Padre 2")]
        public string padre_2 { get; set; }
        [Display(Name = "Madre 2")]
        public string madre_2 { get; set; }
        [Display(Name = "Nacionalidad 1")]
        public string nacionalidad_1 { get; set; }
        [Display(Name = "Nacionalidad 2")]
        public string nacionalidad_2 { get; set; }
        [Display(Name = "Profesión 1")]
        public string profesion_1 { get; set; }
        [Display(Name = "Profesión 2")]
        public string profesion_2 { get; set; }
        [Display(Name = "Religión 1")]
        public string religion_1 { get; set; }
        [Display(Name = "Religión 2")]
        public string religion_2 { get; set; }
        [Display(Name = "Nación 1")]
        public string nacion_1 { get; set; }
        [Display(Name = "Nación 2")]
        public string nacion_2 { get; set; }
        [Display(Name = "Feligres 1")]
        public string feligres_1 { get; set; }
        [Display(Name = "Feligres 2")]
        public string feligres_2 { get; set; }
        [Display(Name = "Fecha de Bautizo 1")]
        public DateTime FechaBautizo1 { get; set; }
        [Display(Name = "Fecha de Bautizo 2")]
        public DateTime FechaBautizo2 { get; set; }
        [Display(Name = "Lugar de Bautizo 1")]
        public string LugarBautizo1 { get; set; }
        [Display(Name = "Lugar de Bautizo 2")]
        public string LugarBautizo2 { get; set; }
        [Display(Name = "Libro M")]
        public int libro_M { get; set; }
        [Display(Name = "Folio M")]
        public int folio_M { get; set; }
        [Display(Name = "Asiento M")]
        public int asiento_M { get; set; }
        [Display(Name = "Libro C1")]
        public int libro_C1 { get; set; }
        [Display(Name = "Folio C1")]
        public int folio_C1 { get; set; }
        [Display(Name = "Asiento C1")]
        public int asiento_C1 { get; set; }
        [Display(Name = "Libro C2")]
        public int libro_C2 { get; set; }
        [Display(Name = "Folio C2")]
        public int folio_C2 { get; set; }
        [Display(Name = "Asiento C2")]
        public int asiento_C2 { get; set; }
        [Display(Name = "Libro P1")]
        public int libro_P1 { get; set; }
        [Display(Name = "Folio P1")]
        public int folio_P1 { get; set; }
        [Display(Name = "Asiento P1")]
        public int asiento_P1 { get; set; }
        [Display(Name = "Libro P2")]
        public int libro_P2 { get; set; }
        [Display(Name = "Folio P2")]
        public int folio_P2 { get; set; }
        [Display(Name = "Asiento P2")]
        public int asiento_P2 { get; set; }
        [Display(Name = "Libro B1")]
        public int libro_B1 { get; set; }
        [Display(Name = "Folio B1")]
        public int folio_B1 { get; set; }
        [Display(Name = "Asiento B1")]
        public int asiento_B1 { get; set; }
        [Display(Name = "Libro B2")]
        public int libro_B2 { get; set; }
        [Display(Name = "Folio B2")]
        public int folio_B2 { get; set; }
        [Display(Name = "Asiento B2")]
        public int asiento_B2 { get; set; }




    }
}
