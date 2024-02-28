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

        [HttpPost]
        public IActionResult Delete(string userToDelete)
        {
            var result = _usersRepository.DeleteUser(userToDelete);
            return RedirectToAction("Index");
        }
    }
}
