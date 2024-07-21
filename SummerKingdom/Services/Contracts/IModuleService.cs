using Data.Models;

namespace Services.Contracts
{
    public interface IModuleService
    {
        public Module GetById(int id);

        public Module GetAll();

        public Module Create(Module module, User user);

        public Module Update(Module module, int id, User user);

        public Module Delete(int id, User user);
    }
}
