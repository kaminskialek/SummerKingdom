using Common.Exceptions;
using Data.Models;
using Data.Repositories.Contracts;

namespace Data.Repositories
{
    public class AdventureRepository : IAdventureRepository
    {
        private readonly ApplicationDbContext adventureContext;

        private const string adventureNotFoundErrorMessage = "Adventure with id {0} cannot be found.";

        public AdventureRepository(ApplicationDbContext adventureContext)
        {
            this.adventureContext = adventureContext;
        }
        public Adventure Create(Adventure adventure, Module module)
        {
            adventureContext.Adventures.Add(adventure);

            module.Adventures.Add(adventure);

            adventureContext.SaveChanges();

            return adventure;
        }

        public Adventure Delete(Adventure adventureToDelete)
        {

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
            Adventure adventure = adventureContext.Adventures
                .FirstOrDefault(adventure => adventure.Id == id && adventure.DeletedOn.HasValue == false) ?? 
                throw new EntityNotFoundException(string.Format(adventureNotFoundErrorMessage, id));

            return adventure;
        }

        public Adventure Update(Adventure adventure, Adventure updatedAdventure)
        {

            updatedAdventure.Title = adventure.Title;
            updatedAdventure.Description = adventure.Description;

            adventureContext.SaveChanges();

            return updatedAdventure;
        }
    }
}
