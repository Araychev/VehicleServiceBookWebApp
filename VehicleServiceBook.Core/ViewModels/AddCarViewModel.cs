using System.ComponentModel.DataAnnotations;

namespace VehicleServiceBook.Core.ViewModels
{
    public class AddCarViewModel
    {
     
        [Required]
        [StringLength(20,MinimumLength = 5,ErrorMessage = "{0} must be between {2} and {1} characters")]
        public string Model { get; set; }

        
        [StringLength(4,MinimumLength = 4,ErrorMessage = "{0} must be {1} characters")]
        public string Year { get; set; }

        [Required]
        [StringLength(17,MinimumLength = 17,ErrorMessage = "{0} must be {1} characters")]
        public string VinNumber { get; set; }
    }
}
