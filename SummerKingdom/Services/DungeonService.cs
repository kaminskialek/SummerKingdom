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
            return this.dungeonRepository.Create(dungeon, adventure);
        }

        public Dungeon Delete(int id, User user)
        {
            return this.dungeonRepository.Delete(id);
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
            return this.dungeonRepository.Update(dungeon, id);   
        }
    }
}
