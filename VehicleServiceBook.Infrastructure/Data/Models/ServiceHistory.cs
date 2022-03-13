using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VehicleServiceBook.Infrastructure.Data.Models
{
    public class ServiceHistory
    {
        [Key]
        public string Id { get; set; } = Guid.NewGuid().ToString();

        [Required]
        [StringLength(36)]
        public string CarId { get; set; }

        [ForeignKey(nameof(CarId))]
        public Car Car { get; set; }

        public ICollection<Issue> Issues { get; set; } = new List<Issue>();
    }
}
