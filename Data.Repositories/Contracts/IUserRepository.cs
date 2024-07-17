using Data.Models;

namespace Data.Repositories.Contracts
{
    public interface IUserRepository
    {
        public User GetById (int id);
        
        public User GetByUserName (string username);

        public User GetByEmail (string email);

        public List<User> GetAll();

        public User Create(User user);

        public User Update(int id, User userToUpdate);

        public User Delete(int id);
    }
}
