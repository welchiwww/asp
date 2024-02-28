using FirstProj.Models;

namespace FirstProj.Abstractions
{
    public interface IUsersRepository
    {
        public List<User> GetUsers();
        public string DeleteUser(string Name);
    }
}
