using Data.Models;
using Data.Repositories.Contracts;
using Services.Contracts;

namespace Services
{
    public class AdventureService : IAdventureService
    {
        private readonly IAdventureRepository adventureRepository;
        public AdventureService(IAdventureRepository adventureRepository)
        {
            this.adventureRepository = adventureRepository;
        }
        public Adventure Create(Adventure adventure)
        {
            return this.adventureRepository.Create(adventure);
        }

        public Adventure Delete(int id)
        {
            return this.adventureRepository.Delete(id);
        }

        public List<Adventure> GetAll()
        {
            return this.adventureRepository.GetAll();
        }

        public Adventure GetById(int id)
        {
            return this.adventureRepository.GetById(id);
        }

        public Adventure Update(Adventure adventure, int id)
        {
            return this.adventureRepository.Update(adventure, id);
        }
    }
}
