using System;
using System.ComponentModel.DataAnnotations;
using Vehicules.API.Data.Entities;

namespace Vehicles.API.Data.Entities
{
    public class VehiclePhoto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public Vehicle Vehicle { get; set; }

        [Display(Name = "Foto")]
        public Guid ImageId { get; set; }

        //TODO: Fix the correct path
        [Display(Name = "Foto")]
        public string ImageFullPath => ImageId == Guid.Empty
            ? $"https://localhost:44370/images/noimage.png"
          : $"https://localhost:44370/vehicles/{ImageId}";
    }
}