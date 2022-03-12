using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VehicleServiceBook.Infrastructure.Data.Models
{
    public class Car
    {
        [Key]
        [StringLength(36)]
        public string Id { get; set; } = Guid.NewGuid().ToString();

        [Required]
        [StringLength(20)]
        public string Model { get; set; }

        
        [StringLength(4)]
        public string Year { get; set; }

        [Required]
        [MaxLength(17)]
        public string VinNumber { get; set; }

   
    }
}
