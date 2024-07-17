using Common.Exceptions;
using Data.Models;
using Data.Repositories.Contracts;

namespace Data.Repositories
{
    public class FactionRepository : IFactionRepository
    {
        private readonly ApplicationDbContext factionContext;

        private const string factionNotFoundErrorMessage = "Faction with id {0} cannot be found.";
        public FactionRepository(ApplicationDbContext context)
        {
            this.factionContext = context;
        }
        public Faction Create(Faction faction)
        {
            factionContext.Factions.Add(faction);

            factionContext.SaveChanges();

            return faction;
        }

        public Faction Delete(int id)
        {
            Faction factionToDelete = GetById(id);

            factionToDelete.DeletedOn = DateTime.Now;

            factionContext.SaveChanges();

            return factionToDelete;
        }

        public List<Faction> GetAll()
        {
            throw new NotImplementedException();
        }

        public Faction GetById(int id)
        {
            Faction faction = factionContext.Factions.FirstOrDefault(f => f.Id == id)
             ?? throw new EntityNotFoundException(string.Format(factionNotFoundErrorMessage, id));

            return faction;
        }

        public Faction Update(Faction faction, int id)
        {
            Faction updatedFaction = GetById(id);

            updatedFaction.Name = faction.Name;
            updatedFaction.Description = faction.Description;   
            updatedFaction.Allies = faction.Allies;
            updatedFaction.Opponents = faction.Opponents;

            factionContext.SaveChanges();

            return updatedFaction;
        }
    }
}
