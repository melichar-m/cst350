using activity1_mmelichar.Models;
using Bogus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace activity1_mmelichar.Services
{
    public class CarDataRepository : ICarDataService
    {
        static List<CarModel> carList;
        public CarDataRepository()
        {
            carList = new List<CarModel>();
            for (int i = 0; i < 100; i++)
            {
                carList.Add(new Faker<CarModel>()
                    .RuleFor(p => p.Id, i + 5)
                    .RuleFor(p => p.Name, f => f.Commerce.ProductName())
                    .RuleFor(p => p.Price, f => f.Random.Decimal(100))
                    .RuleFor(p => p.Description, f => f.Rant.Review())
                    );
            }
        }
        public List<CarModel> AllCars()
        {
            return carList;
        }

        public bool Delete(CarModel Car)      
        {
            throw new NotImplementedException();
        }

        public CarModel GetCarById(int id)
        {
            throw new NotImplementedException();
        }

        public int Insert(CarModel Car)
        {
            throw new NotImplementedException();
        }

        public List<CarModel> SearchCars(string searchTerm)
        {
            throw new NotImplementedException();
        }

        public int Update(CarModel Car)
        {
            throw new NotImplementedException();
        }
    }
}