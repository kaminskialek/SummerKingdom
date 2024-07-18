using Common.Exceptions;
using Data.Models;
using Data.Repositories.Contracts;
using System.Reflection.Metadata;

namespace Data.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext userContext;

        private const string userNotFoundErrorMessage = "User with {0}: {1} cannot be found.";
        public UserRepository(ApplicationDbContext context) 
        {
            this.userContext = context;
        }
        public User Create(User user)
        {
            userContext.Users.Add(user);

            userContext.SaveChanges();

            return user;
        }

        public User Delete(int id)
        {
            User userToDelete = GetById(id);

            userToDelete.DeletedOn = DateTime.Now;

            userContext.SaveChanges();

            return userToDelete;
        }

        public List<User> GetAll()
        {
            throw new NotImplementedException();
        }

        public User GetByEmail(string email)
        {
            User user = userContext.Users
            .FirstOrDefault(u => u.Email == email && u.DeletedOn.HasValue == false) ??
            throw new EntityNotFoundException(string.Format(userNotFoundErrorMessage, "email", email));

            return user;
        }

        public User GetById(int id)
        {
            User user = userContext.Users
            .FirstOrDefault(u => u.Id == id && u.DeletedOn.HasValue == false) ??
            throw new EntityNotFoundException(string.Format(userNotFoundErrorMessage, "id",id));

            return user;
        }

        public User GetByUserName(string username)
        {
            User user = userContext.Users
            .FirstOrDefault(u => u.Username == username && u.DeletedOn.HasValue == false) ??
            throw new EntityNotFoundException(string.Format(userNotFoundErrorMessage, "username", username));

            return user;
        }

        public User Update(int id, User userToUpdate)
        {
            User updatedUser = GetById(id);

            updatedUser.FirstName = userToUpdate.FirstName;
            updatedUser.LastName = userToUpdate.LastName;
            updatedUser.Email = userToUpdate.Email;
            updatedUser.Password = userToUpdate.Password;

            userContext.SaveChanges();

            return updatedUser;
        }
    }
}
