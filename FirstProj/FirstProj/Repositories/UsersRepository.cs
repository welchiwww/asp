using FirstProj.Abstractions;
using FirstProj.Models;
using System.Security.Cryptography.X509Certificates;

namespace FirstProj.Repositories
{
    public class UsersRepository : IUsersRepository
    {
        public List<User> Users = new List<User>()
            {
                new User
                {
                    Name = "User1",
                    Email = "Email1",
                    Info = new Info
                    {
                        Description = "Description 1"
                    }
                },
                new User
                {
                    Name = "User2",
                    Email = "Email2",
                    Info = new Info
                    {
                        Description = "Description 2"
                    }
                },
                new User
                {
                    Name = "User3",
                    Email = "Email3",
                    Info = new Info
                    {
                        Description = "Description 3"
                    }
                },
                new User
                {
                    Name = "User4",
                    Email = "Email4",
                    Info = new Info
                    {
                        Description = "Description 4"
                    }
                }
            };
        public UsersRepository() 
        { 
        }

        public List<User> GetUsers() 
        {
            return Users;
        }

        public string DeleteUser(string Name)
        {
            var userToDelete = Users.FirstOrDefault(u => u.Name == Name);
            Users.Remove(userToDelete);
            return userToDelete.Name;
        }
    }
}
