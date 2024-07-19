using Data.Models;
using Data.Repositories.Contracts;
using Services.Contracts;

namespace Services
{
    public class DungeonService : IDungeonService
    {
        private readonly IAdventureRepository adventureRepository;
        public DungeonService(IAdventureRepository adventureRepository)
        {
            this.adventureRepository = adventureRepository;
        }
        public Dungeon Create(Dungeon dungeon)
        {
            throw new NotImplementedException();
        }

        public Dungeon Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Dungeon> GetAll()
        {
            throw new NotImplementedException();
        }

        public Dungeon GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Dungeon Update(Dungeon dungeon, int id)
        {
            throw new NotImplementedException();
        }
    }
}
