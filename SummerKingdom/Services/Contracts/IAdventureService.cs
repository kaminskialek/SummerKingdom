using Data.Models;

namespace Services.Contracts
{
    public interface IAdventureService
    {
        public Adventure Create(Adventure adventure, Module module, User user);

        public Adventure Update(Adventure adventure, int id, User user);

        public Adventure Delete(int id, User user);

        public Adventure GetById(int id, User user);

        public List<Adventure> GetAll();
    }
}
