using Data.Models;

namespace Services.Contracts
{
    public interface IDungeonService
    {
        public Dungeon Create(Dungeon dungeon, Adventure adventure, User user);

        public Dungeon Update(Dungeon dungeon, int id, User user);

        public Dungeon Delete(int id, User user);

        public Dungeon GetById(int id, User user);

        public List<Dungeon> GetAll();
    }
}
