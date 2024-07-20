using Common.Exceptions;
using Data.Models;
using Data.Repositories.Contracts;
using Services.Contracts;

namespace Services
{
    public class AdventureService : IAdventureService
    {
        private const string UnauthorizedOperationErrorMessage = "Only and admin or dungeon master may perform this action.";
        private const string NotCreatorErrorMessage = "Only the module creator or an admin may perform this action.";

        private readonly IAdventureRepository adventureRepository;
        public AdventureService(IAdventureRepository adventureRepository)
        {
            this.adventureRepository = adventureRepository;
        }
        public Adventure Create(Adventure adventure,Module module, User user)
        {
            if (user.UserType == UserType.Player)
            {
                throw new UnauthorizedOperationException(UnauthorizedOperationErrorMessage);
            }
            return this.adventureRepository.Create(adventure, module);
        }

        public Adventure Delete(int id, User user)
        {
            Adventure adventureToDelete = adventureRepository.GetById(id);
            if(user.UserType != UserType.Admin && adventureToDelete.Module.Creator != user)
            {
                throw new UnauthorizedOperationException(NotCreatorErrorMessage);
            }
            return this.adventureRepository.Delete(adventureToDelete);
        }

        public List<Adventure> GetAll()
        {
            return this.adventureRepository.GetAll();
        }

        public Adventure GetById(int id)
        {
            return this.adventureRepository.GetById(id);
        }

        public Adventure Update(Adventure adventure, int id, User user)
        {
            Adventure updatedAdventure = adventureRepository.GetById(id);
            if(user.UserType != UserType.Admin && updatedAdventure.Module.Creator != user)
            {
                throw new UnauthorizedOperationException(NotCreatorErrorMessage);
            }
            return this.adventureRepository.Update(adventure, updatedAdventure);
        }
    }
}
