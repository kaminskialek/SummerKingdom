using Data.Models;

namespace Services.Contracts
{
    public interface IFactionService
    {
        public Faction Create(Faction faction);

        public Faction Update(Faction faction, int id);

        public Faction Delete(int id);

        public Faction GetById(int id);

        public List<Faction> GetAll();
    }
}
