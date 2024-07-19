using Data.Models;
using Data.Repositories.Contracts;

using Services.Contracts;

namespace Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository userRepository;
        public UserService(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        public User Create(User user)
        {
            return this.userRepository.Create(user);
        }

        public User Delete(int id)
        {
            return this.userRepository.Delete(id);
        }

        public List<User> GetAll()
        {
            return this.userRepository.GetAll();    
        }

        public User GetByEmail(string email)
        {
            return this.userRepository.GetByEmail(email);
        }

        public User GetById(int id)
        {
            return this.userRepository.GetById(id);
        }

        public User GetByUserName(string username)
        {
            return this.userRepository.GetByUserName(username);
        }

        public User Update(int id, User userToUpdate)
        {
            return this.userRepository.Update(id, userToUpdate);
        }
    }
}
