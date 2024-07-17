
using Data.Models;

namespace Data.Repositories.Contracts
{
    public interface IModuleRepository
    {
        public Module GetById(int id);

        public Module GetAll();

        public Module Create(Module module);

        public Module Update(Module module);

        public Module Delete(int id);
    }
}
