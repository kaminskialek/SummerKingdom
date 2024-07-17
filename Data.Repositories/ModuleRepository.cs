using Common.Exceptions;
using Data.Models;
using Data.Repositories.Contracts;

namespace Data.Repositories
{
    public class ModuleRepository : IModuleRepository
    {
        private readonly ApplicationDbContext moduleContext;

        private const string moduleNotFoundErrorMessage = "Module with id {0} cannot be found.";
        public ModuleRepository(ApplicationDbContext context) 
        {
            this.moduleContext = context;
        }
        public Module Create(Module module)
        {
            moduleContext.Modules.Add(module);

            moduleContext.SaveChanges();

            return module;
        }

        public Module Delete(int id)
        {
            Module moduleToDelete = GetById(id);

            moduleToDelete.DeletedOn = DateTime.Now;

            moduleContext.SaveChanges();

            return moduleToDelete;
        }

        public Module GetAll()
        {
            throw new NotImplementedException();
        }

        public Module GetById(int id)
        {
            Module module = moduleContext.Modules
            .FirstOrDefault(l => l.Id == id) ??
             throw new EntityNotFoundException(string.Format(moduleNotFoundErrorMessage, id));

            return module;
        }

        public Module Update(Module module, int id)
        {
            Module updatedModule = GetById(id);

            updatedModule.Title = module.Title;
            updatedModule.Description = module.Description;

            moduleContext.SaveChanges();

            return updatedModule;
        }
    }
}
