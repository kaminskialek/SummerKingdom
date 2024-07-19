using Data.Models;

namespace Services.Contracts
{
    public interface IAdventureService
    {
        public Adventure Create(Adventure adventure);

        public Adventure Update(Adventure adventure, int id);

        public Adventure Delete(int id);

        public Adventure GetById(int id);

        public List<Adventure> GetAll();
    }
}
