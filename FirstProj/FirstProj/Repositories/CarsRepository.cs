using FirstProj.Abstractions;
using FirstProj.Models;

namespace FirstProj.Repositories
{
    public class CarsRepository : ICarsRepository
    {
        public List<Car> Cars = new List<Car>()
        {
            new Car()
            {
                Id = 1,
                Name = "bmw",
                Description = "normik"
            },

            new Car()
            {
                Id = 2,
                Name = "mercedes",
                Description = "poidet"
            }
        };

        public List<Car> GetCars()
        {
            return Cars;
        }

        public Car GetCarById(int id)
        {
            var carById = Cars.Find(x => x.Id == id);
            return carById;
        }
    }
}
