using Data.Models;

namespace Data.Repositories.Contracts
{
    public interface IDungeonRepository
    {
        public Dungeon Create(Dungeon dungeon, Adventure adventure);
        
        public Dungeon Update(Dungeon dungeon, int id);

        public Dungeon Delete(int id);

        public Dungeon GetById(int id);

        public List<Dungeon> GetAll();  
    }
}
