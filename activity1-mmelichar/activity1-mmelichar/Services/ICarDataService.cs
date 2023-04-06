using activity1_mmelichar.Models;
using System.Collections.Generic;

namespace activity1_mmelichar
{
    public interface ICarDataService
    {
        List<CarModel> AllCars();
        List<CarModel> SearchCars(string searchTerm);
        CarModel GetCarById(int id);
        int Insert(CarModel Car);
        bool Delete(CarModel Car);
        int Update(CarModel Car);
    }
}