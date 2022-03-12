using System.ComponentModel.DataAnnotations;

namespace VehicleServiceBook.Infrastructure.Data.Models
{
    public class CarService
    {
        [Key]
        public string Id { get; set; } = Guid.NewGuid().ToString();

        public ICollection<Car> Cars { get; set; } = new List<Car>();
    }
}
