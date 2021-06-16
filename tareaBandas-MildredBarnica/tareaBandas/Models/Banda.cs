using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace tareaBandas.Models
{
    public class Banda
    {
        [Key]
        public int BandaId { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio.")]
        [StringLength(70, ErrorMessage = "No debe tener más de 100 cáracteres.")]
        [MinLength(3, ErrorMessage = "El mínimo de cáracteres es 2.")]
        [Display (Name= "Nombre")]
        public string BandaNombre { get; set; }

        [Display(Name = "Genero")]
        [Required(ErrorMessage = "El género es obligatorio.")]
        [StringLength(70, ErrorMessage = "No debe tener más de 100 cáracteres.")]
        [MinLength(2, ErrorMessage = "El mínimo de cáracteres es 2.")]
        public string BandaGenero { get; set; }

        [Display(Name = "Sitio Web")]
        [StringLength(70, ErrorMessage = "No debe tener más de 100 cáracteres.")]
        [MinLength(5, ErrorMessage = "El mínimo de cáracteres es 5.")]
        public string BandaSitioWeb { get; set; }

        [Required(ErrorMessage = "El año de inicio es obligatorio.")]
        [MinLength(4, ErrorMessage = "El mínimo de cáracteres es 4.")]
        [Display(Name = "Año de inicio")]
        public int BandaInicio { get; set; }


        [Display(Name = "Vocalista")]
        [Required(ErrorMessage = "El nombre del vocalista es obligatorio.")]
        [StringLength(70, ErrorMessage = "No debe tener más de 100 cáracteres.")]
        [MinLength(5, ErrorMessage = "El mínimo de cáracteres es 5.")]
        public string BandaVocalista { get; set; }
    }
}

