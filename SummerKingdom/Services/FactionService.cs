using Common.Exceptions;
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
        public Faction Create(Faction faction, User user)
        {
            if (user.UserType != UserType.Admin)
            {
                throw new UnauthorizedOperationException("Only an Admin may add new factions to the world.");
            }
            return this.factionRepository.Create(faction);
        }

        public Faction Delete(int id, User user)
        {
            if(user.UserType != UserType.Admin)
            {
                throw new UnauthorizedOperationException("Only an Admin may delete factions.");
            }
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

        public Faction Update(Faction faction, int id, User user)
        {
            if (user.UserType != UserType.Admin)
            {
                throw new UnauthorizedOperationException("Only an Admin may update factions.");
            }
            return this.factionRepository.Update(faction, id);
        }
    }
}
