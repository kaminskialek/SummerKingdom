using Common;
using Common.Exceptions;
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
        public Module Create(Module module, User user)
        {
            if (user.UserType == UserType.Player) 
            {
                throw new UnauthorizedOperationException(Constants.NotDMOrAdminErrorMessage);
            }
            return this.moduleRepository.Create(module, user);
        }

        public Module Delete(int id, User user)
        {
            if(user.UserType != UserType.Admin && !user.CreatedModules.Any(m => m.Id == id))
            {
                throw new UnauthorizedOperationException(Constants.NotCreatorOrAdminErrorMessage);
            }
            return this.moduleRepository.Delete(id);
        }

        public Module GetAll()
        {
            return this.moduleRepository.GetAll();
        }

        public Module GetById(int id)
        {
            return this.moduleRepository.GetById(id);
        }

        public Module Update(Module module, int id, User user)
        {
            if (user.UserType != UserType.Admin && !user.CreatedModules.Any(m => m.Id == id))
            {
                throw new UnauthorizedOperationException(Constants.NotCreatorOrAdminErrorMessage);
            }
            return this.moduleRepository.Update(module, id);
        }
    }
}
