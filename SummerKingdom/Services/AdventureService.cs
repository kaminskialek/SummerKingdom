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
            throw new NotImplementedException();
        }

        public Adventure Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Adventure> GetAll()
        {
            throw new NotImplementedException();
        }

        public Adventure GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Adventure Update(Adventure adventure, int id)
        {
            throw new NotImplementedException();
        }
    }
}
