using FirstProj.Models;

namespace FirstProj.Abstractions
{
    public interface ICarsRepository
    {
        public List<Car> GetCars();
        public Car GetCarById(int id);
    }
}
