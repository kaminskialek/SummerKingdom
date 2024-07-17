using Data.Models;
using Data.Repositories.Contracts;

namespace Data.Repositories
{
    public class AdventureRepository : IAdventureRepository
    {
        private ApplicationDbContext adventureContext;

        public AdventureRepository(ApplicationDbContext adventureContext)
        {
            this.adventureContext = adventureContext;
        }
        public Adventure Create(Adventure adventure)
        {
            adventureContext.Adventures.Add(adventure);

            adventureContext.SaveChanges();

            return adventure;
        }

        public Adventure Delete(int id)
        {
            Adventure adventureToDelete = GetById(id);

            adventureToDelete.DeletedOn = DateTime.Now;

            adventureContext.SaveChanges();

            return adventureToDelete;
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
