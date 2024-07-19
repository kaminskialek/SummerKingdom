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
        public Adventure Create(Adventure adventure,Module module, User user)
        {
            
            return this.adventureRepository.Create(adventure, module);
        }

        public Adventure Delete(int id, User user)
        {
            return this.adventureRepository.Delete(id);
        }

        public List<Adventure> GetAll()
        {
            return this.adventureRepository.GetAll();
        }

        public Adventure GetById(int id, User user)
        {
            return this.adventureRepository.GetById(id);
        }

        public Adventure Update(Adventure adventure, int id, User user)
        {
            return this.adventureRepository.Update(adventure, id);
        }
    }
}
