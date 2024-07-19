using Data.Models;

namespace Services.Contracts
{
    public interface IModuleService
    {
        public Module GetById(int id);

        public Module GetAll();

        public Module Create(Module module);

        public Module Update(Module module, int id);

        public Module Delete(int id);
    }
}
