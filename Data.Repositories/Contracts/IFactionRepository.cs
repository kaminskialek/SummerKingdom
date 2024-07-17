using Data.Models;

namespace Data.Repositories.Contracts
{
    public interface IFactionRepository
    {
        public Faction Create(Faction faction);

        public Faction Update(Faction faction, int id);

        public Faction Delete(int id);

        public Faction GetById(int id);

        public List<Faction> GetAll();


    }
}
