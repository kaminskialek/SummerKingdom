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
            return this.factionRepository.Create(faction);
        }

        public Faction Delete(int id)
        {
            return this.factionRepository.Delete(id);
        }

        public List<Faction> GetAll()
        {
            return this.factionRepository.GetAll();
        }

        public Faction GetById(int id)
        {
            return this.factionRepository.GetById(id);
        }

        public Faction Update(Faction faction, int id)
        {
            return this.factionRepository.Update(faction, id);
        }
    }
}
