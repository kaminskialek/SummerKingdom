using Data.Models;

namespace Data.Repositories.Contracts
{
    public interface IAdventureRepository
    {
        public Adventure Create (Adventure adventure, Module module);

        public Adventure Update (Adventure adventure, Adventure updatedAdventure);

        public Adventure Delete (Adventure adventure);

        public Adventure GetById (int id);

        public List<Adventure> GetAll();
    }
}
