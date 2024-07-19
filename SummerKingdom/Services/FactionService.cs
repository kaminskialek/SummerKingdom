using Data.Models;
using Data.Repositories.Contracts;
using Services.Contracts;

namespace Services
{
    public class FactionService : IFactionService
    {
        private readonly IFactionRepository factionRepository;
        public FactionService(IFactionRepository factionRepository)
        {
            this.factionRepository = factionRepository;
        }
        public Faction Create(Faction faction)
        {
            throw new NotImplementedException();
        }

        public Faction Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Faction> GetAll()
        {
            throw new NotImplementedException();
        }

        public Faction GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Faction Update(Faction faction, int id)
        {
            throw new NotImplementedException();
        }
    }
}
