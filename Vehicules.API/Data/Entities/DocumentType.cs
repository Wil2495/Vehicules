using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Vehicules.API.Data.Entities
{
    public class DocumentType
    {
        public int Id { get; set; }

        [Display(Name = "Tipo Documento")]
        [MaxLength(50, ErrorMessage = "Él campo {0} no puede tener más de {1} carácteres.")]
        [Required(ErrorMessage = "Él campo {0} es obligatorio.")]
        public string Description { get; set; }


        public ICollection<User> Users { get; set; }

    }
}
