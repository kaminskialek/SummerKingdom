using Data.Models;

namespace Services.Contracts
{
    public interface IUserService
    {
        public User GetById(int id);

        public User GetByUserName(string username);

        public User GetByEmail(string email);

        public List<User> GetAll();

        public User Create(User user);

        public User Update(int id, User userToUpdate);

        public User Delete(int id);
    }
}
