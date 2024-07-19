using Data.Models;

namespace Services.Contracts
{
    public interface IDungeonService
    {
        public Dungeon Create(Dungeon dungeon);

        public Dungeon Update(Dungeon dungeon, int id);

        public Dungeon Delete(int id);

        public Dungeon GetById(int id);

        public List<Dungeon> GetAll();
    }
}
