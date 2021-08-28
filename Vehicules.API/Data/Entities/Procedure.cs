using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Vehicules.API.Data.Entities
{
    public class Procedure
    {
        public int Id { get; set; }

        [Display(Name = "Procedicimento")]
        [MaxLength(50, ErrorMessage = "Él campo {0} no puede tener más de {1} carácteres.")]
        [Required(ErrorMessage = "Él campo {0} es obligatorio.")]
        public string Description { get; set; }

        [Display(Name = "Precio")]
        [DisplayFormat(DataFormatString = "{0:C2}")]
        [Required(ErrorMessage = "Él campo {0} es obligatorio.")]
        public decimal Price { get; set; }

    }
}
