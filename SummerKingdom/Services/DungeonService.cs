using Common;
using Common.Exceptions;
using Data.Models;
using Data.Repositories.Contracts;
using Services.Contracts;

namespace Services
{
    public class DungeonService : IDungeonService
    {
        private readonly IDungeonRepository dungeonRepository;
        public DungeonService(IDungeonRepository dungeonRepository)
        {
            this.dungeonRepository = dungeonRepository;
        }
        public Dungeon Create(Dungeon dungeon, Adventure adventure, User user)
        {
            if (user.UserType == UserType.Player)
            {
                throw new UnauthorizedOperationException(Constants.NotDMOrAdminErrorMessage);
            }
            return this.dungeonRepository.Create(dungeon, adventure);
        }

        public Dungeon Delete(int id, User user)
        {
            Dungeon dungeonToDelete = dungeonRepository.GetById(id);
            if (user.UserType != UserType.Admin && dungeonToDelete.Adventure.Module.Creator != user)
            {
                throw new UnauthorizedOperationException(Constants.NotCreatorOrAdminErrorMessage);
            }
            return this.dungeonRepository.Delete(dungeonToDelete);
        }

        public List<Dungeon> GetAll()
        {
            return this.dungeonRepository.GetAll();
        }

        public Dungeon GetById(int id, User user)
        {
            return this.dungeonRepository.GetById(id);
        }

        public Dungeon Update(Dungeon dungeon, int id, User user)
        {
            Dungeon updatedDungeon = dungeonRepository.GetById(id);
            if (user.UserType != UserType.Admin && updatedDungeon.Adventure.Module.Creator != user)
            {
                throw new UnauthorizedOperationException(Constants.NotCreatorOrAdminErrorMessage);
            }
            return this.dungeonRepository.Update(dungeon, updatedDungeon);   
        }
    }
}
