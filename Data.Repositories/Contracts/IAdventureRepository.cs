using Data.Models;

namespace Data.Repositories.Contracts
{
    public interface IAdventureRepository
    {
        public Adventure Create (Adventure adventure);

        public Adventure Update (Adventure adventure, int id);

        public Adventure Delete (int id);

        public Adventure GetById (int id);

        public List<Adventure> GetAll();
    }
}
