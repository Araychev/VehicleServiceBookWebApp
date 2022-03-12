using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VehicleServiceBook.Infrastructure.Data.Models
{
    public class Issue
    {
        [Key]
        [StringLength(36)]
        public string Id { get; set; } = Guid.NewGuid().ToString();

        [Required] 
        public string Description { get; set; }

        public DateTime DateAdded { get; set; }

        public DateTime DateFixed { get; set; }

        public bool IsFixed { get; set; }

        [Required]
        public string CarId { get; set; }

        [ForeignKey(nameof(CarId))]
        public Car Car { get; set; }
    }
}
