using Common.Exceptions;
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

        public User Delete(int id, User user)
        {
            if (user.UserType != UserType.Admin)
            {
                throw new UnauthorizedOperationException("Only an admin may delete users.");
            }
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

        public User Update(int id, User user)
        {
            if (user.Id != id)
            {
                throw new UnauthorizedOperationException("You may not modify another user's account.");
            }
            return this.userRepository.Update(id, user);
        }
    }
}
