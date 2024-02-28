using FirstProj.Abstractions;
using Microsoft.AspNetCore.Mvc;

namespace FirstProj.Controllers
{
    public class UsersController : Controller
    {
        private readonly IUsersRepository _usersRepository;
        public UsersController(IUsersRepository usersRepository) 
        {
            _usersRepository = usersRepository;
        }
        public IActionResult Index()
        {
            var result = _usersRepository.GetUsers().ToList();
            return View(result);
        }

        public IActionResult Delete()
        {
            var result = _usersRepository.DeleteUser("User1");
            return RedirectToAction("Index");
        }
    }
}
