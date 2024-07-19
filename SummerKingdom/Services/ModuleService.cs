using Data.Models;
using Data.Repositories.Contracts;
using Services.Contracts;

namespace Services
{
    public class ModuleService : IModuleService
    {
        private readonly IModuleRepository moduleRepository;
        public ModuleService(IModuleRepository moduleRepository)
        {
            this.moduleRepository = moduleRepository;
        }
        public Module Create(Module module)
        {
            throw new NotImplementedException();
        }

        public Module Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Module GetAll()
        {
            throw new NotImplementedException();
        }

        public Module GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Module Update(Module module, int id)
        {
            throw new NotImplementedException();
        }
    }
}
