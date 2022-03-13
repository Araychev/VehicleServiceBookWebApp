using VehicleServiceBook.Core.ViewModels;

namespace VehicleServiceBook.Core.Contracts
{
    public interface ICarService
    {
        public void CreateCar(AddCarViewModel model);
    }

}
