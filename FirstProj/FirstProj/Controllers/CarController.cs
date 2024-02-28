using FirstProj.Abstractions;
using Microsoft.AspNetCore.Mvc;

namespace FirstProj.Controllers
{
    public class CarController : Controller
    {
        private readonly ICarsRepository _carsRepository;
        public CarController(ICarsRepository carsRepository)
        {
            _carsRepository = carsRepository;
        }

        public IActionResult Index()
        {
            return Ok("wassup its car controller, /index");
        }

        public IActionResult GetCars()
        {
            var cars = _carsRepository.GetCars();
            return Ok(cars);
        }

        [HttpGet("Car/GetCarById/{id}")]
        public IActionResult GetCarById(int id)
        {
            var cars = _carsRepository.GetCarById(id);
            return Ok(cars);
        }
    }
}
