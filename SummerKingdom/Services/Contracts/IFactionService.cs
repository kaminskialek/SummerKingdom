using Data.Models;

namespace Services.Contracts
{
    public interface IFactionService
    {
        public Faction Create(Faction faction, User user);

        public Faction Update(Faction faction, int id, User user);

        public Faction Delete(int id, User user);

        public Faction GetById(int id);

        public List<Faction> GetAll();
    }
}
