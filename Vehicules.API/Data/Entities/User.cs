using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Vehicles.API.Data.Entities;
using VehiculesCommon.Enums;

namespace Vehicules.API.Data.Entities
{
    public class User : IdentityUser
    {
        [Display(Name = "Nombres")]
        [MaxLength(50, ErrorMessage = "Él campo {0} no puede tener más de {1} carácteres.")]
        [Required(ErrorMessage = "Él campo {0} es obligatorio.")]
        public string FirstName { get; set; }

        [Display(Name = "Apellidos")]
        [MaxLength(50, ErrorMessage = "Él campo {0} no puede tener más de {1} carácteres.")]
        [Required(ErrorMessage = "Él campo {0} es obligatorio.")]
        public string LastName { get; set; }

        [Display(Name = "Tipo de documento")]
        [Required(ErrorMessage = "Él campo {0} es obligatorio.")]
        public DocumentType DocumentType { get; set; }

        [Display(Name = "Documento")]
        [MaxLength(20, ErrorMessage = "Él campo {0} no puede tener más de {1} carácteres.")]
        [Required(ErrorMessage = "Él campo {0} es obligatorio.")]
        public string Document { get; set; }

        [Display(Name = "Dirección")]
        [MaxLength(100, ErrorMessage = "Él campo {0} no puede tener más de {1} carácteres.")]
        public string Address { get; set; }

        [Display(Name = "Foto")]
        public Guid ImageId { get; set; }

        //TODO: FIX the images path
        public string ImageFullPath => ImageId == Guid.Empty
          ? $"https://localhost:44370/images/noimage.png"
          : $"https://localhost:44370/users/{ImageId}";
      
        [Display(Name = "Tipo de usuario")]
        public UserType UserType { get; set; }
       
        [Display(Name = "Usuario")]
        public string FullName => $"{FirstName} {LastName}";
   
        public ICollection<Vehicle> Vehicles { get; set; }


        [Display(Name = "# Vehículos")]
        public int VehiclesCount => Vehicles == null ? 0 : Vehicles.Count;
        

    }
}
